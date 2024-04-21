namespace Genetik_Algoritma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 116);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(126, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 178);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(126, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(86, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(126, 27);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(86, 296);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(126, 27);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(86, 361);
            button1.Name = "button1";
            button1.Size = new Size(174, 83);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 30);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 6;
            label1.Text = "Popülasyon boyutu ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 93);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 7;
            label2.Text = "Çaprazlama Boyutu ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 155);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 8;
            label3.Text = "Mutasyon Oranı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 215);
            label4.Name = "label4";
            label4.Size = new Size(122, 20);
            label4.TabIndex = 9;
            label4.Text = "Jenerasyon Sayısı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 273);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 10;
            label5.Text = "Seçilim Oranı";
            // 
            // plotView1
            // 
            plotView1.BackColor = SystemColors.ActiveCaption;
            plotView1.Location = new Point(454, 53);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(409, 212);
            plotView1.TabIndex = 11;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 296);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 12;
            label6.Text = "En iyi Çözüm Değerleri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 424);
            label7.Name = "label7";
            label7.Size = new Size(163, 20);
            label7.TabIndex = 13;
            label7.Text = "Amaç fonksiyon Değeri";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(566, 296);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(297, 43);
            textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(566, 361);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(297, 43);
            textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(566, 424);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(297, 43);
            textBox8.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 518);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(plotView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
