using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robux_Converter
{
    public partial class Form1 : Form
    {
        //sets up currency and ppr (price per robux)
        string Currency = "USD";
        decimal OneRBX = 125;
        bool wow = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selectCurrencyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uSDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currency = "USD";
            OneRBX = 125;

        }

        private void cADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currency = "CAD";
            OneRBX = 173;
        }

        private void eUROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currency = "EURO";
            OneRBX = 102;
        }

        private void britishPoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Currency = "Pound";
            OneRBX = 89;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            wow = true;
            while (progressBar1.Value != 100)
            {
                progressBar1.Value = (progressBar1.Value + 1);
                Thread.Sleep(10);
                if (progressBar1.Value == 100)
                {
                    progressBar1.Value = 0;
                    progressBar1.Visible = false;
                    wow = false; break;
                }
                
            }

            

            string Outcome = Convert.ToString(numericUpDown1.Value * OneRBX / 10000);
            label1.Text = "Your robux is worth: $" + Outcome;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
