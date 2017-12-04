using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RampupPI.Bank.Model;

namespace RampupPI.Bank.UI
{
    public partial class Form3 : Form
    {
        public DataBaseCustomers lc;
        public int aux;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HideFrm();


        }

        public void ReceiveListfrm2(DataBaseCustomers list)
        {
            lc = list;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            try
            {
                lc.lstAccount[aux].Deposit(Convert.ToDouble(value: txtValue.Text));
                ShowBalance();
            }
            catch (FormatException ecx)
            {
                MessageBox.Show("Formato invalido");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossivel realizar operação com valor negativo ou nulo");
            }

        }

        public void ShowBalance()
        {
            txtBalanceCustomer.Text = lc.lstAccount[aux].balance.ToString();
        }

        private void BtnW_Click(object sender, EventArgs e)
        {
            try
            {
                lc.lstAccount[aux].Withdraw(Convert.ToDouble(value: txtValue.Text));
                ShowBalance();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossivel realizar operação com valor negativo ou nulo");
            }
         
        }

        public void HideFrm()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            txtNameCustomer.Visible = false;
            txtTypeAccountCustomer.Visible = false;
            txtNAccountCustomer.Visible = false;
            txtBalanceCustomer.Visible = false;
            txtValue.Visible = false;

            btnD.Visible = false;
            BtnW.Visible = false;
            btnTransfer.Visible = false;
            txtItokenCustomer.Clear();
            txtValue.Clear();

            HideFrmTransfer();
        }

        public void HideFrmTransfer()
        {
            label7.Visible = false;
            textAnotherAccount.Visible = false;
            btnOkTransfer.Visible = false;
            btnCancel.Visible = false;
        }

        public void ShowFrm()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            txtNameCustomer.Visible = true;
            txtTypeAccountCustomer.Visible = true;
            txtNAccountCustomer.Visible = true;
            txtBalanceCustomer.Visible = true;
            txtValue.Visible = true;

            btnD.Visible = true;
            BtnW.Visible = true;
            btnTransfer.Visible = true;
        }

        public void ShowTransfer()
        {
            label7.Visible = true;
            textAnotherAccount.Visible = true;
            btnOkTransfer.Visible = true;
            btnD.Visible = false;
            BtnW.Visible = false;
            btnTransfer.Visible = false;
            btnCancel.Visible = true;
        }

        private void txtItokenCustomer_TextChanged(object sender, EventArgs e)
        {
            txtItokenCustomer.MaxLength = 3;

            if (txtItokenCustomer.TextLength == 0)
            {
                HideFrm();
            }
            if(txtItokenCustomer.TextLength==3)
            {
                int listL = lc.lstAccount.Count;
                int v = 0;
                for (int i = 0; i < listL; i++)
                {
                    if (txtItokenCustomer.Text == lc.lstAccount[i].itoken.ToString())
                    {


                        aux = i;
                        Outv(out v);

                    }

                }

                if (v > 0)
                {
                    txtNameCustomer.Text = lc.lstAccount[aux].customer.getName();
                    txtTypeAccountCustomer.Text = lc.lstAccount[aux].tAccount();
                    txtNAccountCustomer.Text = lc.lstAccount[aux].nAccount.ToString();
                    txtBalanceCustomer.Text = lc.lstAccount[aux].balance.ToString();
                    ShowFrm();
                }
                else
                {
                    MessageBox.Show("Código invalido, por favor digite novamente");
                    HideFrm();
                }
            }
        }

        private void Outv(out int v)
        {
           // v++;
            v = 0;
            v++;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            HideFrm();
            this.Close();
        }

        private void txtTypeAccountCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            textAnotherAccount.Clear();
            ShowTransfer();
        }

        private void btnOkTransfer_Click(object sender, EventArgs e)
        {
            int item = lc.lstAccount.Count;
            int j = 99;

            try
            {
                for (int i = 0; i < item; i++)
                {
                    if (textAnotherAccount.Text == lc.lstAccount[i].nAccount.ToString())
                    {
                        j = i;
                    }
                }
                if (j != 99)
                {
                    this.lc.lstAccount[aux].Transfer(lc.lstAccount[aux], lc.lstAccount[j], Convert.ToDouble(txtValue.Text));
                    ShowBalance();
                    HideFrmTransfer();
                    ShowFrm();
                }
                else
                {
                    MessageBox.Show("Por favor digite um numero de conta existente !!");
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossivel realizar operação com valor negativo ou nulo");
            }
        }

           

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
            HideFrmTransfer();
            ShowFrm();
        }
    }
}
