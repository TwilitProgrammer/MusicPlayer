using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class SongForm : Form
    {
        Song silence = new Song();
        string part1 = "You played ";
        string total;
        public SongForm(string part2)
        {
            label1 = new Label();
             InitializeComponent();
            total = part1 + part2 + "!";
            label1.Text = total;
        }


        private void SongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            silence.PlaySong();
        }

    }
}
