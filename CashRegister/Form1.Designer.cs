
namespace CashRegister
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLan = new System.Windows.Forms.TextBox();
            this.textBoxRope = new System.Windows.Forms.TextBox();
            this.textBoxBomb = new System.Windows.Forms.TextBox();
            this.totalsLabel = new System.Windows.Forms.Label();
            this.CalcButt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTend = new System.Windows.Forms.TextBox();
            this.calcChangeButt = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButt = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Morshu\'s Shop";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lanterns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rope";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bombs";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLan
            // 
            this.textBoxLan.Location = new System.Drawing.Point(147, 54);
            this.textBoxLan.Name = "textBoxLan";
            this.textBoxLan.Size = new System.Drawing.Size(40, 20);
            this.textBoxLan.TabIndex = 4;
            this.textBoxLan.Text = "0";
            this.textBoxLan.Click += new System.EventHandler(this.textBoxLan_Click);
            // 
            // textBoxRope
            // 
            this.textBoxRope.Location = new System.Drawing.Point(147, 80);
            this.textBoxRope.Name = "textBoxRope";
            this.textBoxRope.Size = new System.Drawing.Size(40, 20);
            this.textBoxRope.TabIndex = 5;
            this.textBoxRope.Text = "0";
            this.textBoxRope.Click += new System.EventHandler(this.textBoxRope_Click);
            // 
            // textBoxBomb
            // 
            this.textBoxBomb.Location = new System.Drawing.Point(147, 106);
            this.textBoxBomb.Name = "textBoxBomb";
            this.textBoxBomb.Size = new System.Drawing.Size(40, 20);
            this.textBoxBomb.TabIndex = 6;
            this.textBoxBomb.Text = "0";
            this.textBoxBomb.Click += new System.EventHandler(this.textBoxBomb_Click);
            // 
            // totalsLabel
            // 
            this.totalsLabel.BackColor = System.Drawing.Color.Linen;
            this.totalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalsLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsLabel.Location = new System.Drawing.Point(12, 177);
            this.totalsLabel.Name = "totalsLabel";
            this.totalsLabel.Size = new System.Drawing.Size(185, 116);
            this.totalsLabel.TabIndex = 7;
            // 
            // CalcButt
            // 
            this.CalcButt.BackColor = System.Drawing.Color.Sienna;
            this.CalcButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalcButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcButt.Location = new System.Drawing.Point(29, 145);
            this.CalcButt.Name = "CalcButt";
            this.CalcButt.Size = new System.Drawing.Size(146, 22);
            this.CalcButt.TabIndex = 8;
            this.CalcButt.Text = "Calculate Totals";
            this.CalcButt.UseVisualStyleBackColor = false;
            this.CalcButt.Click += new System.EventHandler(this.CalcButt_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tendered:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTend
            // 
            this.textBoxTend.Location = new System.Drawing.Point(100, 309);
            this.textBoxTend.Name = "textBoxTend";
            this.textBoxTend.Size = new System.Drawing.Size(87, 20);
            this.textBoxTend.TabIndex = 11;
            this.textBoxTend.Click += new System.EventHandler(this.textBoxTend_Click);
            // 
            // calcChangeButt
            // 
            this.calcChangeButt.BackColor = System.Drawing.Color.Sienna;
            this.calcChangeButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcChangeButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcChangeButt.Location = new System.Drawing.Point(29, 356);
            this.calcChangeButt.Name = "calcChangeButt";
            this.calcChangeButt.Size = new System.Drawing.Size(146, 25);
            this.calcChangeButt.TabIndex = 12;
            this.calcChangeButt.Text = "Calculate Change";
            this.calcChangeButt.UseVisualStyleBackColor = false;
            this.calcChangeButt.Click += new System.EventHandler(this.calcChangeButt_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Linen;
            this.changeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 393);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(184, 38);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "Change:";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receiptButt
            // 
            this.receiptButt.BackColor = System.Drawing.Color.Sienna;
            this.receiptButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButt.Location = new System.Drawing.Point(29, 444);
            this.receiptButt.Name = "receiptButt";
            this.receiptButt.Size = new System.Drawing.Size(146, 25);
            this.receiptButt.TabIndex = 14;
            this.receiptButt.Text = "Print Receipt";
            this.receiptButt.UseVisualStyleBackColor = false;
            this.receiptButt.Click += new System.EventHandler(this.receiptButt_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.Linen;
            this.receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiptLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptLabel.Location = new System.Drawing.Point(228, 49);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(444, 357);
            this.receiptLabel.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(350, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "New Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButt);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.calcChangeButt);
            this.Controls.Add(this.textBoxTend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CalcButt);
            this.Controls.Add(this.totalsLabel);
            this.Controls.Add(this.textBoxBomb);
            this.Controls.Add(this.textBoxRope);
            this.Controls.Add(this.textBoxLan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLan;
        private System.Windows.Forms.TextBox textBoxRope;
        private System.Windows.Forms.TextBox textBoxBomb;
        private System.Windows.Forms.Label totalsLabel;
        private System.Windows.Forms.Button CalcButt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTend;
        private System.Windows.Forms.Button calcChangeButt;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButt;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button button1;
    }
}

