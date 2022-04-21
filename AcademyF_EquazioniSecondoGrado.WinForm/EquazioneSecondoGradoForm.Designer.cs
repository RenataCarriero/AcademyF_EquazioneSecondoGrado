namespace AcademyF_EquazioniSecondoGrado.WinForm
{
    partial class EquazioneSecondoGradoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRisolvi = new System.Windows.Forms.Button();
            this.lblSoluzione = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(75, 337);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(44, 31);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(200, 337);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(41, 31);
            this.txtB.TabIndex = 1;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(305, 337);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(48, 31);
            this.txtC.TabIndex = 2;
            this.txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtC_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "x^2    +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "x    +";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "=0";
            // 
            // btnRisolvi
            // 
            this.btnRisolvi.Location = new System.Drawing.Point(121, 417);
            this.btnRisolvi.Name = "btnRisolvi";
            this.btnRisolvi.Size = new System.Drawing.Size(178, 45);
            this.btnRisolvi.TabIndex = 7;
            this.btnRisolvi.Text = "Risolvi equazione";
            this.btnRisolvi.UseVisualStyleBackColor = true;
            this.btnRisolvi.Click += new System.EventHandler(this.btnRisolvi_Click);
            // 
            // lblSoluzione
            // 
            this.lblSoluzione.AutoSize = true;
            this.lblSoluzione.Location = new System.Drawing.Point(510, 371);
            this.lblSoluzione.Name = "lblSoluzione";
            this.lblSoluzione.Size = new System.Drawing.Size(0, 25);
            this.lblSoluzione.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AcademyF_EquazioniSecondoGrado.WinForm.Properties.Resources.math;
            this.pictureBox1.Location = new System.Drawing.Point(53, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // EquazioneSecondoGradoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSoluzione);
            this.Controls.Add(this.btnRisolvi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "EquazioneSecondoGradoForm";
            this.Text = "Equazione di secondo grado!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;      
        private System.Windows.Forms.Button btnRisolvi;
        private System.Windows.Forms.Label lblSoluzione;
        private PictureBox pictureBox1;
    }
}