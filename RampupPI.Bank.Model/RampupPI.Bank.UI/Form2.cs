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
    public partial class Form2 : Form
    {
        public DataBaseCustomers l = new DataBaseCustomers();
        public int total=0;
        public Form3 frmCustomer = new Form3();
     
        public Form2()
        {
            InitializeComponent();
            comboTypeAccount.DataSource = Enum.GetValues(typeof(TypeAccount));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CleanFrm();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CleanFrm();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateAccount();
           
        }

        public void CreateAccount()
        {
            int check;
            check = CheckcFields();
            switch (check)
            {
                case 0:
                    MessageBox.Show("Por favor preencha todos os campos");
                    break;
                default:
                    Customer newCustomer = new Customer(name: txtName.Text, cpf: txtCPF.Text);
                    Account c;
                    c = CheckAccount(comboTypeAccount.SelectedIndex, newCustomer);
                    comboCustomers.SelectedIndex = -1;
                    Register(c);
                    break;
            }
        }

    
        private Account CheckAccount(int index,Customer c)
        {
            var idGuid = Guid.NewGuid();
            StringBuilder sb = new StringBuilder();
            sb.Append(idGuid);
            sb.Remove(3, 33);
            Account sa;
            if (index == 1)
            {
                sa = new SavingsAccount(nAccount:Convert.ToInt32(txtNAccount.Text),customer: c, indexTypeAccount:comboTypeAccount.SelectedIndex,itoken:sb);
                return sa;
            }
            else
            {
                Account ca;
                ca = new CurrentAccount(nAccount: Convert.ToInt32(txtNAccount.Text), customer: c, indexTypeAccount: comboTypeAccount.SelectedIndex, itoken: sb);
                return ca;
            }
           
        }

        //public StringBuilder Itoken()
        //{
        //    var idGuid = Guid.NewGuid();
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(idGuid);
        //    sb.Remove(3, 33);
            
        //    return sb;
        //}
        public void Register(Account c)
        {
            if (l.lstAccount.Count > 0)
            {
                //var itokenOk = l.lstAccount[total-1].Equals(c);
                if (l.lstAccount[total - 1].Equals(c))
                {
                    CreateAccount();
                }
                else
                {
                    l.lstAccount.Add(c);
                    ComboLoad(l);
                    total++;
                    MessageNewCustomer(c, total);
                    frmCustomer.ReceiveListfrm2(l);
                }
            }
            else
            {
                l.lstAccount.Add(c);
                ComboLoad(l);
                total++;
                MessageNewCustomer(c, total);
                frmCustomer.ReceiveListfrm2(l);
            }

        }

        
        public void MessageNewCustomer(Account c, int total)
        {
            MessageBox.Show("Cliente " + c.customer.getName() + ", cadastrado com sucesso !! " + "\nTotal de Clientes Cadastrados " + total + "\nCódigo de acesso: " + c.itoken);
            CleanFrm();
        }

         public void CleanFrm()
        {
            
            txtCPF.Clear();
            txtName.Clear();
            txtNAccount.Clear();
            comboTypeAccount.SelectedIndex = -1;
            comboCustomers.SelectedIndex = -1;
                      
        }

        public void ComboLoad(DataBaseCustomers list)
        {
            comboCustomers.Items.Clear();
            
            foreach (Account item in list.lstAccount)
            {
                comboCustomers.Items.Add("nº " + item.nAccount.ToString() + " " + (item.customer.getName()));
            }
        }

        public void comboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboCustomers.SelectedIndex;
            if (index == -1)
            {
                txtDataCustomers.Text = "";
            }
            else
            {
                txtDataCustomers.Text = "Cliente " + l.lstAccount[index].customer.getName() + " portador do cpf " + l.lstAccount[index].customer.getCpf() + "  titular da conta " + l.lstAccount[index].tAccount() + " de numero " + l.lstAccount[index].nAccount.ToString()+" ,código de identificação padrão: "+l.lstAccount[index].itoken;
            }
            
        }

        public int CheckcFields()
        {
            if(txtName.TextLength==0||txtCPF.TextLength==0||txtNAccount.TextLength==0|| comboTypeAccount.SelectedIndex == -1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void txtDataCustomers_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

