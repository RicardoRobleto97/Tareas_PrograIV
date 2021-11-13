
namespace Tarea_4
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
            this.Importar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.ofdLeer = new System.Windows.Forms.OpenFileDialog();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Importar
            // 
            this.Importar.Location = new System.Drawing.Point(61, 99);
            this.Importar.Name = "Importar";
            this.Importar.Size = new System.Drawing.Size(195, 42);
            this.Importar.TabIndex = 19;
            this.Importar.Text = "Importar Archivo";
            this.Importar.UseVisualStyleBackColor = true;
            this.Importar.Click += new System.EventHandler(this.Importar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(61, 202);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(207, 22);
            this.txtResult.TabIndex = 21;
            // 
            // ofdLeer
            // 
            this.ofdLeer.FileName = "ofdLeer";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(15, 311);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(87, 24);
            this.back.TabIndex = 22;
            this.back.Text = "Main Menu";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 347);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Importar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Importar;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.OpenFileDialog ofdLeer;
        private System.Windows.Forms.Button back;
    }
}

