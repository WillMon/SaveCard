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
        public string _name { get; set; }
        public string _description { get; set; }
        public string _gold { get; set; }
        public string _power { get; set; }

        public Treasure() { }
        public Treasure(string name, string description, string gold,string power)
        {
            _name = name;
            _description = description;
            _power = power;
            _gold = gold;
        }
    }
}
