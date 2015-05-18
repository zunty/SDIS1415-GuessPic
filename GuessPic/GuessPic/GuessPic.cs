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
    public partial class GuessPic : Form
    {
        public GuessPic()
        {
            InitializeComponent();
            fb_login.MouseEnter += new EventHandler(fb_MouseEnter);
            fb_login.MouseLeave += new EventHandler(fb_MouseLeave);
            tw_login.MouseEnter += new EventHandler(tw_MouseEnter);
            tw_login.MouseLeave += new EventHandler(tw_MouseLeave);
            gp_login.MouseEnter += new EventHandler(gp_MouseEnter);
            gp_login.MouseLeave += new EventHandler(gp_MouseLeave);
            help_button.MouseEnter += new EventHandler(help_MouseEnter);
            help_button.MouseLeave += new EventHandler(help_MouseLeave);
            exit_button.MouseEnter += new EventHandler(exit_MouseEnter);
            exit_button.MouseLeave += new EventHandler(exit_MouseLeave);
        }

        private void fb_MouseLeave(object sender, EventArgs e)
        {
            this.fb_login.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_fb));
        }

        private void fb_MouseEnter(object sender, EventArgs e)
        {
            this.fb_login.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_fb_h));
        }

        private void tw_MouseLeave(object sender, EventArgs e)
        {
            this.tw_login.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_tw));
        }

        private void tw_MouseEnter(object sender, EventArgs e)
        {
            this.tw_login.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_tw_h));
        }

        private void gp_MouseLeave(object sender, EventArgs e)
        {
            this.gp_login.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_gp));
        }

        private void gp_MouseEnter(object sender, EventArgs e)
        {
            this.gp_login.Image = ((System.Drawing.Image)(Properties.Resources.guesspic_gp_h));
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
