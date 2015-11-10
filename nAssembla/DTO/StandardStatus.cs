using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nAssembla.DTO.Interfaces;

namespace nAssembla.DTO
{
    public static class StandardStatus
    {
        public static IStatus New
        {
            get { return new Status(0, "New", true, 0 ); }
        }

        public static IStatus Accepted 
        {
            get { return new Status(1, "Accepted", true, 1); }
        }

        public static IStatus Invalid
        {
            get { return new Status(2, "Invalid", false, 2); }
        }

        public static IStatus Fixed
        {
            get { return new Status(3, "Fixed", false, 3); }
        }

        public static IStatus Test
        {
            get { return new Status(4, "Test", true, 4); }
        }

        public static IEnumerable<IStatus> GetAllStandardStatuses
        {
            get
            {
                return new List<IStatus>()
                {
                    New,
                    Accepted,
                    Invalid,
                    Fixed,
                    Test
                };
            }
        }
    }

}
