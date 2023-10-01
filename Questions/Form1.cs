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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            PersonalInfo person = new PersonalInfo("Diini", "Hodan", "252612234568", 12);

            lblName.Text = person.Name;
            lblAddress.Text = person.Address;
            lblPhone.Text = person.PhoneNumber;
            lblAge.Text = person.Age.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            QuesFive ques = new QuesFive();
            ques.ShowDialog();
        }
    }
}
