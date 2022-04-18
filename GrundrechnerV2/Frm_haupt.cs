using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrundrechnerV2
{
    public partial class Frm_haupt : Form
    {
        int[] iteamList1, iteamList2;

        public Frm_haupt()
        {
            InitializeComponent();
        }

        private void rBtn_add_CheckedChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lBx_z1.GetItemText(lBx_z1.SelectedItem)))
            {
                MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rBtn_add.Checked = false;
            }
            else
            {
                if (string.IsNullOrEmpty(lBx_z2.GetItemText(lBx_z2.SelectedItem)))
                {
                    MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rBtn_add.Checked = false;
                }
                else
                {
                    int selected_num1 = Convert.ToInt32(lBx_z1.GetItemText(lBx_z1.SelectedItem));
                    int selected_num2 = Convert.ToInt32(lBx_z2.GetItemText(lBx_z2.SelectedItem));
                    int result = selected_num1 + selected_num2;
                    lbl_ergebnis.Text = "Ergebnis: " + selected_num1 + " + " + selected_num2 + " = " + result;
                }
         
            }

        }

        private void rBtn_sub_CheckedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lBx_z1.GetItemText(lBx_z1.SelectedItem)))
            {
                MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rBtn_sub.Checked = false;
            }
            else
            {
                if (string.IsNullOrEmpty(lBx_z2.GetItemText(lBx_z2.SelectedItem)))
                {
                    MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rBtn_sub.Checked = false;
                }
                else
                {
                    int selected_num1 = Convert.ToInt32(lBx_z1.GetItemText(lBx_z1.SelectedItem));
                    int selected_num2 = Convert.ToInt32(lBx_z2.GetItemText(lBx_z2.SelectedItem));
                    int result = selected_num1 - selected_num2;
                    lbl_ergebnis.Text = "Ergebnis: " + selected_num1 + " - " + selected_num2 + " = " + result;
                }
             
            }
        }

        private void rBtn_multi_CheckedChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lBx_z1.GetItemText(lBx_z1.SelectedItem)))
            {
                MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rBtn_multi.Checked = false;
            }
            else
            {
                if (string.IsNullOrEmpty(lBx_z2.GetItemText(lBx_z2.SelectedItem)))
                {
                    MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rBtn_multi.Checked = false;
                }
                else
                {
                    int selected_num1 = Convert.ToInt32(lBx_z1.GetItemText(lBx_z1.SelectedItem));
                    int selected_num2 = Convert.ToInt32(lBx_z2.GetItemText(lBx_z2.SelectedItem));
                    int result = selected_num1 * selected_num2;
                    lbl_ergebnis.Text = "Ergebnis: " + selected_num1 + " * " + selected_num2 + " = " + result;

                }
             }


          
        }

        private void rBtn_div_CheckedChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(lBx_z1.GetItemText(lBx_z1.SelectedItem)))
            {
                MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rBtn_div.Checked = false;
            }
            else
            {
                if (string.IsNullOrEmpty(lBx_z2.GetItemText(lBx_z2.SelectedItem)))
                {
                    MessageBox.Show("Wählen Sie ein Element aus der Elementliste aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    rBtn_div.Checked = false;
                }
                else
                {
                    int selected_num1 = Convert.ToInt32(lBx_z1.GetItemText(lBx_z1.SelectedItem));
                    int selected_num2 = Convert.ToInt32(lBx_z2.GetItemText(lBx_z2.SelectedItem));
                    if(selected_num1 == 0)
                    {
                        MessageBox.Show("Division durch 0 geht nicht. Wählen Sie andere zahl größer als 0 aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        rBtn_div.Checked = false;

                    }
                    else
                    {
                        if(selected_num2 == 0)
                        {
                            MessageBox.Show("Division durch 0 geht nicht. Wählen Sie andere zahl größer als 0 aus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            rBtn_div.Checked = false;
                        }
                        else
                        {
                            int remainder;
                            int quotient = Math.DivRem(selected_num1, selected_num2, out remainder);
                            lbl_ergebnis.Text = "Ergebnis: " + selected_num1 + " / " + selected_num2 + " = " + quotient + ", Rest: " + remainder;

                        }

                    }

                }
            }


            

        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tB_pot_z1.Text))
            {
                tB_pot_z1.Focus();
                errorProvider1.SetError(tB_pot_z1, "Geben sie bitte Ganzzahl ein.");
            }
            else
            {
                if (string.IsNullOrEmpty(tB_pot_z2.Text)) {
                    tB_pot_z2.Focus();
                    errorProvider2.SetError(tB_pot_z2, "Geben sie bitte Ganzzahl ein.");
                }
                else
                {
                    iteamList1 = new int[11];
                    iteamList2 = new int[11];
                    int inputed_value1 = Convert.ToInt32(tB_pot_z1.Text);
                    int inputed_value2 = Convert.ToInt32(tB_pot_z2.Text);
                    int multyply_num1 = 0;
                    int multyply_num2 = 0;
                    for (int i = 0; i < iteamList1.Length; i++)
                    {
                        iteamList1[i] = inputed_value1 * multyply_num1;
                        multyply_num1++;
                    }

                    for (int i = 0; i < iteamList2.Length; i++)
                    {
                        iteamList2[i] = inputed_value2 * multyply_num2;
                        multyply_num2++;
                    }
                    foreach (int z in iteamList1)
                    {
                        lBx_z1.Items.Add(z);
                    }
                    foreach (int z in iteamList2)
                    {
                        lBx_z2.Items.Add(z);
                    }
                }
            }
            
        }
    }
}
