using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForm01
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {
            cbOperacao.SelectedIndex = 0;
        }

        private void tbValor01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbValor02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbValor01.Text = String.Empty;
            tbValor02.Text = String.Empty;
            labelResult.Text = String.Empty;
            cbOperacao.SelectedIndex = 0; 
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int op = 0;
            double v1 = 0, v2 = 0, result = 0;

            try {
                v1 = Double.Parse(tbValor01.Text);
                v2 = Double.Parse(tbValor02.Text);
                op = cbOperacao.SelectedIndex;

                switch(op) {
                    case 0:
                        MessageBox.Show(
                            "Por favor, selecione uma operação!",
                            "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        break;
                    case 1:
                        result = v1 + v2;
                        labelResult.Text = Convert.ToString(result);
                        break;
                    case 2:
                        result = v1 - v2;
                        labelResult.Text = Convert.ToString(result);
                        break;
                    case 3:
                        result = v1 * v2;
                        labelResult.Text = Convert.ToString(result);
                        break;
                    case 4:
                        if (v2 != 0) {
                            result = v1 / v2;
                            labelResult.Text = Convert.ToString(result);
                        } else {
                            MessageBox.Show(
                                "O valor 02 não pode ser zero!",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );

                            tbValor01.Text = String.Empty;
                            tbValor02.Text = String.Empty;
                            labelResult.Text = String.Empty;
                            cbOperacao.SelectedIndex = 0;
                        }

                        break;      
                }

            } catch {
                MessageBox.Show(
                    "Você digitou valores incorretor",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                tbValor01.Text = String.Empty;
                tbValor02.Text = String.Empty;
                labelResult.Text = String.Empty;
                cbOperacao.SelectedIndex = 0;
            }
        }
    }
}
