
namespace LaboratorioProgramacionUno.Vista
{
    partial class FrmLogin
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEntrarUs = new System.Windows.Forms.Button();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.BtnEntrarAd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(38, 55);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(73, 25);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            this.LblUsuario.Click += new System.EventHandler(this.LblUsuario_Click);
            // 
            // LblPass
            // 
            this.LblPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.Location = new System.Drawing.Point(38, 155);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(104, 25);
            this.LblPass.TabIndex = 1;
            this.LblPass.Text = "Contraseña";
            this.LblPass.Click += new System.EventHandler(this.LblPass_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEntrarAd);
            this.panel1.Controls.Add(this.BtnEntrarUs);
            this.panel1.Controls.Add(this.TxtContraseña);
            this.panel1.Controls.Add(this.TxtUsuario);
            this.panel1.Controls.Add(this.LblUsuario);
            this.panel1.Controls.Add(this.LblPass);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 272);
            this.panel1.TabIndex = 2;
            // 
            // BtnEntrarUs
            // 
            this.BtnEntrarUs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntrarUs.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrarUs.Location = new System.Drawing.Point(43, 221);
            this.BtnEntrarUs.Name = "BtnEntrarUs";
            this.BtnEntrarUs.Size = new System.Drawing.Size(136, 33);
            this.BtnEntrarUs.TabIndex = 4;
            this.BtnEntrarUs.Text = "Entrar User ";
            this.BtnEntrarUs.UseVisualStyleBackColor = true;
            this.BtnEntrarUs.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtContraseña.Location = new System.Drawing.Point(174, 155);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.Size = new System.Drawing.Size(166, 20);
            this.TxtContraseña.TabIndex = 3;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsuario.Location = new System.Drawing.Point(174, 61);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(166, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // BtnEntrarAd
            // 
            this.BtnEntrarAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEntrarAd.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEntrarAd.Location = new System.Drawing.Point(208, 221);
            this.BtnEntrarAd.Name = "BtnEntrarAd";
            this.BtnEntrarAd.Size = new System.Drawing.Size(132, 33);
            this.BtnEntrarAd.TabIndex = 5;
            this.BtnEntrarAd.Text = "Entrar Admin";
            this.BtnEntrarAd.UseVisualStyleBackColor = true;
            this.BtnEntrarAd.Click += new System.EventHandler(this.BtnEntrarAd_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 306);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.TextBox TxtUsuario;
        public System.Windows.Forms.Button BtnEntrarAd;
        public System.Windows.Forms.Button BtnEntrarUs;
    }
}