using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardExample01
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void tratarMouse(Object sender, EventArgs e)
        {
            if (sender == button1) {
                tbResult.Text += button1.Text;
            } else if (sender == button2) {
                tbResult.Text += button2.Text;
            } else if (sender == button3) {
                tbResult.Text += button3.Text;
            } else if (sender == button4) {
                tbResult.Text += button4.Text;
            } else if (sender == btnClear) {
                String text = tbResult.Text;

                if (!String.IsNullOrEmpty(text)) {
                    text = text.Remove(text.Length - 1);
                    tbResult.Text = text;
                }
            }
        }

        public void tratarKeyboard(Object sender, KeyEventArgs key)
        {
            if ((key.KeyCode == Keys.D1) || (key.KeyCode == Keys.NumPad1)) {
                tbResult.Text += button1.Text;
            } else if ((key.KeyCode == Keys.D2) || (key.KeyCode == Keys.NumPad2)) {
                tbResult.Text += button2.Text;
            } else if ((key.KeyCode == Keys.D3) || (key.KeyCode == Keys.NumPad3)) {
                tbResult.Text += button3.Text;
            } else if ((key.KeyCode == Keys.D4) || (key.KeyCode == Keys.NumPad4)) {
                tbResult.Text += button4.Text;
            } else if (key.KeyCode == Keys.Back) {
                String text = tbResult.Text;

                if (!String.IsNullOrEmpty(text)) {
                    text = text.Remove(text.Length - 1);
                    tbResult.Text = text;
                }
            }
        }
    }
}
