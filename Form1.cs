using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGameMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadLevelEasy(object sender, EventArgs e)
        {
            LevelEasy levelWindow = new LevelEasy();

            levelWindow.Show();
        }

        private void LoadLevelHard(object sender, EventArgs e)
        {
            LevelHard levelWindow = new LevelHard();

            levelWindow.Show();

        }

    }
}
