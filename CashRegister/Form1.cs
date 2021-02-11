using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CashRegister
{
    

    public partial class Form1 : Form
    {
        double lanternsPrice = 15.75;
        double ropePrice = 7.37;
        double bombsPrice = 23.06;

        double lanterns;
        double rope;
        double bombs;

        double lanternsTotal;
        double ropeTotal;
        double bombsTotal;

        double subTotal;
        double totalCost;
        double taxRate = 0.13;
        double taxAmount;
        double costwithTax;

        double tenderedAmount;
        double changeAmount;

        public Form1()
        {
            InitializeComponent();

            textBoxBomb.Text = "0";
            textBoxRope.Text = "0";
            textBoxLan.Text = "0";

        }

        private void CalcButt_Click(object sender, EventArgs e)
        {
            try
            {

                lanterns = Convert.ToInt16(textBoxLan.Text);
                rope = Convert.ToInt16(textBoxRope.Text);
                bombs = Convert.ToInt16(textBoxBomb.Text);

                subTotal = (lanterns * lanternsPrice) + (rope * ropePrice) + (bombs * bombsPrice);
                taxAmount = taxRate * subTotal;
                totalCost = subTotal + taxAmount;

                totalsLabel.Text = $"\nSub Total..............       {subTotal.ToString(".00")}";
                totalsLabel.Text += $"\n\nTax...........................       {taxAmount.ToString(".00")}";
                totalsLabel.Text += $"\n\nTotal.......................       {totalCost.ToString(".00")}";

            }
            catch
            {
                totalsLabel.Text = "Please insert desired amount of each item as a number.";
            }

        }

        private void calcChangeButt_Click(object sender, EventArgs e)
        {
            try
            {

                tenderedAmount = Convert.ToInt16(textBoxTend.Text);
                changeAmount = tenderedAmount - totalCost;

                changeLabel.Text = $"\nChange: {changeAmount.ToString(".00")}";

            }
            catch
            {
                changeLabel.Text = "Numerial amount only.";
                textBoxTend.Focus();
            }
        }

        private void receiptButt_Click(object sender, EventArgs e)
        {
            lanternsTotal = lanternsPrice * lanterns;
            ropeTotal = ropePrice * rope;
            bombsTotal = bombsPrice * bombs;

            receiptLabel.Text = "                                        Morshu's Shop";
            Refresh();
            Thread.Sleep(100);

            receiptLabel.Text += $"\n\nCustomer Number 247";
            receiptLabel.Text += $"\nFebruary 11, 2021";
            receiptLabel.Text += $"\n\nLanterns:                    {lanterns}     x     @      {lanternsTotal.ToString("$.00")}";
            receiptLabel.Text += $"\nRope:                          {rope}     x     @      {ropeTotal.ToString("$.00")}";
            receiptLabel.Text += $"\nBombs:                       {bombs}     x     @      {bombsTotal.ToString("$.00")}";
            receiptLabel.Text += $"\n\nSub Total:                 {subTotal.ToString("$.00")}";
            receiptLabel.Text += $"\nTax:                            {taxAmount.ToString("$.00")}";
            receiptLabel.Text += $"\nTotal:                         {totalCost.ToString("$.00")}";

            receiptLabel.Text += $"\n\nTendered:                  {tenderedAmount.ToString("$.00")}";
            receiptLabel.Text += $"\nChange:                     {changeAmount.ToString("$.00")}";

            receiptLabel.Text += $"\n\nCome back to Morshu with more Rubies to spend!";
        }

    
    }
}
