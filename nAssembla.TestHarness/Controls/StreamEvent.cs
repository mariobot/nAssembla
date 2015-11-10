using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nAssembla.TestHarness.Controls
{
    public partial class StreamEvent : UserControl
    {
        public StreamEvent()
        {
            InitializeComponent();
            Load += StreamEvent_Load;
        }

        void StreamEvent_Load(object sender, EventArgs e)
        {
            title.Text = DataSource.Title;
            summary.Text = DataSource.CommentOrDescription;
            user.Text = DataSource.AuthorName;
            action.Text = DataSource.Operation;
            time.Text = DataSource.Date.ToShortTimeString();
        }

        public DTO.Event DataSource { get; set; }
    }
}
