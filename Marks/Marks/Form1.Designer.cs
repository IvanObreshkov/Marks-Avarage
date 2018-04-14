namespace Marks
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ti2 = new System.Windows.Forms.Label();
            this.ti3 = new System.Windows.Forms.Label();
            this.ti4 = new System.Windows.Forms.Label();
            this.pate = new System.Windows.Forms.Label();
            this.ti6 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Изчисли";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Брой двойки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Брой тройки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Брой четворки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Брой петици";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Брой шестици";
            // 
            // ti2
            // 
            this.ti2.AutoSize = true;
            this.ti2.Location = new System.Drawing.Point(184, 80);
            this.ti2.Name = "ti2";
            this.ti2.Size = new System.Drawing.Size(0, 13);
            this.ti2.TabIndex = 6;
            // 
            // ti3
            // 
            this.ti3.AutoSize = true;
            this.ti3.Location = new System.Drawing.Point(187, 107);
            this.ti3.Name = "ti3";
            this.ti3.Size = new System.Drawing.Size(0, 13);
            this.ti3.TabIndex = 7;
            // 
            // ti4
            // 
            this.ti4.AutoSize = true;
            this.ti4.Location = new System.Drawing.Point(187, 133);
            this.ti4.Name = "ti4";
            this.ti4.Size = new System.Drawing.Size(0, 13);
            this.ti4.TabIndex = 8;
            // 
            // pate
            // 
            this.pate.AutoSize = true;
            this.pate.Location = new System.Drawing.Point(184, 158);
            this.pate.Name = "pate";
            this.pate.Size = new System.Drawing.Size(0, 13);
            this.pate.TabIndex = 9;
            // 
            // ti6
            // 
            this.ti6.AutoSize = true;
            this.ti6.Location = new System.Drawing.Point(184, 183);
            this.ti6.Name = "ti6";
            this.ti6.Size = new System.Drawing.Size(0, 13);
            this.ti6.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Среден успех";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(151, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ti6);
            this.Controls.Add(this.pate);
            this.Controls.Add(this.ti4);
            this.Controls.Add(this.ti3);
            this.Controls.Add(this.ti2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ti2;
        private System.Windows.Forms.Label ti3;
        private System.Windows.Forms.Label ti4;
        private System.Windows.Forms.Label pate;
        private System.Windows.Forms.Label ti6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

