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

namespace LES_17_I_N
{
    public partial class frmdepto : Form
    {
        public frmdepto()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO DEPTO"
                    + " VALUES("
                    + txtdepcodi.Text + ", '" + txtdepnome.Text + "' "
                    + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtdepcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE DEPTO"
            + " SET DEPCODI = " + txtdepcodi.Text + ", "
            + " DEPNOME = '" + txtdepnome.Text + "' "
            + " WHERE DEPCODI = '" + txtdepcodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtdepcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM DEPTO WHERE DEPCODI = " + txtdepcodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtdepcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpar()
        {
            txtdepcodi.Clear();
            txtdepnome.Clear();
        }

        private void txtdepcodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtdepcodi.Text != "")
            {
                string strConsulta = "SELECT * FROM DEPTO WHERE DEPCODI = " +
                txtdepcodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaDepto(dr);
                        txtdepnome.Focus();
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
                            txtdepnome.Text = "";
                            txtdepnome.Focus();
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
        private void ConsultaDepto(FbDataReader dr)
        {
            txtdepcodi.Text = dr["DEPCODI"].ToString();
            txtdepnome.Text = dr["DEPNOME"].ToString();
        }

        private void frmdepto_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void DgvDados()
        {
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM DEPTO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvdeptos.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvdeptos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvdeptos.RowCount > 0 && dgvdeptos.SelectedRows.Count == 1)
            {
                int depCodi = Convert.ToInt32(dgvdeptos.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM DEPTO "
                           + "WHERE DEPCODI = " + depCodi;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtdepcodi.Text = dr["DEPCODI"].ToString();
                        txtdepnome.Text = dr["DEPNOME"].ToString();
                        tbcdeptos.SelectedIndex = 1;
                        txtdepnome.Focus();
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

        private void tbcdeptos_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcdeptos.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void frmdepto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
