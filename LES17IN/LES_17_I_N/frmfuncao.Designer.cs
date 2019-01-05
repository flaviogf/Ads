namespace LES_17_I_N
{
    partial class frmfuncao
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
            this.txtfuccodi = new System.Windows.Forms.TextBox();
            this.txtfucnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbocbos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.tbcfuncao = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvfuncao = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcfuncao.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtfuccodi
            // 
            this.txtfuccodi.Location = new System.Drawing.Point(39, 46);
            this.txtfuccodi.Name = "txtfuccodi";
            this.txtfuccodi.Size = new System.Drawing.Size(100, 20);
            this.txtfuccodi.TabIndex = 0;
            this.txtfuccodi.Leave += new System.EventHandler(this.txtfuccodi_Leave);
            // 
            // txtfucnome
            // 
            this.txtfucnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfucnome.Location = new System.Drawing.Point(39, 110);
            this.txtfucnome.MaxLength = 50;
            this.txtfucnome.Name = "txtfucnome";
            this.txtfucnome.Size = new System.Drawing.Size(309, 20);
            this.txtfucnome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // cbocbos
            // 
            this.cbocbos.FormattingEnabled = true;
            this.cbocbos.Location = new System.Drawing.Point(39, 172);
            this.cbocbos.Name = "cbocbos";
            this.cbocbos.Size = new System.Drawing.Size(309, 21);
            this.cbocbos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cbo";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(273, 246);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(192, 246);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 13;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(111, 246);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 12;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(30, 246);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 11;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // tbcfuncao
            // 
            this.tbcfuncao.Controls.Add(this.tabPage1);
            this.tbcfuncao.Controls.Add(this.tabPage2);
            this.tbcfuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcfuncao.Location = new System.Drawing.Point(0, 0);
            this.tbcfuncao.Name = "tbcfuncao";
            this.tbcfuncao.SelectedIndex = 0;
            this.tbcfuncao.Size = new System.Drawing.Size(384, 361);
            this.tbcfuncao.TabIndex = 15;
            this.tbcfuncao.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcfuncao_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvfuncao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvfuncao
            // 
            this.dgvfuncao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfuncao.Location = new System.Drawing.Point(3, 3);
            this.dgvfuncao.MultiSelect = false;
            this.dgvfuncao.Name = "dgvfuncao";
            this.dgvfuncao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncao.Size = new System.Drawing.Size(370, 329);
            this.dgvfuncao.TabIndex = 0;
            this.dgvfuncao.DoubleClick += new System.EventHandler(this.dgvfuncao_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.txtfuccodi);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.txtfucnome);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.cbocbos);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmfuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcfuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção das Funções";
            this.Load += new System.EventHandler(this.frmfuncao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmfuncao_KeyDown);
            this.tbcfuncao.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncao)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtfuccodi;
        private System.Windows.Forms.TextBox txtfucnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbocbos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TabControl tbcfuncao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvfuncao;
        private System.Windows.Forms.TabPage tabPage2;
    }
}