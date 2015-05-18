using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessPic
{
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
            help_button.MouseEnter += new EventHandler(help_MouseEnter);
            help_button.MouseLeave += new EventHandler(help_MouseLeave);
            exit_button.MouseEnter += new EventHandler(exit_MouseEnter);
            exit_button.MouseLeave += new EventHandler(exit_MouseLeave);
            send_button.MouseEnter += new EventHandler(send_MouseEnter);
            send_button.MouseLeave += new EventHandler(send_MouseLeave);
        }

        private void help_MouseLeave(object sender, EventArgs e)
        {
            this.help_button.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_help));
        }

        private void help_MouseEnter(object sender, EventArgs e)
        {
            this.help_button.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_help_h));
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            this.exit_button.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_exit));
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            this.exit_button.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_exit_h));
        }

        private void send_MouseLeave(object sender, EventArgs e)
        {
            this.send_button.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_send));
        }

        private void send_MouseEnter(object sender, EventArgs e)
        {
            this.send_button.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_send_h));
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Room r = new Room();
            r.Show();
            this.Hide();
        }
    }
}
