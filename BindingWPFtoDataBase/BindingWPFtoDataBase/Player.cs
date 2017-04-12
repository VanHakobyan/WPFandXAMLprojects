using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingWPFtoDataBase
{
    public class Player
    {
        public string NamePlayer { get; set; }
        public string About { get; set; }
        public Player()
        {

        }
        public Player(string namePlayer,string about)
        {
            NamePlayer = namePlayer;
            About = about;
        }
    }
}
