using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vyjimky_du_priklad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double mojepowfunkce(double a, int n)
        {
            double vysledek = 1;
            int i = 0;
                if (n >= 0)
                {
                    while (i < n)
                    {
                        vysledek = vysledek * a;
                        i++;
                    }
                    return vysledek;
                }
                else
                {
                    for (int lol = 0; lol > n; lol--)
                    {
                        vysledek *= a;
                    }

                    return vysledek = 1 / vysledek;
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                checked
                {
                    double a = double.Parse(textBox1.Text);
                    int n = int.Parse(textBox2.Text);
                    label5.Text = mojepowfunkce(a, n).ToString();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Špatný formát, zadej číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Přetekl limit, zadej menší číslo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vyskytla se tato chyba: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Provedlo či neprovedlo, to je jedno :)\nZkus to ještě jednou!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                label5.Text = "";
            }
            
        }
    }
}
