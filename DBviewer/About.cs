using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBviewer
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.github.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/umidumur/DBviewer");
        }

        private void telegram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.telegram.LinkVisited = true;
            System.Diagnostics.Process.Start("https://umidumur.t.me");
        }

        private void discord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.discord.LinkVisited = true;
            System.Diagnostics.Process.Start("https://discordapp.com/users/667714495010832384");
        }
    }
}
