using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_17_I_N {
    public partial class frmendereco : Form {
        public frmendereco() {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO ENDERECO(ENDCEP, ENDENDE, BAICODI)"
                                + " VALUES("
                                + txtendcep.Text + ", '" + txtendende.Text + "', "
                                + Convert.ToInt32(cbobairros.SelectedValue)
                                + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtendcep.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btngravar_Click(object sender, EventArgs e) {
            string strAlterar = "UPDATE ENDERECO"
            + " SET ENDCEP = " + txtendcep.Text + ", "
            + " ENDENDE = '" + txtendende.Text + "', "
            + " BAICODI = " + Convert.ToInt32(cbobairros.SelectedValue)
            + " WHERE ENDCEP = '" + txtendcep.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtendcep.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e) {
            string strDelete = "DELETE FROM ENDERECO WHERE ENDCEP = " + txtendcep.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtendcep.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void frmendereco_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) {
            this.Close();
        }
        private void limpar() {
            txtendcep.Clear();
            txtendende.Clear();
            cbobairros.SelectedIndex = -1;
            txtendcep.Focus();
        }

        private void txtendcep_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtendcep.Text != "")
            {
                string strConsulta = "SELECT ENDCEP, ENDENDE, BAICODI FROM ENDERECO WHERE ENDCEP = " +
                txtendcep.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultarEndereco(dr);
                        txtendende.Focus();
                        btnincluir.Enabled = false;
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
                            txtendende.Text = "";
                            txtendende.Focus();
                            btngravar.Enabled = false;
                            btnexcluir.Enabled = false;
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

        private void ConsultarEndereco(FbDataReader dr)
        {
            txtendcep.Text = dr["ENDCEP"].ToString();
            txtendende.Text = dr["ENDENDE"].ToString();
            int i = 0;
            for (i = 0; i <= this.cbobairros.Items.Count - 1; i++)
            {
                this.cbobairros.SelectedIndex = i;

                if (this.cbobairros.SelectedValue.ToString() == dr["BAICODI"].ToString())
                {
                    return;
                }
            }
        }

        private void frmendereco_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarBairros();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM ENDERECO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvendereco.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvendereco_DoubleClick(object sender, EventArgs e)
        {
            if (dgvendereco.RowCount > 0 && dgvendereco.SelectedRows.Count == 1)
            {
                int endCep = Convert.ToInt32(dgvendereco.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM ENDERECO "
                           + "WHERE ENDCEP = " + endCep;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtendcep.Text = dr["ENDCEP"].ToString();
                        txtendende.Text = dr["ENDENDE"].ToString();
                        tbcendereco.SelectedIndex = 1;
                        txtendende.Focus();
                    }
                }
                finally
                {
                    Conexao.Active(false);
                }

            }
            else
            {
                MessageBox.Show("Nenhum registro selecionado!");
            }
        }

        private void tbcendereco_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcendereco.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

        private void carregarBairros()
        {
            this.cbobairros.Items.Clear();

            string s = "SELECT * FROM BAIRRO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["BAINOME"].ToString(), Convert.ToInt32(r["BAICODI"]));

            }
            this.cbobairros.DataSource = new BindingSource(p, null);
            this.cbobairros.DisplayMember = "key";
            this.cbobairros.ValueMember = "value";
        }

        private void SelecionarItemCombo(int baicodi)
        {
            int i = 0;
            for (i = 0; i <= this.cbobairros.Items.Count - 1; i++)
            {
                this.cbobairros.SelectedIndex = i;
                if (Convert.ToInt32(this.cbobairros.SelectedValue) == baicodi)
                {
                    return;
                }
            }
        }
    }
}
