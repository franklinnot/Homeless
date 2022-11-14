namespace Homeless
{
    partial class FormServices
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnReservaciones = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPacks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(198, 80);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(29, 13);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "Hey ";
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Location = new System.Drawing.Point(253, 164);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Size = new System.Drawing.Size(171, 275);
            this.btnReservaciones.TabIndex = 1;
            this.btnReservaciones.Text = "RESERVACIONES";
            this.btnReservaciones.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(797, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnPacks
            // 
            this.btnPacks.Location = new System.Drawing.Point(484, 164);
            this.btnPacks.Name = "btnPacks";
            this.btnPacks.Size = new System.Drawing.Size(171, 275);
            this.btnPacks.TabIndex = 4;
            this.btnPacks.Text = "PACKS PARTY";
            this.btnPacks.UseVisualStyleBackColor = true;
            // 
            // FormServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnPacks);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReservaciones);
            this.Controls.Add(this.lblSaludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homeless";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaludo;
        private System.Windows.Forms.Button btnReservaciones;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPacks;
    }
}