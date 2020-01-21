using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFT_Jatek
{
    class Position
    {
        private int top;
        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        private int left;
        public int Left
        {
            get { return left; }
            set { left = value; }
        }

        public Position()
        {
            this.Top = 0;
            this.Left = 0;
        }

        public Position(int Top, int Left)
        {
            this.Top = Top;
            this.Left = Left;
        }
    }
}
