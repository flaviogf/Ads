namespace LES_17_I_N
{
    partial class frmproduto
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
            this.tbcproduto = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvproduto = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.cmbunidade = new System.Windows.Forms.ComboBox();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.txtproobs = new System.Windows.Forms.TextBox();
            this.txtproloca = new System.Windows.Forms.TextBox();
            this.txtproesto = new System.Windows.Forms.TextBox();
            this.txtprovend = new System.Windows.Forms.TextBox();
            this.txtpromarg = new System.Windows.Forms.TextBox();
            this.txtprocust = new System.Windows.Forms.TextBox();
            this.txtpronome = new System.Windows.Forms.TextBox();
            this.txtprocodi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcproduto.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcproduto
            // 
            this.tbcproduto.Controls.Add(this.tabPage1);
            this.tbcproduto.Controls.Add(this.tabPage2);
            this.tbcproduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcproduto.Location = new System.Drawing.Point(0, 0);
            this.tbcproduto.Name = "tbcproduto";
            this.tbcproduto.SelectedIndex = 0;
            this.tbcproduto.Size = new System.Drawing.Size(384, 361);
            this.tbcproduto.TabIndex = 0;
            this.tbcproduto.SelectedIndexChanged += new System.EventHandler(this.tbcproduto_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvproduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvproduto
            // 
            this.dgvproduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproduto.Location = new System.Drawing.Point(3, 3);
            this.dgvproduto.MultiSelect = false;
            this.dgvproduto.Name = "dgvproduto";
            this.dgvproduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduto.Size = new System.Drawing.Size(370, 329);
            this.dgvproduto.TabIndex = 0;
            this.dgvproduto.DoubleClick += new System.EventHandler(this.dgvproduto_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.cmbunidade);
            this.tabPage2.Controls.Add(this.cmbgrupo);
            this.tabPage2.Controls.Add(this.txtproobs);
            this.tabPage2.Controls.Add(this.txtproloca);
            this.tabPage2.Controls.Add(this.txtproesto);
            this.tabPage2.Controls.Add(this.txtprovend);
            this.tabPage2.Controls.Add(this.txtpromarg);
            this.tabPage2.Controls.Add(this.txtprocust);
            this.tabPage2.Controls.Add(this.txtpronome);
            this.tabPage2.Controls.Add(this.txtprocodi);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(286, 308);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(286, 279);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 13;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(171, 306);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 12;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(171, 280);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 11;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // cmbunidade
            // 
            this.cmbunidade.FormattingEnabled = true;
            this.cmbunidade.Location = new System.Drawing.Point(171, 252);
            this.cmbunidade.Name = "cmbunidade";
            this.cmbunidade.Size = new System.Drawing.Size(186, 21);
            this.cmbunidade.TabIndex = 10;
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Location = new System.Drawing.Point(171, 193);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Size = new System.Drawing.Size(186, 21);
            this.cmbgrupo.TabIndex = 9;
            // 
            // txtproobs
            // 
            this.txtproobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproobs.Location = new System.Drawing.Point(171, 73);
            this.txtproobs.MaxLength = 200;
            this.txtproobs.Multiline = true;
            this.txtproobs.Name = "txtproobs";
            this.txtproobs.Size = new System.Drawing.Size(186, 78);
            this.txtproobs.TabIndex = 8;
            // 
            // txtproloca
            // 
            this.txtproloca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtproloca.Location = new System.Drawing.Point(171, 19);
            this.txtproloca.MaxLength = 10;
            this.txtproloca.Name = "txtproloca";
            this.txtproloca.Size = new System.Drawing.Size(186, 20);
            this.txtproloca.TabIndex = 7;
            // 
            // txtproesto
            // 
            this.txtproesto.Location = new System.Drawing.Point(11, 310);
            this.txtproesto.Name = "txtproesto";
            this.txtproesto.Size = new System.Drawing.Size(100, 20);
            this.txtproesto.TabIndex = 6;
            // 
            // txtprovend
            // 
            this.txtprovend.Location = new System.Drawing.Point(11, 253);
            this.txtprovend.Name = "txtprovend";
            this.txtprovend.Size = new System.Drawing.Size(75, 20);
            this.txtprovend.TabIndex = 5;
            // 
            // txtpromarg
            // 
            this.txtpromarg.Location = new System.Drawing.Point(11, 193);
            this.txtpromarg.Name = "txtpromarg";
            this.txtpromarg.Size = new System.Drawing.Size(75, 20);
            this.txtpromarg.TabIndex = 4;
            // 
            // txtprocust
            // 
            this.txtprocust.Location = new System.Drawing.Point(11, 131);
            this.txtprocust.Name = "txtprocust";
            this.txtprocust.Size = new System.Drawing.Size(75, 20);
            this.txtprocust.TabIndex = 3;
            // 
            // txtpronome
            // 
            this.txtpronome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpronome.Location = new System.Drawing.Point(11, 73);
            this.txtpronome.MaxLength = 50;
            this.txtpronome.Name = "txtpronome";
            this.txtpronome.Size = new System.Drawing.Size(139, 20);
            this.txtpronome.TabIndex = 2;
            // 
            // txtprocodi
            // 
            this.txtprocodi.Location = new System.Drawing.Point(11, 19);
            this.txtprocodi.Name = "txtprocodi";
            this.txtprocodi.Size = new System.Drawing.Size(75, 20);
            this.txtprocodi.TabIndex = 1;
            this.txtprocodi.Leave += new System.EventHandler(this.txtprocodi_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Unidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Grupo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Observação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Localização";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estoque";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Venda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Margem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Custo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // frmproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos produtos";
            this.Load += new System.EventHandler(this.frmproduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmproduto_KeyDown);
            this.tbcproduto.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcproduto;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvproduto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtproobs;
        private System.Windows.Forms.TextBox txtproloca;
        private System.Windows.Forms.TextBox txtproesto;
        private System.Windows.Forms.TextBox txtprovend;
        private System.Windows.Forms.TextBox txtpromarg;
        private System.Windows.Forms.TextBox txtprocust;
        private System.Windows.Forms.TextBox txtpronome;
        private System.Windows.Forms.TextBox txtprocodi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbunidade;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
    }
}