namespace LES_17_I_N {
    partial class frmmunicipio {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbcmunicipio = new System.Windows.Forms.TabControl();
            this.tbccidade = new System.Windows.Forms.TabPage();
            this.dgvMunicipio = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.cboestados = new System.Windows.Forms.ComboBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.txtmunnome = new System.Windows.Forms.TextBox();
            this.btngravar = new System.Windows.Forms.Button();
            this.txtmuncodi = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcmunicipio.SuspendLayout();
            this.tbccidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipio)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcmunicipio
            // 
            this.tbcmunicipio.Controls.Add(this.tbccidade);
            this.tbcmunicipio.Controls.Add(this.tabPage2);
            this.tbcmunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcmunicipio.Location = new System.Drawing.Point(0, 0);
            this.tbcmunicipio.Name = "tbcmunicipio";
            this.tbcmunicipio.SelectedIndex = 0;
            this.tbcmunicipio.Size = new System.Drawing.Size(384, 362);
            this.tbcmunicipio.TabIndex = 0;
            this.tbcmunicipio.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcmunicipio_Selected);
            // 
            // tbccidade
            // 
            this.tbccidade.Controls.Add(this.dgvMunicipio);
            this.tbccidade.Location = new System.Drawing.Point(4, 22);
            this.tbccidade.Name = "tbccidade";
            this.tbccidade.Padding = new System.Windows.Forms.Padding(3);
            this.tbccidade.Size = new System.Drawing.Size(376, 336);
            this.tbccidade.TabIndex = 0;
            this.tbccidade.Text = "Listagem";
            this.tbccidade.UseVisualStyleBackColor = true;
            // 
            // dgvMunicipio
            // 
            this.dgvMunicipio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMunicipio.Location = new System.Drawing.Point(3, 3);
            this.dgvMunicipio.MultiSelect = false;
            this.dgvMunicipio.Name = "dgvMunicipio";
            this.dgvMunicipio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMunicipio.Size = new System.Drawing.Size(370, 330);
            this.dgvMunicipio.TabIndex = 0;
            this.dgvMunicipio.DoubleClick += new System.EventHandler(this.dgvMunicipio_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.cboestados);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.txtmunnome);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.txtmuncodi);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(266, 214);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // cboestados
            // 
            this.cboestados.FormattingEnabled = true;
            this.cboestados.Location = new System.Drawing.Point(23, 153);
            this.cboestados.Name = "cboestados";
            this.cboestados.Size = new System.Drawing.Size(318, 21);
            this.cboestados.TabIndex = 3;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(185, 214);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // txtmunnome
            // 
            this.txtmunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmunnome.Location = new System.Drawing.Point(23, 95);
            this.txtmunnome.MaxLength = 50;
            this.txtmunnome.Name = "txtmunnome";
            this.txtmunnome.Size = new System.Drawing.Size(318, 20);
            this.txtmunnome.TabIndex = 2;
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(104, 214);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // txtmuncodi
            // 
            this.txtmuncodi.Location = new System.Drawing.Point(23, 34);
            this.txtmuncodi.Name = "txtmuncodi";
            this.txtmuncodi.Size = new System.Drawing.Size(100, 20);
            this.txtmuncodi.TabIndex = 1;
            this.txtmuncodi.Leave += new System.EventHandler(this.txtmuncodi_Leave);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(23, 214);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // frmmunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcmunicipio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Municípios";
            this.Load += new System.EventHandler(this.frmmunicipio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmmunicipio_KeyDown);
            this.tbcmunicipio.ResumeLayout(false);
            this.tbccidade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipio)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcmunicipio;
        private System.Windows.Forms.TabPage tbccidade;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvMunicipio;
        private System.Windows.Forms.ComboBox cboestados;
        private System.Windows.Forms.TextBox txtmunnome;
        private System.Windows.Forms.TextBox txtmuncodi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
    }
}