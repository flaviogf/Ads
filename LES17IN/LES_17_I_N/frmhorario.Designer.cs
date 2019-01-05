namespace LES_17_I_N
{
    partial class frmhorario
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
            this.txthorcodi = new System.Windows.Forms.TextBox();
            this.txthornome = new System.Windows.Forms.TextBox();
            this.txthormane = new System.Windows.Forms.TextBox();
            this.txthormans = new System.Windows.Forms.TextBox();
            this.txthortare = new System.Windows.Forms.TextBox();
            this.txthortars = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.cbotipos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbchorario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvhorario = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbchorario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txthorcodi
            // 
            this.txthorcodi.Location = new System.Drawing.Point(26, 30);
            this.txthorcodi.Name = "txthorcodi";
            this.txthorcodi.Size = new System.Drawing.Size(100, 20);
            this.txthorcodi.TabIndex = 0;
            this.txthorcodi.Leave += new System.EventHandler(this.txthorcodi_Leave);
            // 
            // txthornome
            // 
            this.txthornome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthornome.Location = new System.Drawing.Point(189, 30);
            this.txthornome.MaxLength = 50;
            this.txthornome.Name = "txthornome";
            this.txthornome.Size = new System.Drawing.Size(100, 20);
            this.txthornome.TabIndex = 1;
            // 
            // txthormane
            // 
            this.txthormane.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthormane.Location = new System.Drawing.Point(26, 92);
            this.txthormane.MaxLength = 5;
            this.txthormane.Name = "txthormane";
            this.txthormane.Size = new System.Drawing.Size(100, 20);
            this.txthormane.TabIndex = 2;
            // 
            // txthormans
            // 
            this.txthormans.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthormans.Location = new System.Drawing.Point(189, 92);
            this.txthormans.MaxLength = 5;
            this.txthormans.Name = "txthormans";
            this.txthormans.Size = new System.Drawing.Size(100, 20);
            this.txthormans.TabIndex = 3;
            // 
            // txthortare
            // 
            this.txthortare.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthortare.Location = new System.Drawing.Point(26, 167);
            this.txthortare.MaxLength = 5;
            this.txthortare.Name = "txthortare";
            this.txthortare.Size = new System.Drawing.Size(100, 20);
            this.txthortare.TabIndex = 4;
            // 
            // txthortars
            // 
            this.txthortars.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txthortars.Location = new System.Drawing.Point(189, 167);
            this.txthortars.MaxLength = 5;
            this.txthortars.Name = "txthortars";
            this.txthortars.Size = new System.Drawing.Size(100, 20);
            this.txthortars.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Horário Manhã Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Horário Manhã Saida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Horário Tarde Entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Horário Tarde Saida";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(269, 286);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(188, 286);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 9;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(107, 286);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 8;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(26, 286);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 7;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // cbotipos
            // 
            this.cbotipos.FormattingEnabled = true;
            this.cbotipos.Location = new System.Drawing.Point(26, 234);
            this.cbotipos.Name = "cbotipos";
            this.cbotipos.Size = new System.Drawing.Size(262, 21);
            this.cbotipos.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo horário";
            // 
            // tbchorario
            // 
            this.tbchorario.Controls.Add(this.tabPage1);
            this.tbchorario.Controls.Add(this.tabPage2);
            this.tbchorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbchorario.Location = new System.Drawing.Point(0, 0);
            this.tbchorario.Name = "tbchorario";
            this.tbchorario.SelectedIndex = 0;
            this.tbchorario.Size = new System.Drawing.Size(384, 361);
            this.tbchorario.TabIndex = 18;
            this.tbchorario.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbchorario_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvhorario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(376, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvhorario
            // 
            this.dgvhorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhorario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvhorario.Location = new System.Drawing.Point(3, 3);
            this.dgvhorario.MultiSelect = false;
            this.dgvhorario.Name = "dgvhorario";
            this.dgvhorario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhorario.Size = new System.Drawing.Size(370, 329);
            this.dgvhorario.TabIndex = 0;
            this.dgvhorario.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txthorcodi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txthornome);
            this.tabPage2.Controls.Add(this.cbotipos);
            this.tabPage2.Controls.Add(this.txthormane);
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.txthormans);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.txthortare);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.txthortars);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(376, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmhorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tbchorario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmhorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Horários";
            this.Load += new System.EventHandler(this.frmhorario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmhorario_KeyDown);
            this.tbchorario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhorario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txthorcodi;
        private System.Windows.Forms.TextBox txthornome;
        private System.Windows.Forms.TextBox txthormane;
        private System.Windows.Forms.TextBox txthormans;
        private System.Windows.Forms.TextBox txthortare;
        private System.Windows.Forms.TextBox txthortars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.ComboBox cbotipos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tbchorario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvhorario;
        private System.Windows.Forms.TabPage tabPage2;
    }
}