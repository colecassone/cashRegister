using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

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
        double taxTotal = 0;
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
               //  SoundPlayer totalSound = new SoundPlayer(Properties.Resources.totalSound);
               // totalSound.Play(); 

                //get inputs for order
                nomBurgers = Convert.ToDouble(burgesInput.Text);
                nomFries = Convert.ToDouble(friesInput.Text);
                nomDrinks = Convert.ToDouble(drinksInput.Text);
               

                totalBurgers = payBurgers * nomBurgers;

                totalFries = nomFries * payFries;

                totalDrink = nomDrinks * payDrinks;

                subTotal = totalBurgers + totalFries + totalDrink;

                taxTotal = subTotal * tax;

                total = subTotal + taxTotal;

               


                subInput.Text = $"{subTotal.ToString("C")}";
                taxInput.Text = $"{taxTotal.ToString("C")}";
                totalInput.Text = $"{total.ToString("C")}";

                changeButton.Enabled = true;

            }
            catch
            {
                
                
                
                receiptOutput.Text = $"you dummy"; 

            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
           SoundPlayer cashSound = new SoundPlayer(Properties.Resources.cashSound);
            cashSound.Play(); 
            receiptOutput.TextAlign = ContentAlignment.TopLeft;

            receiptOutput.Text = $"      Burger Town Pub";
            receiptOutput.Refresh();
            Thread.Sleep(250);

            receiptOutput.Text += $"\nOrder Number {orderNumber}";
            receiptOutput.Refresh();
            Thread.Sleep(250);


            receiptOutput.Text += $"\nBurgers   x{nomBurgers} @ {payBurgers.ToString("C")}";
             
            receiptOutput.Text += $"\nFries     x{nomFries} @ {payFries.ToString("C")}";
            receiptOutput.Text += $"\nDrinks    x{nomDrinks} @ {payDrinks.ToString("C")}";
            receiptOutput.Text += $"\n\nSub Total    = {subTotal.ToString("C")}";
            receiptOutput.Text += $"\nTax          = {taxTotal.ToString("C")}";
            receiptOutput.Text += $"\nTotal        = {total.ToString("C")}";
            receiptOutput.Text += $"\n\nTendered     = {tendered.ToString("C")}";
            receiptOutput.Text += $"\nTotal Change = {changeTotal.ToString("C")}";
            receiptOutput.Text += $"\n\nNO RETURN POLICY";
            receiptOutput.Text += $"\nYOU MUST HAVE A GREAT DAY :|";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer changeSound = new SoundPlayer(Properties.Resources.changeSound);
            changeSound.Play();

            try
            { 
                tendered = Convert.ToDouble(tenderedInput.Text);
                changeTotal = tendered - total;
                changeLabel.Text = $"{changeTotal.ToString("C")}";
            }
            catch
            {
                receiptOutput.Text = $"you dummy";
            }
            
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            SoundPlayer newButtonSound = new SoundPlayer(Properties.Resources.newButtonSound); 
            newButtonSound.Play();
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
            taxTotal = 0;
            subTotal = 0;
            changeTotal = 0;


        }
    }
}
