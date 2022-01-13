namespace CentrarVentana
{
    partial class frmPrincipal
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
            this.cmdCentrarVentana = new System.Windows.Forms.Button();
            this.lstListaVentanas = new System.Windows.Forms.ListBox();
            this.cmdActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCentrarVentana
            // 
            this.cmdCentrarVentana.Location = new System.Drawing.Point(266, 341);
            this.cmdCentrarVentana.Name = "cmdCentrarVentana";
            this.cmdCentrarVentana.Size = new System.Drawing.Size(116, 23);
            this.cmdCentrarVentana.TabIndex = 2;
            this.cmdCentrarVentana.Text = "&Centrar Ventana";
            this.cmdCentrarVentana.UseVisualStyleBackColor = true;
            this.cmdCentrarVentana.Click += new System.EventHandler(this.cmdCentrarVentana_Click);
            // 
            // lstListaVentanas
            // 
            this.lstListaVentanas.FormattingEnabled = true;
            this.lstListaVentanas.Location = new System.Drawing.Point(12, 12);
            this.lstListaVentanas.Name = "lstListaVentanas";
            this.lstListaVentanas.Size = new System.Drawing.Size(248, 381);
            this.lstListaVentanas.TabIndex = 3;
            // 
            // cmdActualizar
            // 
            this.cmdActualizar.Location = new System.Drawing.Point(266, 370);
            this.cmdActualizar.Name = "cmdActualizar";
            this.cmdActualizar.Size = new System.Drawing.Size(116, 23);
            this.cmdActualizar.TabIndex = 4;
            this.cmdActualizar.Text = "&Actualizar";
            this.cmdActualizar.UseVisualStyleBackColor = true;
            this.cmdActualizar.Click += new System.EventHandler(this.cmdActualizar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 404);
            this.Controls.Add(this.cmdActualizar);
            this.Controls.Add(this.lstListaVentanas);
            this.Controls.Add(this.cmdCentrarVentana);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centrar";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdCentrarVentana;
        private System.Windows.Forms.ListBox lstListaVentanas;
        private System.Windows.Forms.Button cmdActualizar;
    }
}

