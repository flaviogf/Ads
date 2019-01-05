namespace LES_17_I_N
{
    partial class frmtipohorario
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
            this.txtthocodi = new System.Windows.Forms.TextBox();
            this.txtthonome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.tbctipohorarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvtipohorario = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbctipohorarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtthocodi
            // 
            this.txtthocodi.Location = new System.Drawing.Point(26, 35);
            this.txtthocodi.Name = "txtthocodi";
            this.txtthocodi.Size = new System.Drawing.Size(100, 20);
            this.txtthocodi.TabIndex = 1;
            this.txtthocodi.Leave += new System.EventHandler(this.txtthocodi_Leave);
            // 
            // txtthonome
            // 
            this.txtthonome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtthonome.Location = new System.Drawing.Point(26, 109);
            this.txtthonome.MaxLength = 50;
            this.txtthonome.Name = "txtthonome";
            this.txtthonome.Size = new System.Drawing.Size(318, 20);
            this.txtthonome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(269, 174);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(188, 174);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(107, 174);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 4;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(26, 174);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 3;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // tbctipohorarios
            // 
            this.tbctipohorarios.Controls.Add(this.tabPage1);
            this.tbctipohorarios.Controls.Add(this.tabPage2);
            this.tbctipohorarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctipohorarios.Location = new System.Drawing.Point(0, 0);
            this.tbctipohorarios.Name = "tbctipohorarios";
            this.tbctipohorarios.SelectedIndex = 0;
            this.tbctipohorarios.Size = new System.Drawing.Size(384, 361);
            this.tbctipohorarios.TabIndex = 11;
            this.tbctipohorarios.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbctipohorarios_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvtipohorario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvtipohorario
            // 
            this.dgvtipohorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipohorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtipohorario.Location = new System.Drawing.Point(3, 3);
            this.dgvtipohorario.MultiSelect = false;
            this.dgvtipohorario.Name = "dgvtipohorario";
            this.dgvtipohorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtipohorario.Size = new System.Drawing.Size(370, 329);
            this.dgvtipohorario.TabIndex = 12;
            this.dgvtipohorario.DoubleClick += new System.EventHandler(this.dgvtipohorario_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.txtthocodi);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.txtthonome);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmtipohorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbctipohorarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmtipohorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Tipos de Horários";
            this.Load += new System.EventHandler(this.frmtipohorario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmtipohorario_KeyDown);
            this.tbctipohorarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipohorario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtthocodi;
        private System.Windows.Forms.TextBox txtthonome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TabControl tbctipohorarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvtipohorario;
    }
}