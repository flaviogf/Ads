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
    public partial class frmbairro : Form {
        public frmbairro() {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO BAIRRO(BAICODI, BAINOME, MUNCODI)"
                                + " VALUES("
                                + txtbaicodi.Text + ", '" + txtbainome.Text + "', "
                                + Convert.ToInt32(cbomunicipios.SelectedValue)
                                + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtbaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btngravar_Click(object sender, EventArgs e) {
            string strAlterar = "UPDATE BAIRRO"
            + " SET BAICODI = " + txtbaicodi.Text + ", "
            + " BAINOME = '" + txtbainome.Text + "', "
            + " MUNCODI = " + Convert.ToInt32(cbomunicipios.SelectedValue)
            + " WHERE BAICODI = '" + txtbaicodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtbaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e) {
            string strDelete = "DELETE FROM BAIRRO WHERE BAICODI = " + txtbaicodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtbaicodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void frmbairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void limpar() {
            txtbaicodi.Clear();
            txtbainome.Clear();
            cbomunicipios.SelectedIndex = -1;
            txtbaicodi.Focus();
        }

        private void txtbaicodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtbaicodi.Text != "")
            {
                string strConsulta = "SELECT BAICODI, BAINOME, MUNCODI FROM BAIRRO WHERE BAICODI = " +
                txtbaicodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultarBairro(dr);
                        txtbainome.Focus();
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
                            txtbainome.Text = "";
                            txtbainome.Focus();
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

        private void ConsultarBairro(FbDataReader dr)
        {
            txtbaicodi.Text = dr["BAICODI"].ToString();
            txtbainome.Text = dr["BAINOME"].ToString();
            int i = 0;
            for (i = 0; i <= this.cbomunicipios.Items.Count - 1; i++)
            {
                this.cbomunicipios.SelectedIndex = i;

                if (this.cbomunicipios.SelectedValue.ToString() == dr["MUNCODI"].ToString())
                {
                    return;
                }
            }
        }

        private void frmbairro_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarMunicipio();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM BAIRRO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvbairro.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvbairro_DoubleClick(object sender, EventArgs e) {
            if (dgvbairro.RowCount > 0 && dgvbairro.SelectedRows.Count == 1) {
                int baiCodigo = Convert.ToInt32(dgvbairro.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM BAIRRO "
                           + "WHERE BAICODI = " + baiCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtbaicodi.Text = dr["BAICODI"].ToString();
                        txtbainome.Text = dr["BAINOME"].ToString();
                        tbcbairro.SelectedIndex = 1;
                        txtbainome.Focus();
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

        private void tbcbairro_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcbairro.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

        private void carregarMunicipio()
        {
            this.cbomunicipios.Items.Clear();

            string s = "SELECT * FROM MUNICIPIO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["MUNNOME"].ToString(), Convert.ToInt32(r["MUNCODI"]));

            }
            this.cbomunicipios.DataSource = new BindingSource(p, null);
            this.cbomunicipios.DisplayMember = "key";
            this.cbomunicipios.ValueMember = "value";
        }

        private void SelecionarItemCombo(int muncodi)
        {
            int i = 0;
            for (i = 0; i <= this.cbomunicipios.Items.Count - 1; i++)
            {
                this.cbomunicipios.SelectedIndex = i;
                if (Convert.ToInt32(this.cbomunicipios.SelectedValue) == muncodi)
                {
                    return;
                }
            }
        }
    }
}
