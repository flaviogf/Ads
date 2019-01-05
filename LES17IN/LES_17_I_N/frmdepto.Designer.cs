namespace LES_17_I_N {
    partial class frmdepto {
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
            this.tbcdeptos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvdeptos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtdepnome = new System.Windows.Forms.TextBox();
            this.txtdepcodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.tbcdeptos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeptos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcdeptos
            // 
            this.tbcdeptos.Controls.Add(this.tabPage1);
            this.tbcdeptos.Controls.Add(this.tabPage2);
            this.tbcdeptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcdeptos.Location = new System.Drawing.Point(0, 0);
            this.tbcdeptos.Name = "tbcdeptos";
            this.tbcdeptos.SelectedIndex = 0;
            this.tbcdeptos.Size = new System.Drawing.Size(384, 361);
            this.tbcdeptos.TabIndex = 0;
            this.tbcdeptos.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcdeptos_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvdeptos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvdeptos
            // 
            this.dgvdeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdeptos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvdeptos.Location = new System.Drawing.Point(3, 3);
            this.dgvdeptos.MultiSelect = false;
            this.dgvdeptos.Name = "dgvdeptos";
            this.dgvdeptos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdeptos.Size = new System.Drawing.Size(370, 329);
            this.dgvdeptos.TabIndex = 0;
            this.dgvdeptos.DoubleClick += new System.EventHandler(this.dgvdeptos_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtdepnome);
            this.tabPage2.Controls.Add(this.txtdepcodi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtdepnome
            // 
            this.txtdepnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdepnome.Location = new System.Drawing.Point(27, 113);
            this.txtdepnome.MaxLength = 50;
            this.txtdepnome.Name = "txtdepnome";
            this.txtdepnome.Size = new System.Drawing.Size(318, 20);
            this.txtdepnome.TabIndex = 2;
            // 
            // txtdepcodi
            // 
            this.txtdepcodi.Location = new System.Drawing.Point(27, 39);
            this.txtdepcodi.Name = "txtdepcodi";
            this.txtdepcodi.Size = new System.Drawing.Size(75, 20);
            this.txtdepcodi.TabIndex = 1;
            this.txtdepcodi.Leave += new System.EventHandler(this.txtdepcodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(270, 195);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(189, 195);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(108, 195);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 4;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(27, 195);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 3;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // frmdepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcdeptos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmdepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados dos Deptos";
            this.Load += new System.EventHandler(this.frmdepto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmdepto_KeyDown);
            this.tbcdeptos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdeptos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcdeptos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvdeptos;
        private System.Windows.Forms.TextBox txtdepnome;
        private System.Windows.Forms.TextBox txtdepcodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
    }
}