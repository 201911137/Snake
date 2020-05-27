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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.AreaDeJuego = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPuntos = new System.Windows.Forms.Label();
            this.bucle = new System.Windows.Forms.Timer(this.components);
            this.PbrPuntosLogro = new System.Windows.Forms.ProgressBar();
            this.LblLogrosAlcanzados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblProximoLogro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de puntos:";
            // 
            // TxtPuntos
            // 
            this.TxtPuntos.AutoSize = true;
            this.TxtPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPuntos.Location = new System.Drawing.Point(212, 410);
            this.TxtPuntos.Name = "TxtPuntos";
            this.TxtPuntos.Size = new System.Drawing.Size(24, 25);
            this.TxtPuntos.TabIndex = 2;
            this.TxtPuntos.Text = "0";
            // 
            // bucle
            // 
            this.bucle.Enabled = true;
            this.bucle.Tick += new System.EventHandler(this.bucle_Tick);
            // 
            // PbrPuntosLogro
            // 
            this.PbrPuntosLogro.Location = new System.Drawing.Point(406, 439);
            this.PbrPuntosLogro.Name = "PbrPuntosLogro";
            this.PbrPuntosLogro.Size = new System.Drawing.Size(197, 25);
            this.PbrPuntosLogro.TabIndex = 3;
            // 
            // LblLogrosAlcanzados
            // 
            this.LblLogrosAlcanzados.AutoSize = true;
            this.LblLogrosAlcanzados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogrosAlcanzados.Location = new System.Drawing.Point(211, 440);
            this.LblLogrosAlcanzados.Name = "LblLogrosAlcanzados";
            this.LblLogrosAlcanzados.Size = new System.Drawing.Size(24, 25);
            this.LblLogrosAlcanzados.TabIndex = 5;
            this.LblLogrosAlcanzados.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Logros alcanzados:";
            // 
            // LblProximoLogro
            // 
            this.LblProximoLogro.AutoSize = true;
            this.LblProximoLogro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProximoLogro.Location = new System.Drawing.Point(579, 410);
            this.LblProximoLogro.Name = "LblProximoLogro";
            this.LblProximoLogro.Size = new System.Drawing.Size(97, 25);
            this.LblProximoLogro.TabIndex = 7;
            this.LblProximoLogro.Text = "0 Puntos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tu proximo logro:";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 474);
            this.Controls.Add(this.LblProximoLogro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblLogrosAlcanzados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PbrPuntosLogro);
            this.Controls.Add(this.TxtPuntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AreaDeJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaPrincipal";
            this.Text = "El mejor juego de la historia (Snake)";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
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
        private System.Windows.Forms.ProgressBar PbrPuntosLogro;
        private System.Windows.Forms.Label LblLogrosAlcanzados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblProximoLogro;
        private System.Windows.Forms.Label label5;
    }
}

