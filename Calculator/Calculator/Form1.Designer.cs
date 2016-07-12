namespace Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.ln = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(103, 20);
            this.textBox2.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(23, 80);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(49, 23);
            this.add.TabIndex = 2;
            this.add.Text = "+\r\n";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.buttonClick);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(104, 80);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(48, 23);
            this.minus.TabIndex = 3;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.buttonClick);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(24, 132);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(48, 23);
            this.multiply.TabIndex = 4;
            this.multiply.Text = "*\r\n";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.buttonClick);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(104, 132);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(48, 23);
            this.division.TabIndex = 5;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.buttonClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(356, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 20);
            this.textBox3.TabIndex = 6;
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(106, 187);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(46, 23);
            this.sin.TabIndex = 7;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(26, 187);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(46, 23);
            this.cos.TabIndex = 8;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // ctg
            // 
            this.ctg.Location = new System.Drawing.Point(193, 80);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(48, 23);
            this.ctg.TabIndex = 9;
            this.ctg.Text = "ctg";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // tg
            // 
            this.tg.Location = new System.Drawing.Point(193, 132);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(49, 21);
            this.tg.TabIndex = 10;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(301, 80);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(46, 23);
            this.log.TabIndex = 11;
            this.log.Text = "log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(193, 187);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(46, 23);
            this.ln.TabIndex = 12;
            this.ln.Text = "ln";
            this.ln.UseVisualStyleBackColor = true;
            this.ln.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(301, 187);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(46, 23);
            this.sqrt.TabIndex = 13;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.OneButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.log);
            this.Controls.Add(this.tg);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button ln;
        private System.Windows.Forms.Button sqrt;
    }
}

