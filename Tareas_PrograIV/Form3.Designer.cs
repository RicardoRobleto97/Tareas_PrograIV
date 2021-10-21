
namespace Tareas_PrograIV
{
    partial class Form3
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textvalue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textvalue1 = new System.Windows.Forms.TextBox();
            this.Promedio_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(19, 458);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(104, 35);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(254, 261);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 29);
            this.ResultLabel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Calificacion2";
            // 
            // textvalue2
            // 
            this.textvalue2.Location = new System.Drawing.Point(341, 162);
            this.textvalue2.Name = "textvalue2";
            this.textvalue2.Size = new System.Drawing.Size(109, 22);
            this.textvalue2.TabIndex = 11;
            this.textvalue2.Text = "44";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calificacion1";
            // 
            // textvalue1
            // 
            this.textvalue1.Location = new System.Drawing.Point(341, 75);
            this.textvalue1.Name = "textvalue1";
            this.textvalue1.Size = new System.Drawing.Size(109, 22);
            this.textvalue1.TabIndex = 9;
            this.textvalue1.Text = "51";
            // 
            // Promedio_button
            // 
            this.Promedio_button.Location = new System.Drawing.Point(248, 334);
            this.Promedio_button.Name = "Promedio_button";
            this.Promedio_button.Size = new System.Drawing.Size(192, 48);
            this.Promedio_button.TabIndex = 8;
            this.Promedio_button.Text = "Calcular";
            this.Promedio_button.UseVisualStyleBackColor = true;
            this.Promedio_button.Click += new System.EventHandler(this.Promedio_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultado: ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 497);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textvalue2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textvalue1);
            this.Controls.Add(this.Promedio_button);
            this.Controls.Add(this.Home);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textvalue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textvalue1;
        private System.Windows.Forms.Button Promedio_button;
        private System.Windows.Forms.Label label3;
    }
}