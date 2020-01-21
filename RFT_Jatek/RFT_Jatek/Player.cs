using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFT_Jatek
{
    class Player
    {
        private string nev;
        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        private int eletero;
        public int Eletero
        {
            get { return eletero; }
            private set
            {
                if (value < 0 || value > 100) throw new Exception("Hiba");
                eletero = value;
            }
        }

        private int sebzes;
        public int Sebzes
        {
            get { return sebzes; }
            set
            {
                if (value < 0) throw new Exception("Hiba");
                sebzes = value;
            }
        }

        private Position position;
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        public void Sebzodik(int value)
        {
            if ((Eletero - value) < 0) Eletero = 0;
            else Eletero -= value;
        }

        public void BalraMozgat(int value)
        {
            Position.Left -= value;
        }

        public void JobbraMozgat(int value)
        {
            Position.Left += value;
        }

        public Player(string Nev, int Eletero, int Sebzes)
        {
            this.Nev = Nev;
            this.Eletero = Eletero;
            this.Sebzes = Sebzes;
            Position = new Position();
        }

        public Player(string Nev, int Eletero, int Sebzes,
                        Position Position) : this(Nev, Eletero, Sebzes)
        {
            this.Position = Position;
        }
    }
}
