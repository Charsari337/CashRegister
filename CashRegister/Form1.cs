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
using System.Media;


namespace CashRegister
{
    

    public partial class Form1 : Form
    {
        SoundPlayer cashReg = new SoundPlayer(Properties.Resources.cashregRun);
        SoundPlayer cashRegDone = new SoundPlayer(Properties.Resources.cashregDone);

        //Global variable item prices:
        double lanternsPrice = 15.75;
        double ropePrice = 7.37;
        double bombsPrice = 23.06;

        //Global variable item amount:
        double lanterns;
        double rope;
        double bombs;

        //Global item total variables:
        double lanternsTotal;
        double ropeTotal;
        double bombsTotal;

        //Global sub total:
        double subTotal;
        //Global total cost:
        double totalCost;
        //Global tax rate:
        double taxRate = 0.13;
        //Global tax amount:
        double taxAmount;

        //Global tendered and change amounts:
        double tenderedAmount;
        double changeAmount;

        //reference customer number:
        double customerNumber = 247;

        public Form1()
        {
            InitializeComponent();

            //Items are set to 0 desired purchases.
            textBoxBomb.Text = "0";
            textBoxRope.Text = "0";
            textBoxLan.Text = "0";

        }

        private void CalcButt_Click(object sender, EventArgs e)
        {
            //Calculate Totals button:
            try
            {
                
                lanterns = Convert.ToInt16(textBoxLan.Text);
                rope = Convert.ToInt16(textBoxRope.Text);
                bombs = Convert.ToInt16(textBoxBomb.Text);

                subTotal = (lanterns * lanternsPrice) + (rope * ropePrice) + (bombs * bombsPrice);
                taxAmount = taxRate * subTotal;
                totalCost = subTotal + taxAmount;

                totalsLabel.Text = $"\nSub Total   {subTotal.ToString(".00")}";
                totalsLabel.Text += $"\n\nTax         {taxAmount.ToString(".00")}";
                totalsLabel.Text += $"\n\nTotal       {totalCost.ToString(".00")}";

            }
            catch
            {
                totalsLabel.Text = "Please insert desired amount of each item as a number.";
            }

        }

        private void calcChangeButt_Click(object sender, EventArgs e)
        {
            //Calculate Change button:
            try
            {

                tenderedAmount = Convert.ToInt16(textBoxTend.Text);
                changeAmount = tenderedAmount - totalCost;

                changeLabel.Text = $"\nChange: {changeAmount.ToString(".00")}";
                //changeLabel.TextAlign;

            }
            catch
            {
                changeLabel.Text = "Numerial amount only.";
                textBoxTend.Focus();
            }
        }

        private void receiptButt_Click(object sender, EventArgs e)
        {
            //Print Receipt button:
            lanternsTotal = lanternsPrice * lanterns;
            ropeTotal = ropePrice * rope;
            bombsTotal = bombsPrice * bombs;

            customerNumber++;
           
            cashReg.Play();
            
            receiptLabel.Text = "                  Morshu's Shop";
            Refresh();
            Thread.Sleep(200);

            cashReg.Play();

            receiptLabel.Text += $"\n\nCustomer Number {customerNumber}";
            Refresh();
            Thread.Sleep(200);
            receiptLabel.Text += $"\nFebruary 11, 2021";
            Refresh();
            Thread.Sleep(1000);

            cashReg.Play();

            receiptLabel.Text += $"\n\nLanterns:                 {lanterns}     x  @   {lanternsTotal.ToString("$.00")}";
            Refresh();
            Thread.Sleep(200);
            receiptLabel.Text += $"\nRope:                     {rope}     x  @   {ropeTotal.ToString("$.00")}";
            Refresh();
            Thread.Sleep(200);
            receiptLabel.Text += $"\nBombs:                    {bombs}     x  @   {bombsTotal.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);

            cashReg.Play();

            receiptLabel.Text += $"\n\nSub Total:                             {subTotal.ToString("$.00")}";
            Refresh();
            Thread.Sleep(200);
            receiptLabel.Text += $"\nTax:                                   {taxAmount.ToString("$.00")}";
            Refresh();
            Thread.Sleep(200);
            receiptLabel.Text += $"\nTotal:                                 {totalCost.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);

            cashReg.Play();

            receiptLabel.Text += $"\n\nTendered:                              {tenderedAmount.ToString("$.00")}";
            Refresh();
            Thread.Sleep(200);
            receiptLabel.Text += $"\nChange:                                {changeAmount.ToString("$.00")}";
            Refresh();
            Thread.Sleep(1000);

            cashRegDone.Play();

            receiptLabel.Text += $"\n\nCome back to Morshu with more Rubies to spend!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //New Order button to reset all boxes:
            textBoxLan.Text = "0";
            textBoxRope.Text = "0";
            textBoxBomb.Text = "0";

            totalsLabel.Text = " ";

            textBoxTend.Text = " ";

            changeLabel.Text = " ";

            receiptLabel.Text = " ";

        }

        //When item boxes are selected all text is highlighted. Allows for a faster and easier way to type values in.
        private void textBoxRope_Click(object sender, EventArgs e)
        {
            textBoxRope.SelectAll();
        }

        private void textBoxLan_Click(object sender, EventArgs e)
        {
            textBoxLan.SelectAll();
        }

        private void textBoxBomb_Click(object sender, EventArgs e)
        {
            textBoxBomb.SelectAll();
        }

        private void textBoxTend_Click(object sender, EventArgs e)
        {
            textBoxTend.SelectAll();
        }

    
    }
}
