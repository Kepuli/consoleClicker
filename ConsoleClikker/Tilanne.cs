using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClikker {
    public class Tilanne {
        public int z2;
        public int x2;
        public int z; 
        public int x;
        public int y;
        public int korotus;
        public bool butterKaytetty;

        public Tilanne() {
            Restart();
        }

        public bool GrandmamaOK() {
            return x >= 100;
        }

        internal void Restart() {
            x = 0;
            z = 0;
            y = 0;
            x2 = 200;
            z2 = 5;
            butterKaytetty = false;
            korotus = 1;
        }

        public bool GrandmamaSallittu {
            get {
                return x >= 100;
            }
        }
    }
}
