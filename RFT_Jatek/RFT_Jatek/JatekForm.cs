using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFT_Jatek
{
    public partial class JatekForm : Form
    {
        private Timer loop;
        private Player player;
        private Laser laser;

        public JatekForm(string name)
        {
            InitializeComponent();

            loop = new Timer();
            loop.Interval = 1;
            loop.Tick += loop_Tick;
            loop.Start();

            player = new Player(name, 100, 50, new Position(jatekter.Height - pb_player.Height - 10, jatekter.Width / 2 - pb_player.Width / 2));
            lb_name.Text = player.Nev;

            laser = new Laser(player.Sebzes, 25, new Position());
            pb_laser.Visible = false;
        }

        void loop_Tick(object sender, EventArgs e)
        {
            pb_player.Top = player.Position.Top;
            pb_player.Left = player.Position.Left;

            pb_laser.Top = laser.Position.Top;
            pb_laser.Left = laser.Position.Left;

            laser.MozgatFelfele(10);
            if (laser.Position.Top - 10 >= pb_laser.Height)
            {
                laser.MozgatFelfele(10);
            }
            else
            {
                laser.Kilove = false;
            }
        }


    }
}
