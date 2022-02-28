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

        double orderNumber = 1; 

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
               

                totalBurgers = payBurgers * nomBurgers;

                totalFries = nomFries * payFries;

                totalDrink = nomDrinks * payDrinks;

                subTotal = totalBurgers + totalFries + totalDrink;

                taxD = subTotal * tax;

                total = subTotal * tax1;

               


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
            receiptOutput.TextAlign = ContentAlignment.TopLeft;
            receiptOutput.Text = $"          Burger Town Pub";
            receiptOutput.Text += $"\nOrder Number {orderNumber}";

            receiptOutput.Text += $"\nBurgers   x{nomBurgers} @ {payBurgers.ToString("C")}";
            receiptOutput.Text += $"\nFries     x{nomFries} @ {payFries.ToString("C")}";
            receiptOutput.Text += $"\nDrinks    x{nomDrinks} @ {payDrinks.ToString("C")}";
            receiptOutput.Text += $"\n\nSub Total   = {subTotal.ToString("C")}";
            receiptOutput.Text += $"\nTax          = {taxD.ToString("C")}";
            receiptOutput.Text += $"\nTotal        = {total.ToString("C")}";





        }

        private void button1_Click(object sender, EventArgs e)
        {
            tendered = Convert.ToDouble(tenderedInput.Text);
            changeTotal = tendered - total;
            changeLabel.Text = $"{changeTotal.ToString("C")}";

            
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            changeLabel.Text = $""; 
            receiptOutput.Text = $"";
            subInput.Text = $"";
            taxInput.Text = $"";
            totalInput.Text = $"";
            burgesInput.Text = $"0";
            drinksInput.Text = $"0";
            friesInput.Text = $"0";
            tenderedInput.Text = $"0";
            orderNumber = orderNumber + 1;
            totalBurgers = 0;
            totalFries = 0;
            totalDrink = 0;
            nomBurgers = 0;
            nomFries = 0;
            nomDrinks = 0; 
            tendered = 0;
            total = 0;
            taxD = 0;
            subTotal = 0;
            changeTotal = 0;


        }
    }
}
