﻿namespace Beta
{
    partial class Pagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new Beta.Controles.TextBox();
            this.textBox2 = new Beta.Controles.TextBox();
            this.boton1 = new Beta.Controles.Boton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox1.BorderRadius = 10;
            this.textBox1.BorderSize = 2;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(137, 136);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox1.PasswordChar = false;
            this.textBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox1.PlaceholderText = "";
            this.textBox1.Size = new System.Drawing.Size(250, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Texts = "";
            this.textBox1.UnderlinedStyle = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox2.BorderRadius = 0;
            this.textBox2.BorderSize = 2;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Location = new System.Drawing.Point(524, 35);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox2.PasswordChar = false;
            this.textBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox2.PlaceholderText = "";
            this.textBox2.Size = new System.Drawing.Size(250, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.Texts = "";
            this.textBox2.UnderlinedStyle = false;
            // 
            // boton1
            // 
            this.boton1.BackColor = System.Drawing.Color.Blue;
            this.boton1.BackgroundColor = System.Drawing.Color.Blue;
            this.boton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.boton1.BorderRadius = 20;
            this.boton1.BorderSize = 1;
            this.boton1.FlatAppearance.BorderSize = 0;
            this.boton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.boton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.boton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boton1.ForeColor = System.Drawing.Color.White;
            this.boton1.Location = new System.Drawing.Point(352, 83);
            this.boton1.Name = "boton1";
            this.boton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boton1.Size = new System.Drawing.Size(150, 40);
            this.boton1.TabIndex = 3;
            this.boton1.Text = "boton1";
            this.boton1.TextColor = System.Drawing.Color.White;
            this.boton1.UseVisualStyleBackColor = false;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 463);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controles.TextBox textBox1;
        private Controles.TextBox textBox2;
        private Controles.Boton boton1;
    }
}