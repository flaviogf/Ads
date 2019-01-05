namespace LES_17_I_N {
    partial class frmbairro {
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
            this.tbcbairro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvbairro = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.cbomunicipios = new System.Windows.Forms.ComboBox();
            this.txtbainome = new System.Windows.Forms.TextBox();
            this.txtbaicodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcbairro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbairro)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcbairro
            // 
            this.tbcbairro.Controls.Add(this.tabPage1);
            this.tbcbairro.Controls.Add(this.tabPage2);
            this.tbcbairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcbairro.Location = new System.Drawing.Point(0, 0);
            this.tbcbairro.Name = "tbcbairro";
            this.tbcbairro.SelectedIndex = 0;
            this.tbcbairro.Size = new System.Drawing.Size(384, 362);
            this.tbcbairro.TabIndex = 0;
            this.tbcbairro.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcbairro_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvbairro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvbairro
            // 
            this.dgvbairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbairro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvbairro.Location = new System.Drawing.Point(3, 3);
            this.dgvbairro.MultiSelect = false;
            this.dgvbairro.Name = "dgvbairro";
            this.dgvbairro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbairro.Size = new System.Drawing.Size(370, 330);
            this.dgvbairro.TabIndex = 0;
            this.dgvbairro.DoubleClick += new System.EventHandler(this.dgvbairro_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.cbomunicipios);
            this.tabPage2.Controls.Add(this.txtbainome);
            this.tabPage2.Controls.Add(this.txtbaicodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
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
            this.btnvoltar.Location = new System.Drawing.Point(266, 212);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(185, 212);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(104, 212);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(23, 212);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 5;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // cbomunicipios
            // 
            this.cbomunicipios.FormattingEnabled = true;
            this.cbomunicipios.Location = new System.Drawing.Point(23, 157);
            this.cbomunicipios.Name = "cbomunicipios";
            this.cbomunicipios.Size = new System.Drawing.Size(318, 21);
            this.cbomunicipios.TabIndex = 3;
            // 
            // txtbainome
            // 
            this.txtbainome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbainome.Location = new System.Drawing.Point(23, 98);
            this.txtbainome.MaxLength = 50;
            this.txtbainome.Name = "txtbainome";
            this.txtbainome.Size = new System.Drawing.Size(318, 20);
            this.txtbainome.TabIndex = 2;
            // 
            // txtbaicodi
            // 
            this.txtbaicodi.Location = new System.Drawing.Point(23, 45);
            this.txtbaicodi.Name = "txtbaicodi";
            this.txtbaicodi.Size = new System.Drawing.Size(100, 20);
            this.txtbaicodi.TabIndex = 1;
            this.txtbaicodi.Leave += new System.EventHandler(this.txtbaicodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Município:";
            // 
            // frmbairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcbairro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmbairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Bairros";
            this.Load += new System.EventHandler(this.frmbairro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmbairro_KeyDown);
            this.tbcbairro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbairro)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcbairro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvbairro;
        private System.Windows.Forms.ComboBox cbomunicipios;
        private System.Windows.Forms.TextBox txtbainome;
        private System.Windows.Forms.TextBox txtbaicodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
    }
}