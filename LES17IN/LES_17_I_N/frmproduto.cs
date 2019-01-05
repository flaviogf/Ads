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
    public partial class frmproduto : Form
    {
        public frmproduto()
        {
            InitializeComponent();
        }

        private void frmproduto_Load(object sender, EventArgs e)
        {
            carregarDados();
            carregarGrupos();
            carregarUnidades();
            limpar();
        }

        private void carregarDados()
        {
            try
            {
                Conexao.Active(true);
                DataTable table = new DataTable();
                string sql = String.Format("SELECT P.PROCODI, P.PRONOME, P.PROCUST, P.PROMARG, P.PROVEND, P.PROESTO, P.PROLOCA, P.PROOBS, G.GRUCODI, G.GRUNOME, U.UNICODI, U.UNINOME FROM PRODUTO P INNER JOIN GRUPO G ON P.GRUCODI = G.GRUCODI INNER JOIN UNIDADE U ON U.UNICODI = P.UNICODI");
                FbDataAdapter adapter = new FbDataAdapter(sql, Conexao.FbCnn);

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    table.Columns["PROCODI"].ColumnName = "Código";
                    table.Columns["PRONOME"].ColumnName = "Nome";
                    table.Columns["PROCUST"].ColumnName = "Custo";
                    table.Columns["PROMARG"].ColumnName = "Margem";
                    table.Columns["PROVEND"].ColumnName = "Venda";
                    table.Columns["PROESTO"].ColumnName = "Estoque";
                    table.Columns["PROLOCA"].ColumnName = "Localização";
                    table.Columns["PROOBS"].ColumnName = "Observação";
                    table.Columns["GRUCODI"].ColumnName = "Codigo do grupo";
                    table.Columns["GRUNOME"].ColumnName = "Nome do grupo";
                    table.Columns["UNICODI"].ColumnName = "Codigo da unidade";
                    table.Columns["UNINOME"].ColumnName = "Nome da unidade";
                    dgvproduto.DataSource = table;
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

        private void dgvproduto_DoubleClick(object sender, EventArgs e)
        {
            if (dgvproduto.Rows.Count > 0 && dgvproduto.SelectedRows.Count == 1)
            {
                try
                {
                    Conexao.Active(true);

                    int codigo = (int)dgvproduto.SelectedRows[0].Cells[0].Value;
                    string sql = String.Format("SELECT P.PROCODI, P.PRONOME, P.PROCUST, P.PROMARG, P.PROVEND, P.PROESTO, P.PROLOCA, P.PROOBS, G.GRUCODI, G.GRUNOME, U.UNICODI, U.UNINOME FROM PRODUTO P INNER JOIN GRUPO G ON P.GRUCODI = G.GRUCODI INNER JOIN UNIDADE U ON U.UNICODI = P.UNICODI WHERE PROCODI = {0}", codigo);

                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtprocodi.Text = dr["PROCODI"].ToString();
                        txtpronome.Text = dr["PRONOME"].ToString();
                        txtprocust.Text = dr["PROCUST"].ToString();
                        txtpromarg.Text = dr["PROMARG"].ToString();
                        txtprovend.Text = dr["PROVEND"].ToString();
                        txtproesto.Text = dr["PROESTO"].ToString();
                        txtproloca.Text = dr["PROLOCA"].ToString();
                        txtproobs.Text = dr["PROOBS"].ToString();
                        cmbgrupo.SelectedIndex = cmbgrupo.FindString(dr["GRUNOME"].ToString());
                        cmbunidade.SelectedIndex = cmbunidade.FindString(dr["UNINOME"].ToString());
                        tbcproduto.SelectedIndex = 1;
                        txtprocodi.Focus();
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

        private void carregarGrupos()
        {
            try
            {
                Conexao.Active(true);
                string sql = "SELECT * FROM GRUPO";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> grupos = new Dictionary<string, string>();

                while (dr.Read())
                {
                    grupos.Add(dr["GRUCODI"].ToString(), dr["GRUNOME"].ToString());
                }

                cmbgrupo.DataSource = new BindingSource(grupos, null);
                cmbgrupo.DisplayMember = "value";
                cmbgrupo.ValueMember = "key";
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

        private void carregarUnidades()
        {
            try
            {
                Conexao.Active(true);
                string sql = "SELECT * FROM UNIDADE";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> unidades = new Dictionary<string, string>();

                while (dr.Read())
                {
                    unidades.Add(dr["UNICODI"].ToString(), dr["UNINOME"].ToString());
                }

                cmbunidade.DataSource = new BindingSource(unidades, null);
                cmbunidade.DisplayMember = "value";
                cmbunidade.ValueMember = "key";
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

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string sql = String.Format("INSERT INTO PRODUTO VALUES({0}, '{1}', {2}, {3}, {4}, {5}, '{6}', '{7}', {8}, {9})", txtprocodi.Text, txtpronome.Text, txtprocust.Text, txtpromarg.Text, txtprovend.Text, txtproesto.Text, txtproloca.Text, txtproobs.Text, cmbgrupo.SelectedValue, cmbunidade.SelectedValue);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluido com sucesso!");
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

        private void limpar()
        {
            txtprocodi.Clear();
            txtpronome.Clear();
            txtprocust.Clear();
            txtpromarg.Clear();
            txtprovend.Clear();
            txtproesto.Clear();
            txtproloca.Clear();
            txtproobs.Clear();
            cmbgrupo.SelectedIndex = -1;
            cmbunidade.SelectedIndex = -1;
            btnincluir.Enabled = false;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
        }

        private void tbcproduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcproduto.SelectedIndex == 0)
            {
                carregarDados();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string sql = String.Format("UPDATE PRODUTO SET PROCODI = {0}, PRONOME = '{1}', PROCUST = {2}, PROMARG = {3}, PROVEND = {4}, PROESTO = {5}, PROLOCA = '{6}', PROOBS = '{7}', GRUCODI = {8}, UNICODI = {9} WHERE PROCODI = {0}", txtprocodi.Text, txtpronome.Text, txtprocust.Text, txtpromarg.Text, txtprovend.Text, txtproesto.Text, txtproloca.Text, txtproobs.Text, cmbgrupo.SelectedValue, cmbunidade.SelectedValue);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro atualizado com sucesso !!!");
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
                string sql = String.Format("DELETE FROM PRODUTO WHERE PROCODI = {0}", txtprocodi.Text);
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Resgistro excluido com sucesso");
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

        private void txtprocodi_Leave(object sender, EventArgs e)
        {
            if (txtprocodi.Text != "")
            {
                try
                {
                    Conexao.Active(true);

                    string sql = String.Format("SELECT P.PROCODI, P.PRONOME, P.PROCUST, P.PROMARG, P.PROVEND, P.PROESTO, P.PROLOCA, P.PROOBS, G.GRUCODI, G.GRUNOME, U.UNICODI, U.UNINOME FROM PRODUTO P INNER JOIN GRUPO G ON P.GRUCODI = G.GRUCODI INNER JOIN UNIDADE U ON U.UNICODI = P.UNICODI WHERE PROCODI = {0}", txtprocodi.Text);

                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtprocodi.Text = dr["PROCODI"].ToString();
                        txtpronome.Text = dr["PRONOME"].ToString();
                        txtprocust.Text = dr["PROCUST"].ToString();
                        txtpromarg.Text = dr["PROMARG"].ToString();
                        txtprovend.Text = dr["PROVEND"].ToString();
                        txtproesto.Text = dr["PROESTO"].ToString();
                        txtproloca.Text = dr["PROLOCA"].ToString();
                        txtproobs.Text = dr["PROOBS"].ToString();
                        cmbgrupo.SelectedIndex = cmbgrupo.FindString(dr["GRUNOME"].ToString());
                        cmbunidade.SelectedIndex = cmbunidade.FindString(dr["UNINOME"].ToString());
                        ctrlUpdate();
                    }
                    else
                    {
                        bool resposta = MessageBox.Show("Registro não encontrado \n deseja cadastra-lo", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
                        if (resposta)
                        {
                            limpar();
                        }
                        else
                        {
                            string aux = txtprocodi.Text;
                            limpar();
                            txtprocodi.Text = aux;
                            txtpronome.Focus();
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

        private void frmproduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
