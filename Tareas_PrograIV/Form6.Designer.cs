
namespace Tareas_PrograIV
{
    partial class Form6
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
            this.Home = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textvalue1 = new System.Windows.Forms.TextBox();
            this.Covert_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(12, 455);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 35);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Grados Fahrenheit";
            // 
            // textvalue1
            // 
            this.textvalue1.Location = new System.Drawing.Point(283, 104);
            this.textvalue1.Name = "textvalue1";
            this.textvalue1.Size = new System.Drawing.Size(109, 22);
            this.textvalue1.TabIndex = 11;
            this.textvalue1.Text = "0";
            // 
            // Covert_button
            // 
            this.Covert_button.Location = new System.Drawing.Point(140, 256);
            this.Covert_button.Name = "Covert_button";
            this.Covert_button.Size = new System.Drawing.Size(193, 30);
            this.Covert_button.TabIndex = 13;
            this.Covert_button.Text = "Convertir";
            this.Covert_button.UseVisualStyleBackColor = true;
            this.Covert_button.Click += new System.EventHandler(this.Covert_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Grados Celsius";
            // 
            // Resultlabel
            // 
            this.Resultlabel.AutoSize = true;
            this.Resultlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Resultlabel.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultlabel.Location = new System.Drawing.Point(279, 192);
            this.Resultlabel.Name = "Resultlabel";
            this.Resultlabel.Size = new System.Drawing.Size(56, 27);
            this.Resultlabel.TabIndex = 16;
            this.Resultlabel.Text = "    C";
            this.Resultlabel.Click += new System.EventHandler(this.Resultlabel_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(567, 502);
            this.Controls.Add(this.Resultlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Covert_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvalue1);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textvalue1;
        private System.Windows.Forms.Button Covert_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resultlabel;
    }
}