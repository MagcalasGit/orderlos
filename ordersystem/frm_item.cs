using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordersystem
{
    public partial class frm_item : Form
    {
        const double price_TaconBurr = 30.00;
        const double price_FriedChicken = 40.00;
        const double price_Quesadilla = 15.00;
        const double price_BigMac = 25.00;
        const double price_Coca = 18.00;
        const double price_DrPep = 20.00;
        const double price_IcedTea = 23.00;
        const double price_Pepsi = 19.00;
        public frm_item()
        {
            InitializeComponent();
        }

        private void ExtOsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_item_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
            bx_Payment.Items.Add("Cash on Delivery");
            bx_Payment.Items.Add("Online Payment");
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void TacBurBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (TacBurBtn.Checked == true)
            {
                txt_tacbur.Enabled = true;
                txt_tacbur.Text = "";
                txt_tacbur.Focus();
            }
            else
            {
                txt_tacbur.Enabled = false;
                txt_tacbur.Text = "0";
            }
        }

        private void txt_Chick_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_bigmac_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cola_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DrPep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Peps_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tacbur_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChickBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickBtn.Checked == true)
            {
                txt_Chick.Enabled = true;
                txt_Chick.Text = "0";
                txt_Chick.Focus();
            }
            else
            {
                txt_Chick.Enabled = false;
                txt_Chick.Text = "0";
            }
        }

        private void QuessaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (QuessaBtn.Checked == true)
            {
                txt_quesa.Enabled = true;
                txt_quesa.Text = "0";
                txt_quesa.Focus();
            }
            else
            {
                txt_quesa.Enabled = false;
                txt_quesa.Text = "0";
            }
        }

        private void BigMacBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (BigMacBtn.Checked == true)
            {
                txt_bigmac.Enabled = true;
                txt_bigmac.Text = "0";
                txt_bigmac.Focus();
            }
            else
            {
                txt_bigmac.Enabled = false;
                txt_bigmac.Text = "0";
            }
        }

        private void CokeBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (CokeBtn.Checked == true)
            {
                txt_cola.Enabled = true;
                txt_cola.Text = "0";
                txt_cola.Focus();
            }
            else
            {
                txt_cola.Enabled = false;
                txt_cola.Text = "0";
            }
        }

        private void DrPepBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (DrPepBtn.Checked == true)
            {
                txt_DrPep.Enabled = true;
                txt_DrPep.Text = "0";
                txt_DrPep.Focus();
            }
            else
            {
                txt_DrPep.Enabled = false;
                txt_DrPep.Text = "0";
            }
        }

        private void PepsiBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (PepsiBtn.Checked == true)
            {
                txt_Peps.Enabled = true;
                txt_Peps.Text = "0";
                txt_Peps.Focus();
            }
            else
            {
                txt_Peps.Enabled = false;
                txt_Peps.Text = "0";
            }
        }

        private void IcedTeaBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (IcedTeaBtn.Checked == true)
            {
                txt_Tea.Enabled = true;
                txt_Tea.Text = "0";
                txt_Tea.Focus();
            }
            else
            {
                txt_Tea.Enabled = false;
                txt_Tea.Text = "0";
            }
        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {
            //txt_Name.Enabled;
        }

        private void bx_Payment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPayment = bx_Payment.SelectedItem.ToString();

            if (selectedPayment == "Cash on Delivery")
            {
                // Handle Cash on Delivery payment
            }
            else if (selectedPayment == "Online Payment")
            {
                // Handle Online Payment
            }
        }
            
            
        private void btn_proceed_Click(object sender, EventArgs e)
        {
            
        }

    }
}
