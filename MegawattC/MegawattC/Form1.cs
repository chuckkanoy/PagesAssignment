using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegawattC
{
    public partial class Form1 : Form
    {
        private String first;
        private String last;
        private String phone;
        private int num;
        private double deposit;
        private const double BASE = 2000;
        private const double EXPRESS = .05;
        private const double MULTI = 300;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //check all necessary values
            if (Check_First(txtFirst.Text))
                first = txtFirst.Text;
            if (Check_Last(txtLast.Text))
                last = txtLast.Text;
            if (Check_Phone(txtPhone.Text))
                phone = txtPhone.Text;
            if (Check_Num(txtNumPanels.Text))
                num = Convert.ToInt32(txtNumPanels.Text);
            if (Check_Deposit(txtDeposit.Text))
                deposit = Convert.ToDouble(txtDeposit.Text);
            
            if(!(Check_First(txtFirst.Text) && Check_Last(txtLast.Text) && Check_Phone(txtPhone.Text) && Check_Num(txtNumPanels.Text) && Check_Deposit(txtDeposit.Text)))
            {
                MessageBox.Show("Invalid input");
                return;
            }

            //output necessary info
            lblBase.Text = BASE.ToString("c");
            lblAdditional.Text = Calc_Additional(num).ToString("c");
            lblTotal.Text = Calc_Total(num).ToString("c");
            lblDeposit.Text = deposit.ToString("c");
            
            //change balance to refund if necessary
            if(Calc_Total(num) <= deposit)
            {
                lblChanger.Text = "Refund:";
                lblBalance.Text = (-(deposit - Calc_Total(num))).ToString("c");
            }
            else
            {
                lblChanger.Text = "Balance due:";
                lblBalance.Text = (Calc_Total(num) - deposit).ToString("c");
            }
        }
        private double Calc_Total(int num)
        {
            if (chkExpress.Checked)
            {
                return 1.05 * (BASE + Calc_Additional(num));
            }
            else
            {
                return BASE + Calc_Additional(num);
            }
        }
        private double Calc_Additional(int num)
        {
            if (num >= 2)
            {
                return num * MULTI;
            }
            else
            {
                return 0;
            }
        }
        private bool Check_First(String s)
        {
            bool validated = Regex.IsMatch(s, @"^[a-zA-Z]+$");

            if (!validated)
                txtFirst.Text = "Enter Name";

            return validated;
        }
        private bool Check_Last(String s)
        {
            bool validated = Regex.IsMatch(s, @"^[a-zA-Z]+$");

            if (!validated)
                txtLast.Text = "Enter Name";

            return validated;
        }
        private bool Check_Phone(String s)
        {
            bool validated = Regex.IsMatch(s, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}");

            if (!validated)
                txtPhone.Text = "Enter Phone";

            return validated;
        }
        private bool Check_Num(String s)
        {
            bool validated = Regex.IsMatch(s, @"^[0-9]+$");

            if (!validated)
                txtNumPanels.Text = "Enter Integer";
            else
            {
                int temp = Convert.ToInt32(s);
                if (!(temp <= 1000 && temp > 0))
                {
                    validated = false;
                }
            }

            return validated;
        }
        private bool Check_Deposit(String s)
        {
            bool validated = Regex.IsMatch(s, @"^[0-9]*(\.[0-9]{1,2})?$");

            if (!validated)
                txtDeposit.Text = "Enter Decimal";

            return validated;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtLast.Text = "";
            txtDeposit.Text = "";
            txtNumPanels.Text = "";
            txtPhone.Text = "";
            chkExpress.Checked = false;
            lblAdditional.Text = "";
            lblBalance.Text = "";
            lblBase.Text = "";
            lblDeposit.Text = "";
            lblTotal.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
