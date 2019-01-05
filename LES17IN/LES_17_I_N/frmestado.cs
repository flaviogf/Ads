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
    public partial class frmestado : Form {
        public frmestado() {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e) {
            string strIncluir = "INSERT INTO ESTADO(ESTCODI, ESTUF, ESTNOME, ESTICMS, PAICODI)"
                                + " VALUES("
                                + txtestcodi.Text + ", '" + txtxestuf.Text + "', '" 
                                + txtestnome.Text + "', '" + txtesticms.Text + "', "
                                + Convert.ToInt32(cbopaises.SelectedValue)
                                + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtestcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btngravar_Click(object sender, EventArgs e) {
            string strAlterar = "UPDATE ESTADO"
            + " SET ESTCODI = " + txtestcodi.Text + ", "
            + " ESTUF = '" + txtxestuf.Text + "', "
            + " ESTNOME = '" + txtestnome.Text + "', "
            + " ESTICMS = '" + txtesticms.Text + "', "
            + " PAICODI = " + Convert.ToInt32(cbopaises.SelectedValue)
            + " WHERE ESTCODI = '" + txtestcodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtestcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e) {
            string strDelete = "DELETE FROM ESTADO WHERE ESTCODI = " + txtestcodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtestcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void frmestado_KeyDown(object sender, KeyEventArgs e)
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
            txtestcodi.Clear();
            txtesticms.Clear();
            txtestnome.Clear();
            txtxestuf.Clear();
            cbopaises.SelectedIndex = -1;
            txtestcodi.Focus();
        }

        private void txtestcodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtestcodi.Text != "")
            {
                string strConsulta = "SELECT ESTCODI, ESTUF, ESTNOME, ESTICMS, PAICODI FROM ESTADO WHERE ESTCODI = " +
                txtestcodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultarEstado(dr);
                        txtesticms.Focus();
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
                            txtxestuf.Text = "";
                            txtestnome.Text = "";
                            txtesticms.Text = "";
                            txtxestuf.Text = "";
                            txtesticms.Focus();
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

        private void ConsultarEstado(FbDataReader dr)
        {
            txtestcodi.Text = dr["ESTCODI"].ToString();
            txtxestuf.Text = dr["ESTUF"].ToString();
            txtestnome.Text = dr["ESTNOME"].ToString();
            txtesticms.Text = dr["ESTICMS"].ToString();
            int i = 0;
            for (i = 0; i <= this.cbopaises.Items.Count - 1; i++)
            {
                this.cbopaises.SelectedIndex = i;

                if (this.cbopaises.SelectedValue.ToString() == dr["PAICODI"].ToString())
                {
                    return;
                }
            }
        }

        private void frmestado_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarPaises();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM ESTADO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvEstado.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvEstado_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEstado.RowCount > 0 && dgvEstado.SelectedRows.Count == 1)
            {
                int estCodigo = Convert.ToInt32(dgvEstado.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM ESTADO "
                           + "WHERE ESTCODI = " + estCodigo;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtestcodi.Text = dr["ESTCODI"].ToString();
                        txtxestuf.Text = dr["ESTUF"].ToString();
                        txtestnome.Text = dr["ESTNOME"].ToString();
                        txtesticms.Text = dr["ESTICMS"].ToString();
                        tbcestado.SelectedIndex = 1;
                        txtesticms.Focus();
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

        private void tbcestado_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcestado.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

        private void carregarPaises()
        {
            this.cbopaises.Items.Clear();

            string s = "SELECT * FROM PAIS";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["PAINOME"].ToString(), Convert.ToInt32(r["PAICODI"]));

            }
            this.cbopaises.DataSource = new BindingSource(p, null);
            this.cbopaises.DisplayMember = "key";
            this.cbopaises.ValueMember = "value";
        }

        private void SelecionarItemCombo(int paicodi)
        {
            int i = 0;
            for (i = 0; i <= this.cbopaises.Items.Count - 1; i++)
            {
                this.cbopaises.SelectedIndex = i;
                if (Convert.ToInt32(this.cbopaises.SelectedValue) == paicodi)
                {
                    return;
                }
            }
        }
    }
}
