﻿namespace Exercicio1
{
    partial class Exer18
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 39);
            this.label5.TabIndex = 29;
            this.label5.Text = "Salário LIquido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "Digite o salário Bruto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(533, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(397, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 40);
            this.label2.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 61);
            this.button2.TabIndex = 23;
            this.button2.Text = "Processar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 39);
            this.label1.TabIndex = 22;
            this.label1.Text = "Calculadora Salário líquido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 63);
            this.button1.TabIndex = 43;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 65);
            this.button3.TabIndex = 44;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Exer18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Exer18";
            this.Text = "Exer18";
            this.Load += new System.EventHandler(this.Exer18_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}