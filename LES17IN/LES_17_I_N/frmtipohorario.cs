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
    public partial class frmtipohorario : Form
    {
        public frmtipohorario()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO TIPOHORARIO"
                    + " VALUES("
                    + txtthocodi.Text + ", '" + txtthonome.Text + "' "
                    + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtthocodi.Focus();
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
            string strAlterar = "UPDATE TIPOHORARIO"
            + " SET THOCODI = " + txtthocodi.Text + ", "
            + " THONOME = '" + txtthonome.Text + "' "
            + " WHERE THOCODI = '" + txtthocodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtthocodi.Focus();
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
            string strDelete = "DELETE FROM TIPOHORARIO WHERE THOCODI = " + txtthocodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtthocodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void frmtipohorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpar()
        {
            txtthocodi.Clear();
            txtthonome.Clear();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM TIPOHORARIO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvtipohorario.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void frmtipohorario_Load(object sender, EventArgs e)
        {
            DgvDados();
        }

        private void dgvtipohorario_DoubleClick(object sender, EventArgs e)
        {
            if (dgvtipohorario.RowCount > 0 && dgvtipohorario.SelectedRows.Count == 1)
            {
                int thoCodi = Convert.ToInt32(dgvtipohorario.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM TIPOHORARIO "
                           + "WHERE THOCODI = " + thoCodi;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtthocodi.Text = dr["THOCODI"].ToString();
                        txtthonome.Text = dr["THONOME"].ToString();
                        tbctipohorarios.SelectedIndex = 1;
                        txtthonome.Focus();
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

        private void tbctipohorarios_Selected(object sender, TabControlEventArgs e)
        {
            if (tbctipohorarios.SelectedIndex == 0)//tbclistagempais.SelectedTab == tbplistagem
            {
                DgvDados();
            }
        }

        private void txtthocodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtthocodi.Text != "")
            {
                string strConsulta = "SELECT THOCODI, THONOME FROM TIPOHORARIO WHERE THOCODI = " +
                txtthocodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaPais(dr);
                        txtthonome.Focus();
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
                            txtthonome.Text = "";
                            txtthonome.Focus();
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

        private void ConsultaPais(FbDataReader dr)
        {
            txtthocodi.Text = dr["THOCODI"].ToString();
            txtthonome.Text = dr["THONOME"].ToString();
        }
    }
}
