namespace Game_Zotypee_bd
{
    partial class Pcarga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pcarga));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CargaBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Timers.Timer();
            this.trespuntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // CargaBar
            // 
            this.CargaBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CargaBar.Enabled = false;
            this.CargaBar.Location = new System.Drawing.Point(116, 273);
            this.CargaBar.Name = "CargaBar";
            this.CargaBar.Size = new System.Drawing.Size(423, 30);
            this.CargaBar.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // trespuntos
            // 
            this.trespuntos.AutoSize = true;
            this.trespuntos.Enabled = false;
            this.trespuntos.Location = new System.Drawing.Point(317, 316);
            this.trespuntos.Name = "trespuntos";
            this.trespuntos.Size = new System.Drawing.Size(16, 13);
            this.trespuntos.TabIndex = 5;
            this.trespuntos.Text = "...";
            this.trespuntos.Visible = false;
            // 
            // Pcarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 364);
            this.Controls.Add(this.trespuntos);
            this.Controls.Add(this.CargaBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Pcarga";
            this.Text = "Zootype";
            this.Load += new System.EventHandler(this.Pcarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar CargaBar;
        private System.Timers.Timer timer1;
        private System.Windows.Forms.Label trespuntos;
    }
}

