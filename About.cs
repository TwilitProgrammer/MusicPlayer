using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

using WiimoteLib;

namespace Music_Player
{
    public partial class About : Form
    {
        Song silence = new Song();

        public About()
        {
            InitializeComponent();
            
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            silence.PlaySong();
        }
    }
}
