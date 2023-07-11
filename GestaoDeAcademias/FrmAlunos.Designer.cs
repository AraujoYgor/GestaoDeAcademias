
namespace GestaoDeAcademias
{
    partial class FrmAlunos
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
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbPlano = new System.Windows.Forms.TextBox();
            this.tb_Turma = new System.Windows.Forms.TextBox();
            this.btnPlanos = new System.Windows.Forms.Button();
            this.btnTurmas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(9, 36);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(247, 20);
            this.tbNome.TabIndex = 0;
            this.tbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(9, 84);
            this.tbTelefone.Mask = "(99)99999-9999";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(141, 20);
            this.tbTelefone.TabIndex = 1;
            this.tbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(9, 123);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(141, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // tbPlano
            // 
            this.tbPlano.Location = new System.Drawing.Point(9, 163);
            this.tbPlano.Name = "tbPlano";
            this.tbPlano.ReadOnly = true;
            this.tbPlano.Size = new System.Drawing.Size(116, 20);
            this.tbPlano.TabIndex = 5;
            this.tbPlano.TabStop = false;
            this.tbPlano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Turma
            // 
            this.tb_Turma.Enabled = false;
            this.tb_Turma.Location = new System.Drawing.Point(9, 202);
            this.tb_Turma.Name = "tb_Turma";
            this.tb_Turma.ReadOnly = true;
            this.tb_Turma.Size = new System.Drawing.Size(116, 20);
            this.tb_Turma.TabIndex = 6;
            this.tb_Turma.TabStop = false;
            this.tb_Turma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlanos
            // 
            this.btnPlanos.Location = new System.Drawing.Point(125, 161);
            this.btnPlanos.Name = "btnPlanos";
            this.btnPlanos.Size = new System.Drawing.Size(25, 23);
            this.btnPlanos.TabIndex = 3;
            this.btnPlanos.Text = "...";
            this.btnPlanos.UseVisualStyleBackColor = true;
            // 
            // btnTurmas
            // 
            this.btnTurmas.Location = new System.Drawing.Point(125, 200);
            this.btnTurmas.Name = "btnTurmas";
            this.btnTurmas.Size = new System.Drawing.Size(25, 23);
            this.btnTurmas.TabIndex = 4;
            this.btnTurmas.Text = "...";
            this.btnTurmas.UseVisualStyleBackColor = true;
            this.btnTurmas.Click += new System.EventHandler(this.btnTurmas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "TELEFONE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "STATUS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "PLANO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "TURMA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnSalva);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 39);
            this.panel1.TabIndex = 21;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Location = new System.Drawing.Point(186, 11);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(70, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalva.Location = new System.Drawing.Point(99, 11);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(70, 23);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "SALVAR";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Location = new System.Drawing.Point(9, 11);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(156, 84);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(100, 138);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 22;
            this.pbFoto.TabStop = false;
            this.pbFoto.DoubleClick += new System.EventHandler(this.pbFoto_DoubleClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Foto";
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(265, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTurmas);
            this.Controls.Add(this.btnPlanos);
            this.Controls.Add(this.tb_Turma);
            this.Controls.Add(this.tbPlano);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnPlanos;
        private System.Windows.Forms.Button btnTurmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.TextBox tbPlano;
        public System.Windows.Forms.TextBox tb_Turma;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}