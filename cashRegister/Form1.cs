using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class Form1 : Form
    {

        double totalBurgers = 0;
        double totalFries = 0;
        double totalDrink = 0;




        double nomBurgers = 0;
        double nomFries = 0;
        double nomDrinks = 0;




        double payBurgers = 4;
        double payFries = 3;
        double payDrinks = 1.50;




        double tendered = 0;

        double tax = .13;

        double tax1 = 1.13;

        double taxD = 0;

        double total = 0;

        double changeTotal = 0;

        double subTotal = 0; 

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                nomBurgers = Convert.ToDouble(burgesInput.Text);
                nomFries = Convert.ToDouble(friesInput.Text);
                nomDrinks = Convert.ToDouble(drinksInput.Text);
                tendered = Convert.ToDouble(tenderedInput.Text);

                totalBurgers = payBurgers * nomBurgers;

                totalFries = nomFries * payFries;

                totalDrink = nomDrinks * payDrinks;

                subTotal = totalBurgers + totalFries + totalDrink;

                taxD = subTotal * tax;

                total = subTotal * tax1;

                changeTotal = tendered - total;


                subInput.Text = $"{subTotal.ToString("C")}";

                taxInput.Text = $"{taxD.ToString("C")}";

                totalInput.Text = $"{total.ToString("C")}";



            }
            catch
            {
                receiptOutput.Text = $"you dummy"; 

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeLabel.Text = $"{changeTotal.ToString("C")}";
        }
    }
}
