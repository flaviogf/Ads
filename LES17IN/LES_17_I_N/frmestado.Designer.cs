namespace LES_17_I_N {
    partial class frmestado {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtestcodi = new System.Windows.Forms.TextBox();
            this.txtesticms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtestnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxestuf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbopaises = new System.Windows.Forms.ComboBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.tbcestado = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEstado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbcestado.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txtestcodi
            // 
            this.txtestcodi.Location = new System.Drawing.Point(26, 36);
            this.txtestcodi.Name = "txtestcodi";
            this.txtestcodi.Size = new System.Drawing.Size(100, 20);
            this.txtestcodi.TabIndex = 1;
            this.txtestcodi.Leave += new System.EventHandler(this.txtestcodi_Leave);
            // 
            // txtesticms
            // 
            this.txtesticms.Location = new System.Drawing.Point(26, 86);
            this.txtesticms.Name = "txtesticms";
            this.txtesticms.Size = new System.Drawing.Size(237, 20);
            this.txtesticms.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ICMS:";
            // 
            // txtestnome
            // 
            this.txtestnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestnome.Location = new System.Drawing.Point(24, 132);
            this.txtestnome.MaxLength = 50;
            this.txtestnome.Name = "txtestnome";
            this.txtestnome.Size = new System.Drawing.Size(320, 20);
            this.txtestnome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome:";
            // 
            // txtxestuf
            // 
            this.txtxestuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtxestuf.Location = new System.Drawing.Point(26, 183);
            this.txtxestuf.MaxLength = 2;
            this.txtxestuf.Name = "txtxestuf";
            this.txtxestuf.Size = new System.Drawing.Size(100, 20);
            this.txtxestuf.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pais";
            // 
            // cbopaises
            // 
            this.cbopaises.FormattingEnabled = true;
            this.cbopaises.Location = new System.Drawing.Point(26, 229);
            this.cbopaises.Name = "cbopaises";
            this.cbopaises.Size = new System.Drawing.Size(237, 21);
            this.cbopaises.TabIndex = 5;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(269, 288);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(188, 288);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 8;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(107, 288);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 7;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(26, 288);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 6;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // tbcestado
            // 
            this.tbcestado.Controls.Add(this.tabPage1);
            this.tbcestado.Controls.Add(this.tabPage2);
            this.tbcestado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcestado.Location = new System.Drawing.Point(0, 0);
            this.tbcestado.Name = "tbcestado";
            this.tbcestado.SelectedIndex = 0;
            this.tbcestado.Size = new System.Drawing.Size(384, 362);
            this.tbcestado.TabIndex = 14;
            this.tbcestado.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcestado_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEstado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 336);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEstado
            // 
            this.dgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstado.Location = new System.Drawing.Point(3, 3);
            this.dgvEstado.MultiSelect = false;
            this.dgvEstado.Name = "dgvEstado";
            this.dgvEstado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstado.Size = new System.Drawing.Size(370, 330);
            this.dgvEstado.TabIndex = 0;
            this.dgvEstado.DoubleClick += new System.EventHandler(this.dgvEstado_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.txtestcodi);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.txtesticms);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbopaises);
            this.tabPage2.Controls.Add(this.txtestnome);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtxestuf);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 336);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmestado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tbcestado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmestado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Estados";
            this.Load += new System.EventHandler(this.frmestado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmestado_KeyDown);
            this.tbcestado.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtestcodi;
        private System.Windows.Forms.TextBox txtesticms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtestnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxestuf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbopaises;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TabControl tbcestado;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvEstado;
    }
}