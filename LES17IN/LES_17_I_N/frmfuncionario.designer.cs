namespace LES_17_I_N
{
    partial class frmfuncionario
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
            this.tbcfuncionario = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvfuncionario = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbdepto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbhorario = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtfunsala = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtfuncelu1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfuncelu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfunfone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfunume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbende = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfundtna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfunrg = new System.Windows.Forms.TextBox();
            this.txtfunnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfuncpf = new System.Windows.Forms.TextBox();
            this.txtfuncodi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcfuncionario.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcfuncionario
            // 
            this.tbcfuncionario.Controls.Add(this.tabPage1);
            this.tbcfuncionario.Controls.Add(this.tabPage2);
            this.tbcfuncionario.Location = new System.Drawing.Point(0, 0);
            this.tbcfuncionario.Name = "tbcfuncionario";
            this.tbcfuncionario.SelectedIndex = 0;
            this.tbcfuncionario.Size = new System.Drawing.Size(683, 461);
            this.tbcfuncionario.TabIndex = 0;
            this.tbcfuncionario.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcfuncionario_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvfuncionario);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listagem";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvfuncionario
            // 
            this.dgvfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvfuncionario.Location = new System.Drawing.Point(3, 3);
            this.dgvfuncionario.MultiSelect = false;
            this.dgvfuncionario.Name = "dgvfuncionario";
            this.dgvfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvfuncionario.Size = new System.Drawing.Size(669, 429);
            this.dgvfuncionario.TabIndex = 0;
            this.dgvfuncionario.DoubleClick += new System.EventHandler(this.dgvfuncionario_DoubleClick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnvoltar);
            this.tabPage2.Controls.Add(this.btnexcluir);
            this.tabPage2.Controls.Add(this.btngravar);
            this.tabPage2.Controls.Add(this.btnincluir);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtfuncodi);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(296, 392);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(205, 392);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 23);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.Text = "Deletar";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(114, 392);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(75, 23);
            this.btngravar.TabIndex = 6;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(25, 392);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(75, 23);
            this.btnincluir.TabIndex = 5;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbdepto);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbhorario);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtfunsala);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(25, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 65);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inf. Contratuais";
            // 
            // cmbdepto
            // 
            this.cmbdepto.FormattingEnabled = true;
            this.cmbdepto.Location = new System.Drawing.Point(255, 24);
            this.cmbdepto.Name = "cmbdepto";
            this.cmbdepto.Size = new System.Drawing.Size(145, 21);
            this.cmbdepto.TabIndex = 3;
            this.cmbdepto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(199, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Depto";
            // 
            // cmbhorario
            // 
            this.cmbhorario.FormattingEnabled = true;
            this.cmbhorario.Location = new System.Drawing.Point(494, 24);
            this.cmbhorario.Name = "cmbhorario";
            this.cmbhorario.Size = new System.Drawing.Size(100, 21);
            this.cmbhorario.TabIndex = 5;
            this.cmbhorario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(435, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Horário";
            // 
            // txtfunsala
            // 
            this.txtfunsala.Location = new System.Drawing.Point(65, 24);
            this.txtfunsala.Name = "txtfunsala";
            this.txtfunsala.Size = new System.Drawing.Size(100, 20);
            this.txtfunsala.TabIndex = 1;
            this.txtfunsala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtfuncelu1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtfuncelu);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtfunfone);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtfunume);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbende);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(25, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // txtfuncelu1
            // 
            this.txtfuncelu1.Location = new System.Drawing.Point(494, 61);
            this.txtfuncelu1.Name = "txtfuncelu1";
            this.txtfuncelu1.Size = new System.Drawing.Size(100, 20);
            this.txtfuncelu1.TabIndex = 9;
            this.txtfuncelu1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Celular";
            // 
            // txtfuncelu
            // 
            this.txtfuncelu.Location = new System.Drawing.Point(281, 61);
            this.txtfuncelu.Name = "txtfuncelu";
            this.txtfuncelu.Size = new System.Drawing.Size(119, 20);
            this.txtfuncelu.TabIndex = 7;
            this.txtfuncelu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Celular";
            // 
            // txtfunfone
            // 
            this.txtfunfone.Location = new System.Drawing.Point(79, 61);
            this.txtfunfone.Name = "txtfunfone";
            this.txtfunfone.Size = new System.Drawing.Size(121, 20);
            this.txtfunfone.TabIndex = 5;
            this.txtfunfone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Telefone";
            // 
            // txtfunume
            // 
            this.txtfunume.Location = new System.Drawing.Point(494, 25);
            this.txtfunume.Name = "txtfunume";
            this.txtfunume.Size = new System.Drawing.Size(100, 20);
            this.txtfunume.TabIndex = 3;
            this.txtfunume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número";
            // 
            // cmbende
            // 
            this.cmbende.FormattingEnabled = true;
            this.cmbende.Location = new System.Drawing.Point(79, 25);
            this.cmbende.Name = "cmbende";
            this.cmbende.Size = new System.Drawing.Size(321, 21);
            this.cmbende.TabIndex = 1;
            this.cmbende.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Endereço";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtfundtna);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfunrg);
            this.groupBox1.Controls.Add(this.txtfunnome);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtfuncpf);
            this.groupBox1.Location = new System.Drawing.Point(25, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txtfundtna
            // 
            this.txtfundtna.Location = new System.Drawing.Point(494, 24);
            this.txtfundtna.Name = "txtfundtna";
            this.txtfundtna.Size = new System.Drawing.Size(100, 20);
            this.txtfundtna.TabIndex = 3;
            this.txtfundtna.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dt. Nasc.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // txtfunrg
            // 
            this.txtfunrg.Location = new System.Drawing.Point(281, 61);
            this.txtfunrg.Name = "txtfunrg";
            this.txtfunrg.Size = new System.Drawing.Size(119, 20);
            this.txtfunrg.TabIndex = 7;
            this.txtfunrg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // txtfunnome
            // 
            this.txtfunnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunnome.Location = new System.Drawing.Point(65, 24);
            this.txtfunnome.Name = "txtfunnome";
            this.txtfunnome.Size = new System.Drawing.Size(335, 20);
            this.txtfunnome.TabIndex = 1;
            this.txtfunnome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CPF";
            // 
            // txtfuncpf
            // 
            this.txtfuncpf.Location = new System.Drawing.Point(65, 61);
            this.txtfuncpf.Name = "txtfuncpf";
            this.txtfuncpf.Size = new System.Drawing.Size(135, 20);
            this.txtfuncpf.TabIndex = 5;
            this.txtfuncpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            // 
            // txtfuncodi
            // 
            this.txtfuncodi.Location = new System.Drawing.Point(68, 28);
            this.txtfuncodi.Name = "txtfuncodi";
            this.txtfuncodi.Size = new System.Drawing.Size(70, 20);
            this.txtfuncodi.TabIndex = 1;
            this.txtfuncodi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            this.txtfuncodi.Leave += new System.EventHandler(this.txtfuncodi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // frmfuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.tbcfuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmfuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Funcionários";
            this.Load += new System.EventHandler(this.frmfuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfuncodi_KeyDown);
            this.tbcfuncionario.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcfuncionario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbdepto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbhorario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfunsala;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtfuncelu1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfuncelu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfunfone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfunume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbende;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtfundtna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfunrg;
        private System.Windows.Forms.TextBox txtfunnome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfuncpf;
        private System.Windows.Forms.TextBox txtfuncodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvfuncionario;
    }
}