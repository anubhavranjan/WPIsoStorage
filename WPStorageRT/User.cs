using System;

namespace WPStorageRT
{
    public class User
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public DateTime AddedOn { get; set; }

        public string DisplayAddedOn
        {
            get { return AddedOn.ToString("F"); }
        }

        public string DisplayId
        {
            get { return Id.ToString(); }
        }
    }
}
