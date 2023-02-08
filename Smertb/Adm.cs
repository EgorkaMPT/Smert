using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smertь
{
    
    internal class Adm
    {
        public int id;
        public string Lg;
        public string Pass;
        public R Role;
        public Adm(int id, string lg, string pass, R role)
        {
            this.id = id;
            Lg = lg;
            Pass = pass;
            Role = role;
        }
        Adm() { }
    }
}
