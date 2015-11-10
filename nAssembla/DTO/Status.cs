using nAssembla.DTO.Interfaces;

namespace nAssembla.DTO
{
    public class Status : IStatus
    {
        public Status(int id, string name, bool open, int? order)
        {
            Id = id;
            Name = name;
            IsOpen = open;
            Order = order;
        }

        public bool IsOpen { get; private set; }

        public string Name { get; private set; }

        public int Id { get; private set; }

        public int? Order { get; private set; }
    }
}