using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nAssembla;

namespace nAssembla.TestHarness
{
    public partial class EditTicket : Form
    {
        public EditTicket()
        {
            InitializeComponent();
            Load += EditTicket_Load;
        }

        async void EditTicket_Load(object sender, EventArgs e)
        {
            var custStatus = await NAssembla.CustomStatusProxy.GetListAsync();
            var statii = nAssembla.DTO.StandardStatus.GetAllStandardStatuses.Union(custStatus);
            statii.ToList().Insert(0, new DTO.CustomStatus { Name = "" });
            status.DataSource = statii.ToList();

            priority.DataSource = new List<nAssembla.DTO.Enums.Priority>() { nAssembla.DTO.Enums.Priority.Highest, nAssembla.DTO.Enums.Priority.High, nAssembla.DTO.Enums.Priority.Normal, nAssembla.DTO.Enums.Priority.Low, nAssembla.DTO.Enums.Priority.Lowest };

            assignee.DataSource = (await NAssembla.UserProxy.GetListAsync()).PrependBlank();

            component.DataSource = (await NAssembla.TicketComponentProxy.GetListAsync()).PrependBlank();

            milestone.DataSource = (await NAssembla.MilestoneProxy.GetListAsync()).PrependBlank();

            ticketBindingSource.DataSource = DataSource;
            await NAssembla.TicketProxy.GetCommentsForTicket(DataSource);
            ticketCommentBindingSource.DataSource = DataSource.Comments;

            if (DataSource.Number > 0)
                this.Text = "Edit Ticket: #" + DataSource.Number.ToString();
            else
                this.Text = "Add New Ticket";
            //listView1.Items 
        }

        public DTO.Ticket DataSource {get ; set;}

        private async void addComment_Click(object sender, EventArgs e)
        {
            await NAssembla.TicketProxy.AddCommentToTicketAsync(DataSource, newComment.Text);
            newComment.Text = null;
        }
        
    }
}
