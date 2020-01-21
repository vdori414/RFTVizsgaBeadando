using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFT_Jatek
{
    class Laser
    {
        private int sebzes;
        public int Sebzes
        {
            get { return sebzes; }
            set { sebzes = value; }
        }

        private Position position;
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        private int hossz;
        public int Hossz
        {
            get { return hossz; }
            set { hossz = value; }
        }

        private int kilove;
        public int Kilove
        {
            get { return kilove; }
            set { kilove = value; }
        }

        public void MozgatFelfele(int value)
        {
            Position.Top -= value;
        }

        public Laser(int Sebzes, int Hossz, Position Position)
        {
            this.Sebzes = Sebzes;
            this.Hossz = Hossz;
            this.Position = Position;
        }
    }
}
