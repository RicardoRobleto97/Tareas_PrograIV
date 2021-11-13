
namespace Tarea_4
{
    partial class Form2
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
            this.Importar = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.txtUp1 = new System.Windows.Forms.TextBox();
            this.txtUp2 = new System.Windows.Forms.TextBox();
            this.ofdLeer = new System.Windows.Forms.OpenFileDialog();
            this.ofdLeer2 = new System.Windows.Forms.OpenFileDialog();
            this.Upload_2 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Importar
            // 
            this.Importar.Location = new System.Drawing.Point(110, 203);
            this.Importar.Name = "Importar";
            this.Importar.Size = new System.Drawing.Size(114, 42);
            this.Importar.TabIndex = 19;
            this.Importar.Text = "Comparar";
            this.Importar.UseVisualStyleBackColor = true;
            this.Importar.Click += new System.EventHandler(this.Importar_Click);
            // 
            // Upload
            // 
            this.Upload.Location = new System.Drawing.Point(413, 42);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(178, 32);
            this.Upload.TabIndex = 22;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = true;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // txtUp1
            // 
            this.txtUp1.Location = new System.Drawing.Point(47, 47);
            this.txtUp1.Name = "txtUp1";
            this.txtUp1.Size = new System.Drawing.Size(330, 22);
            this.txtUp1.TabIndex = 23;
            // 
            // txtUp2
            // 
            this.txtUp2.Location = new System.Drawing.Point(47, 97);
            this.txtUp2.Name = "txtUp2";
            this.txtUp2.Size = new System.Drawing.Size(330, 22);
            this.txtUp2.TabIndex = 24;
            // 
            // ofdLeer
            // 
            this.ofdLeer.FileName = "ofdLeer";
            // 
            // ofdLeer2
            // 
            this.ofdLeer2.FileName = "ofdLeer2";
            // 
            // Upload_2
            // 
            this.Upload_2.Location = new System.Drawing.Point(413, 92);
            this.Upload_2.Name = "Upload_2";
            this.Upload_2.Size = new System.Drawing.Size(178, 32);
            this.Upload_2.TabIndex = 25;
            this.Upload_2.Text = "Upload";
            this.Upload_2.UseVisualStyleBackColor = true;
            this.Upload_2.Click += new System.EventHandler(this.Upload_2_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 310);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(104, 33);
            this.back.TabIndex = 26;
            this.back.Text = "Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 355);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Upload_2);
            this.Controls.Add(this.txtUp2);
            this.Controls.Add(this.txtUp1);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Importar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Importar;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.TextBox txtUp1;
        private System.Windows.Forms.TextBox txtUp2;
        private System.Windows.Forms.OpenFileDialog ofdLeer;
        private System.Windows.Forms.OpenFileDialog ofdLeer2;
        private System.Windows.Forms.Button Upload_2;
        private System.Windows.Forms.Button back;
    }
}