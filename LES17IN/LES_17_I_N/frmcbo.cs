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
    public partial class frmcbo : Form
    {
        public frmcbo()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO CBO"
            + " VALUES("
            + txtcbocodi.Text + ", '" + txtcbonome.Text + "' "
            + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtcbocodi.Focus();
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
            string strAlterar = "UPDATE CBO"
            + " SET CBOCODI = " + txtcbocodi.Text + ", "
            + " CBONOME = '" + txtcbonome.Text + "' "
            + " WHERE CBOCODI = '" + txtcbocodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtcbocodi.Focus();
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
            string strDelete = "DELETE FROM CBO WHERE CBOCODI = " + txtcbocodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtcbocodi.Focus();
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

        private void frmcbo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void limpar()
        {
            txtcbocodi.Clear();
            txtcbonome.Clear();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM CBO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvcbo.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void frmcbo_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvcbo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvcbo.RowCount > 0 && dgvcbo.SelectedRows.Count == 1)
            {
                int cboCodi = Convert.ToInt32(dgvcbo.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM CBO "
                           + "WHERE CBOCODI = " + cboCodi;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtcbocodi.Text = dr["CBOCODI"].ToString();
                        txtcbonome.Text = dr["CBONOME"].ToString();
                        tbccbo.SelectedIndex = 1;
                        txtcbonome.Focus();
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

        private void tbccbo_Selected(object sender, TabControlEventArgs e)
        {
            if (tbccbo.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void txtcbocodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtcbocodi.Text != "")
            {
                string strConsulta = "SELECT * FROM CBO WHERE CBOCODI = " +
                txtcbocodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        consultaCbo(dr);
                        txtcbonome.Focus();
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
                            txtcbonome.Text = "";
                            txtcbonome.Focus();
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

        private void consultaCbo(FbDataReader dr)
        {
            txtcbocodi.Text = dr["CBOCODI"].ToString();
            txtcbonome.Text = dr["CBONOME"].ToString();
        }
    }
}
