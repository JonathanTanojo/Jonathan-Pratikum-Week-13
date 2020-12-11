using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxinput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonproses_Click(object sender, EventArgs e)
        {
            if (labelempty.Text != "[EMPTY]")
            {
                if (textBoxinput.Text == "DELETE")
                {
                    labelempty.Text = "[EMPTY]";
                    labelempty.ForeColor = Color.Black;
                }
                if (textBoxinput.Text == "SHOWN")
                {
                    labelempty.Visible = true; 
                }
                if (textBoxinput.Text == "HIDE")
                {
                    labelempty.Visible = false;
                }
                if (textBoxinput.Text == "RED")
                {
                    labelempty.ForeColor = Color.Red;
                }
                if (textBoxinput.Text == "BLUE")
                {
                    labelempty.ForeColor = Color.Blue;
                }
                if (textBoxinput.Text == "GREEN")
                {
                    labelempty.ForeColor = Color.Green;
                }
            }
            else
            {
                labelempty.Text = textBoxinput.Text;
            }
        }

        private void textBoxinput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonproses_Click(sender, e);
            }
        }
    }
}
