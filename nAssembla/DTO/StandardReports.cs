using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nAssembla.DTO.Enums;
using nAssembla.DTO.Interfaces;

namespace nAssembla.DTO
{
    public static class StandardReports
    {
        private static IReport _allAuthenticatedUserActiveTickets;

        public static IReport AllTickets
        {
            get { return new Report(0, "All Tickets"); }
        }

        public static IReport ActiveTickets_OrderByMilestone
        {
            get { return new Report(1, "Active Tickets, order by milestone"); }
        }

        public static IReport ActiveTickets_OrderByComponent
        {
            get { return new Report(2, "Active Tickets, order by component"); }
        }

        public static IReport ActiveTickets_OrderByUser
        {
            get { return new Report(3, "Active Tickets, order by user"); }
        }

        public static IReport ClosedTickets_OrderByMilestone
        {
            get { return new Report(4, "Closed Tickets, order by milestone"); }
        }

        public static IReport ClosedTickets_OrderByComponent
        {
            get { return new Report(5, "Closed Tickets, order by component"); }
        }

        public static IReport ClosedTickets_OrderByUser
        {
            get { return new Report(6, "Closed Tickets, order by user"); }
        }

        public static IReport AllAuthenticatedUserTickets
        {
            get {
                if(_allAuthenticatedUserActiveTickets == null)
                    _allAuthenticatedUserActiveTickets = new Report(7, "All user tickets (authenticated user)");
                return _allAuthenticatedUserActiveTickets;
            }
        }

        public static IReport AllAuthenticatedUserActiveTickets
        {
            get { return new Report(8, "All user's active tickets (authenticated user)"); }
        }

        public static IReport AllAuthenticatedUserClosedTickets
        {
            get { return new Report(9, "All user's closed tickets (authenticated user)"); }
        }

        public static IReport AllAuthenticatedUserFollowedTickets
        {
            get { return new Report(10, "All user's followed tickets (authenticated user)"); }
        }

        public static IEnumerable<IReport> AllStandardReports
        {
            get {
                var reports = new List<IReport>
                {
                    AllTickets,
                    ActiveTickets_OrderByMilestone,
                    ActiveTickets_OrderByComponent,
                    ActiveTickets_OrderByUser,
                    ClosedTickets_OrderByMilestone,
                    ClosedTickets_OrderByComponent,
                    ClosedTickets_OrderByUser,
                    AllAuthenticatedUserTickets,
                    AllAuthenticatedUserActiveTickets,
                    AllAuthenticatedUserClosedTickets,
                    AllAuthenticatedUserFollowedTickets
                };
                return reports;
            }
        }

        
    }

    public class Report : IReport
    {
        public Report(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ReportType Type
        {
            get { return ReportType.Standard; }
        }

        public string Name { get; private set; }

        public int Id { get; private set; }
    }


}
