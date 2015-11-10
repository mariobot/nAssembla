using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nAssembla.TestHarness.ViewModel
{
    public class TicketDetail : DTO.Ticket
    {
        public TicketDetail(DTO.Ticket t)
        {
            this.Id = t.Id;
            this.Summary = t.Summary;
            this.Priority = t.Priority;
            this.CreatedOn = t.CreatedOn;
            this.UpdatedAt = t.UpdatedAt;
            this.MilestoneId = t.MilestoneId;
            this.StatusName = t.StatusName;
            this.AssignedTo = t.AssignedTo;
            this.CompletedDate = t.CompletedDate;
            this.ComponentId = t.ComponentId;
            this.CustomFields = t.CustomFields;
            this.Description = t.Description;
            this.Estimate = t.Estimate;
            this.Followers = t.Followers;
            this.Importance = t.Importance;
            this.IsOpen = t.IsOpen;
            this.IsStory = t.IsStory;
            this.Number = t.Number;
            this.StoryImportance = t.StoryImportance;

            Component = t.Component;
            Milestone = t.Milestone;
            Assignee = t.Assignee;
            Reporter = t.Reporter;
        }

        public string AssigneeName
        {
            get
            {
                return Assignee != null ? Assignee.Name : null;
            }
        }

        public string ReporterName
        {
            get
            {
                return Reporter != null ? Reporter.Name : null;
            }
        }

        public string MilestoneName
        {
            get
            {
                return Milestone != null ? Milestone.Title : null;
            }
        }

        public string ComponentName 
        {
            get
            {
                return Component != null ? Component.Name : null;
            }
        }
    }
}
