using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPIsoStorage
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
