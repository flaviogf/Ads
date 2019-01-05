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
    public partial class frmramo : Form
    {
        public frmramo()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpar()
        {
            txtramcodi.Clear();
            txtramnome.Clear();
            txtramobse.Clear();
            btnincluir.Enabled = false;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
        }

        private void frmramo_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void carregarDados()
        {
            try
            {
                Conexao.Active(true);

                string sql = "SELECT * FROM RAMO";

                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter(sql, Conexao.FbCnn);

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    table.Columns["RAMCODI"].ColumnName = "Código";
                    table.Columns["RAMNOME"].ColumnName = "Nome";
                    table.Columns["RAMOBSE"].ColumnName = "Observação";

                    dgvramo.DataSource = table;
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

        private void dgvramo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvramo.Rows.Count > 0 && dgvramo.SelectedRows.Count == 1)
            {
                try
                {
                    Conexao.Active(true);

                    int codigo = (int)dgvramo.SelectedRows[0].Cells[0].Value;
                    string sql = String.Format("SELECT * FROM RAMO WHERE RAMCODI = {0}", codigo);

                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtramcodi.Text = dr["RAMCODI"].ToString();
                        txtramnome.Text = dr["RAMNOME"].ToString();
                        txtramobse.Text = dr["RAMOBSE"].ToString();
                        tbcramo.SelectedIndex = 1;
                        txtramcodi.Focus();
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

        private void ctrlIncluir()
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
        }

        private void ctrlUpdate()
        {
            btnincluir.Enabled = false;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;
        }

        private void txtramcodi_Leave(object sender, EventArgs e)
        {
            if (txtramcodi.Text != "")
            {
                try
                {
                    Conexao.Active(true);

                    string sql = String.Format("SELECT * FROM RAMO WHERE RAMCODI = {0}", txtramcodi.Text);

                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtramcodi.Text = dr["RAMCODI"].ToString();
                        txtramnome.Text = dr["RAMNOME"].ToString();
                        txtramobse.Text = dr["RAMOBSE"].ToString();
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
                            string aux = txtramcodi.Text;
                            limpar();
                            txtramcodi.Text = aux;
                            txtramnome.Focus();
                            ctrlIncluir();
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
        }

        private void frmramo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);

                string sql = String.Format("INSERT INTO RAMO VALUES({0}, '{1}', '{2}')", txtramcodi.Text, txtramnome.Text, txtramobse.Text);

                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();

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

        private void tbcramo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcramo.SelectedIndex == 0)
            {
                carregarDados();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);

                string sql = String.Format("UPDATE RAMO SET RAMCODI = {0}, RAMNOME = '{1}', RAMOBSE = '{2}' WHERE RAMCODI = {0}", txtramcodi.Text, txtramnome.Text, txtramobse.Text);

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

                string sql = String.Format("DELETE FROM RAMO WHERE RAMCODI = {0}", txtramcodi.Text);

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
    }
}
