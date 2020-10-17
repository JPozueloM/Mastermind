namespace MASTERMIND
{
    partial class Mastermind
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.aciertosParciales = new System.Windows.Forms.Label();
            this.aciertosTotales = new System.Windows.Forms.Label();
            this.intentoActual = new System.Windows.Forms.Label();
            this.intentosRestantes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(141, 176);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(89, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar Juego";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(141, 60);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(89, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(35, 62);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 2;
            // 
            // aciertosParciales
            // 
            this.aciertosParciales.AutoSize = true;
            this.aciertosParciales.Location = new System.Drawing.Point(239, 63);
            this.aciertosParciales.Name = "aciertosParciales";
            this.aciertosParciales.Size = new System.Drawing.Size(0, 13);
            this.aciertosParciales.TabIndex = 3;
            // 
            // aciertosTotales
            // 
            this.aciertosTotales.AutoSize = true;
            this.aciertosTotales.Location = new System.Drawing.Point(239, 86);
            this.aciertosTotales.Name = "aciertosTotales";
            this.aciertosTotales.Size = new System.Drawing.Size(0, 13);
            this.aciertosTotales.TabIndex = 4;
            this.aciertosTotales.Click += new System.EventHandler(this.label1_Click);
            // 
            // intentoActual
            // 
            this.intentoActual.AutoSize = true;
            this.intentoActual.Location = new System.Drawing.Point(245, 186);
            this.intentoActual.Name = "intentoActual";
            this.intentoActual.Size = new System.Drawing.Size(0, 13);
            this.intentoActual.TabIndex = 5;
            // 
            // intentosRestantes
            // 
            this.intentosRestantes.AutoSize = true;
            this.intentosRestantes.Location = new System.Drawing.Point(245, 206);
            this.intentosRestantes.Name = "intentosRestantes";
            this.intentosRestantes.Size = new System.Drawing.Size(0, 13);
            this.intentosRestantes.TabIndex = 6;
            // 
            // Mastermind
            // 
            this.Controls.Add(this.intentosRestantes);
            this.Controls.Add(this.intentoActual);
            this.Controls.Add(this.aciertosTotales);
            this.Controls.Add(this.aciertosParciales);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Mastermind";
            this.Size = new System.Drawing.Size(363, 231);
            this.Load += new System.EventHandler(this.Mastermind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Label aciertosParciales;
        private System.Windows.Forms.Label aciertosTotales;
        private System.Windows.Forms.Label intentoActual;
        private System.Windows.Forms.Label intentosRestantes;
    }
}
