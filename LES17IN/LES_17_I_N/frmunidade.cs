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
    public partial class frmunidade : Form
    {
        public frmunidade()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlIncluir()
        {
            btnincluir.Enabled = true;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
        }

        private void ctrlUpdate()
        {
            btnincluir.Enabled = false;
            btnexcluir.Enabled = true;
            btngravar.Enabled = true;
        }

        private void limpar()
        {
            txtunicodi.Clear();
            txtuninome.Clear();
            txtunicodi.Focus();
            btnincluir.Enabled = false;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
        }

        private void frmunidade_Load(object sender, EventArgs e)
        {
            carregarDados();
            limpar();
        }

        private void carregarDados()
        {
            try
            {
                Conexao.Active(true);
                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM UNIDADE", Conexao.FbCnn);

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    table.Columns["UNICODI"].ColumnName = "Código";
                    table.Columns["UNINOME"].ColumnName = "Nome";
                    dgvunidade.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string sql = String.Format("INSERT INTO UNIDADE(UNICODI, UNINOME) VALUES({0}, '{1}')", txtunicodi.Text, txtuninome.Text);
                FbCommand cmb = new FbCommand(sql, Conexao.FbCnn);
                cmb.ExecuteNonQuery();
                MessageBox.Show("Registro incluido com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void txtunicodi_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtunicodi.Text != "")
                {
                    Conexao.Active(true);
                    string sql = String.Format("SELECT * FROM UNIDADE WHERE UNICODI = {0}", txtunicodi.Text);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtunicodi.Text = dr["UNICODI"].ToString();
                        txtuninome.Text = dr["UNINOME"].ToString();
                        txtuninome.Focus();
                        ctrlUpdate();
                    }
                    else
                    {
                        bool resposta = MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
                        if (resposta)
                        {
                            limpar();
                        }
                        else
                        {
                            ctrlIncluir();
                            txtuninome.Clear();
                            txtuninome.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void tbcunidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcunidade.SelectedIndex == 0)
            {
                carregarDados();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string sql = String.Format("UPDATE UNIDADE SET UNICODI = {0}, UNINOME = '{1}' WHERE UNICODI = {0}", txtunicodi.Text, txtuninome.Text);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string sql = String.Format("DELETE FROM UNIDADE WHERE UNICODI = {0}", txtunicodi.Text);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluido com sucesso");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void frmunidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void dgvunidade_DoubleClick(object sender, EventArgs e)
        {

            if (dgvunidade.Rows.Count > 0 && dgvunidade.SelectedRows.Count == 1)
            {
                try
                {
                    Conexao.Active(true);

                    int codigo = (int)dgvunidade.SelectedRows[0].Cells[0].Value;
                    string sql = String.Format("SELECT * FROM UNIDADE WHERE UNICODI = {0}", codigo);

                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtunicodi.Text = dr["UNICODI"].ToString();
                        txtuninome.Text = dr["UNINOME"].ToString();
                        tbcunidade.SelectedIndex = 1;
                        txtunicodi.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Active(false);
                }
            }
        }
    }
}
