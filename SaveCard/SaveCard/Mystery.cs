using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveCard
{
    [Serializable]
    public class Mystery
    {
        public string _name { get; set; }
        public string _description { get; set; }
        public string _type { get; set; }
        public string _power { get; set; }

        public Mystery() { }
        public Mystery(string name, string description, string type, string power)
        {
            _name = name;
            _description = description;
            _power = power;
            _type = type;
        }
    }
}
