namespace Snake
{
    partial class PantallaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.AreaDeJuego = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPuntos = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AreaDeJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // AreaDeJuego
            // 
            this.AreaDeJuego.Location = new System.Drawing.Point(12, 12);
            this.AreaDeJuego.Name = "AreaDeJuego";
            this.AreaDeJuego.Size = new System.Drawing.Size(780, 390);
            this.AreaDeJuego.TabIndex = 0;
            this.AreaDeJuego.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de puntos:";
            // 
            // TxtPuntos
            // 
            this.TxtPuntos.AutoSize = true;
            this.TxtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntos.Location = new System.Drawing.Point(269, 420);
            this.TxtPuntos.Name = "TxtPuntos";
            this.TxtPuntos.Size = new System.Drawing.Size(36, 39);
            this.TxtPuntos.TabIndex = 2;
            this.TxtPuntos.Text = "0";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 474);
            this.Controls.Add(this.TxtPuntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreaDeJuego);
            this.Name = "PantallaPrincipal";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PantallaPrincipal_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AreaDeJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AreaDeJuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtPuntos;
        private System.Windows.Forms.Timer bucle;
    }
}

