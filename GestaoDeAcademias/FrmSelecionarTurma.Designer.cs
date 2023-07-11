
namespace GestaoDeAcademias
{
    partial class FrmSelecionarTurma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSelTurmas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelTurmas
            // 
            this.dgvSelTurmas.AllowUserToAddRows = false;
            this.dgvSelTurmas.AllowUserToDeleteRows = false;
            this.dgvSelTurmas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSelTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelTurmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvSelTurmas.EnableHeadersVisualStyles = false;
            this.dgvSelTurmas.Location = new System.Drawing.Point(12, 12);
            this.dgvSelTurmas.MultiSelect = false;
            this.dgvSelTurmas.Name = "dgvSelTurmas";
            this.dgvSelTurmas.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelTurmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSelTurmas.RowHeadersVisible = false;
            this.dgvSelTurmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelTurmas.Size = new System.Drawing.Size(542, 310);
            this.dgvSelTurmas.TabIndex = 3;
            this.dgvSelTurmas.TabStop = false;
            this.dgvSelTurmas.DoubleClick += new System.EventHandler(this.dgvSelTurmas_DoubleClick);
            // 
            // FrmSelecionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(566, 330);
            this.Controls.Add(this.dgvSelTurmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelecionarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Turma";
            this.Load += new System.EventHandler(this.FrmSelecionarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelTurmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelTurmas;
    }
}