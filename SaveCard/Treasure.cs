using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveCard
{
    [Serializable]
    public class Treasure
    {
        public string _dis { get; set; }
        public string _name { get; set; }
        public string _gold { get; set; }

        public Treasure() { }
        public Treasure(string name, string discription, string gold)
        {
            _name = name;
            _dis = discription;
            _gold = gold;
        }
    }
}
