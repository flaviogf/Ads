namespace LES_17_I_N
{
    partial class frmunidade
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
            this.tbcunidade = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvunidade = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtuninome = new System.Windows.Forms.TextBox();
            this.txtunicodi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcunidade.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunidade)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcunidade
            // 
            this.tbcunidade.Controls.Add(this.tabPage1);
            this.tbcunidade.Controls.Add(this.tabPage2);
            this.tbcunidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcunidade.Location = new System.Drawing.Point(0, 0);
            this.tbcunidade.Name = "tbcunidade";
            this.tbcunidade.SelectedIndex = 0;
            this.tbcunidade.Size = new System.Drawing.Size(384, 361);
            this.tbcunidade.TabIndex = 0;
            this.tbcunidade.SelectedIndexChanged += new System.EventHandler(this.tbcunidade_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvunidade);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvunidade
            // 
            this.dgvunidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvunidade.Location = new System.Drawing.Point(3, 3);
            this.dgvunidade.MultiSelect = false;
            this.dgvunidade.Name = "dgvunidade";
            this.dgvunidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvunidade.Size = new System.Drawing.Size(370, 329);
            this.dgvunidade.TabIndex = 0;
            this.dgvunidade.DoubleClick += new System.EventHandler(this.dgvunidade_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtuninome);
            this.tabPage2.Controls.Add(this.txtunicodi);
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
            this.btnvoltar.Location = new System.Drawing.Point(269, 170);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(188, 170);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 5;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(107, 170);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 4;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(26, 170);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 3;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtuninome
            // 
            this.txtuninome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtuninome.Location = new System.Drawing.Point(26, 107);
            this.txtuninome.MaxLength = 50;
            this.txtuninome.Name = "txtuninome";
            this.txtuninome.Size = new System.Drawing.Size(318, 20);
            this.txtuninome.TabIndex = 2;
            // 
            // txtunicodi
            // 
            this.txtunicodi.Location = new System.Drawing.Point(26, 39);
            this.txtunicodi.Name = "txtunicodi";
            this.txtunicodi.Size = new System.Drawing.Size(100, 20);
            this.txtunicodi.TabIndex = 1;
            this.txtunicodi.Leave += new System.EventHandler(this.txtunicodi_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // frmunidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcunidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmunidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção da unidades";
            this.Load += new System.EventHandler(this.frmunidade_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmunidade_KeyDown);
            this.tbcunidade.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvunidade)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcunidade;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvunidade;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtuninome;
        private System.Windows.Forms.TextBox txtunicodi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}