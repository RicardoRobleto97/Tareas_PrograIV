
namespace Tarea_3
{
    partial class Volumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volumen));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Volume_Down = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.Mayor_Valor = new System.Windows.Forms.TextBox();
            this.Menor_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(47, 358);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBar1.Size = new System.Drawing.Size(394, 31);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pantalla de Amplificador";
            // 
            // Volume_Down
            // 
            this.Volume_Down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Volume_Down.BackgroundImage")));
            this.Volume_Down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Volume_Down.Location = new System.Drawing.Point(47, 201);
            this.Volume_Down.Name = "Volume_Down";
            this.Volume_Down.Size = new System.Drawing.Size(73, 60);
            this.Volume_Down.TabIndex = 2;
            this.Volume_Down.UseVisualStyleBackColor = true;
            this.Volume_Down.Click += new System.EventHandler(this.Volume_Down_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(59, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 63);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(535, 426);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(89, 57);
            this.Home.TabIndex = 4;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Mayor_Valor
            // 
            this.Mayor_Valor.Location = new System.Drawing.Point(293, 137);
            this.Mayor_Valor.Name = "Mayor_Valor";
            this.Mayor_Valor.Size = new System.Drawing.Size(162, 22);
            this.Mayor_Valor.TabIndex = 5;
            // 
            // Menor_Valor
            // 
            this.Menor_Valor.Location = new System.Drawing.Point(293, 239);
            this.Menor_Valor.Name = "Menor_Valor";
            this.Menor_Valor.Size = new System.Drawing.Size(162, 22);
            this.Menor_Valor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mayor Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Menor Valor";
            // 
            // Volumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Menor_Valor);
            this.Controls.Add(this.Mayor_Valor);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Volume_Down);
            this.Controls.Add(this.label1);
            this.Name = "Volumen";
            this.Text = "Puntaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Volume_Down;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.TextBox Mayor_Valor;
        private System.Windows.Forms.TextBox Menor_Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ProgressBar progressBar1;
    }
}