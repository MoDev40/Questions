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
    public partial class QuesFive : Form
    {
        public QuesFive()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            //Array length 3 
            RetailItems[] allItems = {new RetailItems("T-shirt","Size 2xl",23,12),new RetailItems("Jeans", "Size 32", 20, 7) , new RetailItems("Shoes", "Size 8", 3, 18) };
            //test

            for(int i = 0; i< allItems.Length; i++)
            {
                lblItems.Text += $"Name {allItems[i].ItemName} \t Description\t {allItems[i].Desription} \t\tPrice: ${allItems[i].Price} \n\n";
            }
        }
    }
}
