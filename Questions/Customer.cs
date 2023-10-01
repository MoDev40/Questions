using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerIssue issue = new CustomerIssue(tbxName.Text,tbxId.Text,tbxIssue.Text);
            lblName.Text = issue.CustName;
            lblId.Text = issue.CustId;
            lblIssue.Text = issue.CustIssue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
