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
        public string _dis { get; set; }
        public string _name { get; set; }
        public string _type { get; set; }
        public string _power { get; set; }

        public Mystery() { }
        public Mystery(string name, string discription, string type, string power)
        {
            _name = name;
            _dis = discription;
            _power = power;
            _type = type;
        }
    }
}
