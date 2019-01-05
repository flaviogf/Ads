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
    public partial class frmmunicipio : Form {
        public frmmunicipio() {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO MUNICIPIO(MUNCODI, MUNNOME, ESTCODI)"
                                + " VALUES("
                                + txtmuncodi.Text + ", '"
                                + txtmunnome.Text + "', "
                                + Convert.ToInt32(cboestados.SelectedValue)
                                + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtmuncodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btngravar_Click(object sender, EventArgs e) {
            string strAlterar = "UPDATE MUNICIPIO"
            + " SET MUNCODI = " + txtmuncodi.Text + ", "
            + " MUNNOME = '" + txtmunnome.Text + "', "
            + " ESTCODI = " + Convert.ToInt32(cboestados.SelectedValue)
            + " WHERE MUNCODI = '" + txtmuncodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtmuncodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e) {
            string strDelete = "DELETE FROM MUNICIPIO WHERE MUNCODI = " + txtmuncodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtmuncodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void frmmunicipio_KeyDown(object sender, KeyEventArgs e)
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
            txtmuncodi.Clear();
            txtmunnome.Clear();
            cboestados.SelectedIndex = -1;
            txtmuncodi.Focus();
        }

        private void txtmuncodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtmuncodi.Text != "")
            {
                string strConsulta = "SELECT MUNCODI, MUNNOME, ESTCODI FROM MUNICIPIO WHERE MUNCODI = " +
                txtmuncodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultarMunicipio(dr);
                        txtmunnome.Focus();
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
                            txtmunnome.Text = "";
                            txtmunnome.Focus();
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

        private void ConsultarMunicipio(FbDataReader dr)
        {
            txtmuncodi.Text = dr["MUNCODI"].ToString();
            txtmunnome.Text = dr["MUNNOME"].ToString();
            int i = 0;
            for (i = 0; i <= this.cboestados.Items.Count - 1; i++)
            {
                this.cboestados.SelectedIndex = i;

                if (this.cboestados.SelectedValue.ToString() == dr["ESTCODI"].ToString())
                {
                    return;
                }
            }
        }

        private void frmmunicipio_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarEstados();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM MUNICIPIO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvMunicipio.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvMunicipio_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMunicipio.RowCount > 0 && dgvMunicipio.SelectedRows.Count == 1)
            {
                int munCodigo = Convert.ToInt32(dgvMunicipio.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM MUNICIPIO "
                           + "WHERE MUNCODI = " + munCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtmuncodi.Text = dr["MUNCODI"].ToString();
                        txtmunnome.Text = dr["MUNNOME"].ToString();
                        tbcmunicipio.SelectedIndex = 1;
                        txtmunnome.Focus();
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

        private void tbcmunicipio_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcmunicipio.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void carregarEstados()
        {
            this.cboestados.Items.Clear();

            string s = "SELECT * FROM ESTADO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["ESTNOME"].ToString(), Convert.ToInt32(r["ESTCODI"]));

            }
            this.cboestados.DataSource = new BindingSource(p, null);
            this.cboestados.DisplayMember = "key";
            this.cboestados.ValueMember = "value";
        }

        private void SelecionarItemCombo(int estcodi)
        {
            int i = 0;
            for (i = 0; i <= this.cboestados.Items.Count - 1; i++)
            {
                this.cboestados.SelectedIndex = i;
                if (Convert.ToInt32(this.cboestados.SelectedValue) == estcodi)
                {
                    return;
                }
            }
        }
    }
}
