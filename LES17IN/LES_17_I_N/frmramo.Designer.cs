namespace LES_17_I_N
{
    partial class frmramo
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
            this.tbcramo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvramo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtramobse = new System.Windows.Forms.TextBox();
            this.txtramnome = new System.Windows.Forms.TextBox();
            this.txtramcodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcramo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvramo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcramo
            // 
            this.tbcramo.Controls.Add(this.tabPage1);
            this.tbcramo.Controls.Add(this.tabPage2);
            this.tbcramo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcramo.Location = new System.Drawing.Point(0, 0);
            this.tbcramo.Name = "tbcramo";
            this.tbcramo.SelectedIndex = 0;
            this.tbcramo.Size = new System.Drawing.Size(384, 361);
            this.tbcramo.TabIndex = 0;
            this.tbcramo.SelectedIndexChanged += new System.EventHandler(this.tbcramo_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvramo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvramo
            // 
            this.dgvramo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvramo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvramo.Location = new System.Drawing.Point(3, 3);
            this.dgvramo.MultiSelect = false;
            this.dgvramo.Name = "dgvramo";
            this.dgvramo.ReadOnly = true;
            this.dgvramo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvramo.Size = new System.Drawing.Size(370, 329);
            this.dgvramo.TabIndex = 0;
            this.dgvramo.DoubleClick += new System.EventHandler(this.dgvramo_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.txtramobse);
            this.tabPage2.Controls.Add(this.txtramnome);
            this.tabPage2.Controls.Add(this.txtramcodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
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
            this.btnvoltar.Location = new System.Drawing.Point(271, 288);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 7;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(190, 288);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 6;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(109, 288);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(28, 288);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtramobse
            // 
            this.txtramobse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtramobse.Location = new System.Drawing.Point(28, 187);
            this.txtramobse.MaxLength = 200;
            this.txtramobse.Multiline = true;
            this.txtramobse.Name = "txtramobse";
            this.txtramobse.Size = new System.Drawing.Size(313, 82);
            this.txtramobse.TabIndex = 3;
            // 
            // txtramnome
            // 
            this.txtramnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtramnome.Location = new System.Drawing.Point(28, 103);
            this.txtramnome.MaxLength = 50;
            this.txtramnome.Name = "txtramnome";
            this.txtramnome.Size = new System.Drawing.Size(313, 20);
            this.txtramnome.TabIndex = 2;
            // 
            // txtramcodi
            // 
            this.txtramcodi.Location = new System.Drawing.Point(28, 33);
            this.txtramcodi.Name = "txtramcodi";
            this.txtramcodi.Size = new System.Drawing.Size(100, 20);
            this.txtramcodi.TabIndex = 1;
            this.txtramcodi.Leave += new System.EventHandler(this.txtramcodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Observação";
            // 
            // frmramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbcramo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmramo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos ramos";
            this.Load += new System.EventHandler(this.frmramo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmramo_KeyDown);
            this.tbcramo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvramo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcramo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtramobse;
        private System.Windows.Forms.TextBox txtramnome;
        private System.Windows.Forms.TextBox txtramcodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvramo;
    }
}