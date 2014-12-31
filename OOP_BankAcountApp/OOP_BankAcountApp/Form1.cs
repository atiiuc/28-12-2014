using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_BankAcountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Account anAccount;
        private Customer aCustomer;
        private void SaveButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account();
            anAccount.Number = accountInputText.Text;
            anAccount.OpeningDate = dateInputText.Text;

            aCustomer = new Customer();
            aCustomer.Name = nameInputText.Text;
            aCustomer.Email = emailInputText.Text;

            aCustomer.CustomerAccount = anAccount;


        }

        private void DepositButton_Click(object sender, EventArgs e)
        {

            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountInputText.Text);
                aCustomer.CustomerAccount.Deposit(amount);
                MessageBox.Show("Deposited");
            }
            else
            {
                MessageBox.Show("Create Account First");
            }

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (aCustomer != null)
            {
                double amount = Convert.ToDouble(amountInputText.Text);
                aCustomer.CustomerAccount.Withdraw(amount);
                MessageBox.Show("Withdrawed");
            }
            else
            {
                MessageBox.Show("Create Account First");
            }


        }

        private void ShowButton_Click(object sender, EventArgs e)
        {


           nameOutputText.Text = aCustomer.Name;
            emailOutputText.Text = aCustomer.Email;
            accountOutputText.Text = aCustomer.CustomerAccount.Number;
            dateOutputText.Text = aCustomer.CustomerAccount.OpeningDate;
            balanceText.Text = aCustomer.CustomerAccount.Balance.ToString();


        }

    }
}
