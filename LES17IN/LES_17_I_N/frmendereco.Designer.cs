namespace LES_17_I_N {
    partial class frmendereco {
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
            this.tbcendereco = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvendereco = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.cbobairros = new System.Windows.Forms.ComboBox();
            this.txtendcep = new System.Windows.Forms.TextBox();
            this.txtendende = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcendereco.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvendereco)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcendereco
            // 
            this.tbcendereco.Controls.Add(this.tabPage1);
            this.tbcendereco.Controls.Add(this.tabPage2);
            this.tbcendereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcendereco.Location = new System.Drawing.Point(0, 0);
            this.tbcendereco.Name = "tbcendereco";
            this.tbcendereco.SelectedIndex = 0;
            this.tbcendereco.Size = new System.Drawing.Size(384, 362);
            this.tbcendereco.TabIndex = 0;
            this.tbcendereco.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcendereco_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvendereco);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvendereco
            // 
            this.dgvendereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvendereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvendereco.Location = new System.Drawing.Point(3, 3);
            this.dgvendereco.MultiSelect = false;
            this.dgvendereco.Name = "dgvendereco";
            this.dgvendereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvendereco.Size = new System.Drawing.Size(370, 330);
            this.dgvendereco.TabIndex = 0;
            this.dgvendereco.DoubleClick += new System.EventHandler(this.dgvendereco_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.cbobairros);
            this.tabPage2.Controls.Add(this.txtendcep);
            this.tabPage2.Controls.Add(this.txtendende);
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
            this.btnvoltar.Location = new System.Drawing.Point(267, 238);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(186, 238);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(105, 238);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(24, 238);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // cbobairros
            // 
            this.cbobairros.FormattingEnabled = true;
            this.cbobairros.Location = new System.Drawing.Point(24, 177);
            this.cbobairros.Name = "cbobairros";
            this.cbobairros.Size = new System.Drawing.Size(318, 21);
            this.cbobairros.TabIndex = 3;
            // 
            // txtendcep
            // 
            this.txtendcep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendcep.Location = new System.Drawing.Point(24, 43);
            this.txtendcep.MaxLength = 9;
            this.txtendcep.Name = "txtendcep";
            this.txtendcep.Size = new System.Drawing.Size(156, 20);
            this.txtendcep.TabIndex = 1;
            this.txtendcep.Leave += new System.EventHandler(this.txtendcep_Leave);
            // 
            // txtendende
            // 
            this.txtendende.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendende.Location = new System.Drawing.Point(24, 108);
            this.txtendende.MaxLength = 50;
            this.txtendende.Name = "txtendende";
            this.txtendende.Size = new System.Drawing.Size(318, 20);
            this.txtendende.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bairro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP:";
            // 
            // frmendereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcendereco);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmendereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Endereços";
            this.Load += new System.EventHandler(this.frmendereco_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmendereco_KeyDown);
            this.tbcendereco.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvendereco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcendereco;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvendereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbobairros;
        private System.Windows.Forms.TextBox txtendcep;
        private System.Windows.Forms.TextBox txtendende;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
    }
}