
namespace GestaoDeAcademias
{
    partial class Frm_Login
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
            this.tb_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.pbConfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Senha
            // 
            this.tb_Senha.Location = new System.Drawing.Point(15, 115);
            this.tb_Senha.Name = "tb_Senha";
            this.tb_Senha.PasswordChar = '*';
            this.tb_Senha.Size = new System.Drawing.Size(149, 20);
            this.tb_Senha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUÁRIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SENHA:";
            // 
            // btn_Logar
            // 
            this.btn_Logar.Location = new System.Drawing.Point(15, 150);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(149, 23);
            this.btn_Logar.TabIndex = 4;
            this.btn_Logar.Text = "ENTRAR";
            this.btn_Logar.UseVisualStyleBackColor = true;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(15, 180);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(149, 23);
            this.btn_Limpar.TabIndex = 5;
            this.btn_Limpar.Text = "SAIR";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // cbUser
            // 
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(15, 52);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(149, 21);
            this.cbUser.TabIndex = 6;
            // 
            // pbConfig
            // 
            this.pbConfig.Image = global::GestaoDeAcademias.Properties.Resources.configurações;
            this.pbConfig.Location = new System.Drawing.Point(142, 218);
            this.pbConfig.Name = "pbConfig";
            this.pbConfig.Size = new System.Drawing.Size(35, 32);
            this.pbConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConfig.TabIndex = 7;
            this.pbConfig.TabStop = false;
            this.pbConfig.Click += new System.EventHandler(this.pbConfig_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(180, 253);
            this.Controls.Add(this.pbConfig);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Senha);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.PictureBox pbConfig;
    }
}