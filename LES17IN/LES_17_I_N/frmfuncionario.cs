using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_N
{
    public partial class frmfuncionario : Form
    {
        public frmfuncionario()
        {
            InitializeComponent();
            carregarEnde();
            carregarDepto();
            carregarHor();
            DgvDados();
        }

        private void DgvDados()
        {
            Conexao.Active(true);
            try
            {
                //trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT F.funcodi, F.funnome, F.funcpf, F.funrg, F.funfone, F.funcelu, F.funcel1, F.funsala, E.endende, H.hornome, F.fundtna, D.depnome, F.funnume from funcionario as F left join endereco as E on F.endcep = E.endcep left join horario as H on F.horcodi = H.horcodi left join depto as D on F.deptocodi = D.depcodi", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvfuncionario.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void carregarEnde()
        {
            this.cmbende.Items.Clear();

            string s = "SELECT * FROM ENDERECO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, string> p = new Dictionary<string, string>();
            while (r.Read())
            {
                p.Add(r["ENDENDE"].ToString(), (r["ENDCEP"].ToString()));

            }
            this.cmbende.DataSource = new BindingSource(p, null);
            this.cmbende.DisplayMember = "key";
            this.cmbende.ValueMember = "value";
        }

        private void carregarDepto()
        {
            this.cmbdepto.Items.Clear();

            string s = "SELECT * FROM DEPTO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["DEPNOME"].ToString(), Convert.ToInt32(r["DEPCODI"]));

            }
            this.cmbdepto.DataSource = new BindingSource(p, null);
            this.cmbdepto.DisplayMember = "key";
            this.cmbdepto.ValueMember = "value";
        }

        private void carregarHor()
        {
            this.cmbhorario.Items.Clear();

            string s = "SELECT * FROM HORARIO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["HORNOME"].ToString(), Convert.ToInt32(r["HORCODI"]));
            }
            this.cmbhorario.DataSource = new BindingSource(p, null);
            this.cmbhorario.DisplayMember = "key";
            this.cmbhorario.ValueMember = "value";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INCLUIR
            string strIncluir = "INSERT INTO FUNCIONARIO (FUNCODI, FUNNOME, FUNSALA, FUNDTNA, FUNCPF, FUNRG, FUNFONE, FUNCELU, FUNCEL1, FUNNUME, ENDCEP, DEPTOCODI, HORCODI) VALUES ("
                + txtfuncodi.Text + ", "
                + " '" + txtfunnome.Text + "', "
                + " '" + txtfunsala.Text + "', "
                + " '" + txtfundtna.Text.Replace('/', '.').Substring(0, 10) + "', "
                + " '" + txtfuncpf.Text + "', "
                + " '" + txtfunrg.Text + "', "
                + " '" + txtfunfone.Text + "', "
                + " '" + txtfuncelu.Text + "', "
                + " '" + txtfuncelu1.Text + "', "
                + " '" + txtfunume.Text + "', "
                + " '" + Convert.ToInt32(cmbende.SelectedValue) + "', "
                + Convert.ToInt32(cmbdepto.SelectedValue) + ", "
                + Convert.ToInt32(cmbhorario.SelectedValue) + " )";
                    

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ATUALIZAR
            string strAlterar = "UPDATE FUNCIONARIO"
                  + " SET FUNCODI = " + txtfuncodi.Text + ", "
                  + " FUNNOME = '" + txtfunnome.Text + "', "
                  + " FUNSALA = " + txtfunsala.Text + ", "
                  + " FUNCPF = '" + txtfuncpf.Text + "', "
                  + " FUNRG = '" + txtfunrg.Text + "', "
                  + " FUNFONE = '" + txtfunfone.Text + "', "
                  + " FUNCELU = '" + txtfuncelu.Text + "', "
                  + " FUNNUME = '" + txtfunume.Text + "', "
                  + " ENDCEP = '" + (this.cmbende.SelectedValue) + "', "
                  + " HORCODI = " + Convert.ToInt32(this.cmbhorario.SelectedValue) + ", "
                  + " FUNCEL1 = '" + txtfuncelu1.Text + "', "
                  + " FUNDTNA = '" + txtfundtna.Text.Replace('/', '.').Substring(0, 10) + "', "
                  + " DEPTOCODI = " + Convert.ToInt32(this.cmbdepto.SelectedValue)
                  + " WHERE FUNCODI = " + txtfuncodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Excluir
            string strDelete = "DELETE FROM FUNCIONARIO WHERE FUNCODI = " + txtfuncodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpar()
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;
            this.txtfuncodi.Clear();
            this.txtfunnome.Clear();
            this.txtfunsala.Clear();
            this.txtfuncpf.Clear();
            this.txtfunrg.Clear();
            this.txtfunfone.Clear();
            this.txtfuncelu.Clear();
            this.txtfunume.Clear();
            this.txtfuncelu1.Clear();
            this.txtfundtna.Clear();
        }

        private void txtfuncodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtfuncodi.Text != "")
            {
                string strConsulta = "SELECT * FROM FUNCIONARIO WHERE FUNCODI = " +
                txtfuncodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        btnincluir.Enabled = false; 
                        ConsultaFunc(dr);
                        txtfunnome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?",
                        "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            limpar();
                        }
                        else
                        {
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
                            txtfunnome.Clear();
                            txtfundtna.Clear();
                            txtfuncpf.Clear();
                            txtfunrg.Clear();
                            cmbende.SelectedIndex = 0;
                            txtfunume.Clear();
                            txtfuncelu.Clear();
                            txtfuncelu1.Clear();
                            txtfunfone.Clear();
                            txtfunsala.Clear();
                            cmbdepto.SelectedIndex = 0;
                            cmbhorario.SelectedIndex = 0;
                            txtfunnome.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void ConsultaFunc(FbDataReader dr)
        {
            txtfuncodi.Text = dr["FUNCODI"].ToString();
            txtfunnome.Text = dr["FUNNOME"].ToString();
            txtfunsala.Text = dr["FUNSALA"].ToString();
            txtfuncpf.Text = dr["FUNCPF"].ToString();
            txtfunrg.Text = dr["FUNRG"].ToString();
            txtfunfone.Text = dr["FUNFONE"].ToString();
            txtfuncelu.Text = dr["FUNCELU"].ToString();
            txtfunume.Text = dr["FUNNUME"].ToString();
            txtfuncelu1.Text = dr["FUNCEL1"].ToString();
            txtfundtna.Text = dr["FUNDTNA"].ToString();
            int i = 0;
            for (i = 0; i <= this.cmbdepto.Items.Count - 1; i++) {
                this.cmbdepto.SelectedIndex = i;

                if (this.cmbdepto.SelectedValue.ToString() == dr["DEPTOCODI"].ToString()) {
                    break;
                }
            }

            for (i = 0; i <= this.cmbende.Items.Count - 1; i++) {
                this.cmbende.SelectedIndex = i;

                if (this.cmbende.SelectedValue.ToString() == dr["ENDCEP"].ToString()) {
                    break;
                }
            }

            for (i = 0; i <= this.cmbhorario.Items.Count - 1; i++) {
                this.cmbhorario.SelectedIndex = i;

                if (this.cmbhorario.SelectedValue.ToString() == dr["HORCODI"].ToString()) {
                    break;
                }
            }
        }

        private void txtfuncodi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmfuncionario_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvfuncionario_DoubleClick_1(object sender, EventArgs e) {
            if (dgvfuncionario.RowCount > 0 && dgvfuncionario.SelectedRows.Count == 1) {
                int paiCodigo = Convert.ToInt32(dgvfuncionario.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM FUNCIONARIO "
                           + "WHERE FUNCODI = " + paiCodigo;
                try {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read()) {
                        ConsultaFunc(dr);
                        txtfuncodi.Text = dr["FUNCODI"].ToString();
                        txtfunnome.Text = dr["FUNNOME"].ToString();
                        txtfunsala.Text = dr["FUNSALA"].ToString();
                        txtfundtna.Text = dr["FUNDTNA"].ToString();
                        txtfuncpf.Text = dr["FUNCPF"].ToString();
                        txtfunrg.Text = dr["FUNRG"].ToString();
                        txtfunfone.Text = dr["FUNFONE"].ToString();
                        txtfuncelu.Text = dr["FUNCELU"].ToString();
                        txtfuncelu1.Text = dr["FUNCEL1"].ToString();
                        txtfunume.Text = dr["FUNNUME"].ToString();
                        tbcfuncionario.SelectedIndex = 1;
                        txtfuncodi.Focus();
                    }
                }
                finally {
                    Conexao.Active(false);
                }

            }
            else {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void tbcfuncionario_Selected(object sender, TabControlEventArgs e)
        {
            if(tbcfuncionario.SelectedIndex == 0)
            {
                DgvDados();
            }
        }
    }
}
