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
    public partial class frmgrupo : Form
    {
        public frmgrupo()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string sql = String.Format("INSERT INTO GRUPO (GRUCODI, GRUNOME) VALUES ({0}, '{1}')", txtgrucodi.Text, txtgrunome.Text);
            Conexao.Active(true);
            try
            {
                FbCommand cmb = new FbCommand(sql, Conexao.FbCnn);
                cmb.ExecuteNonQuery();
                MessageBox.Show("Registro incluido com sucesso");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void limpar()
        {
            txtgrucodi.Clear();
            txtgrunome.Clear();
            txtgrucodi.Focus();
            btnincluir.Enabled = false;
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string sql = String.Format("UPDATE GRUPO SET GRUCODI = {0}, GRUNOME = '{1}' WHERE GRUCODI = {0}", txtgrucodi.Text, txtgrunome.Text);
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso!!!");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string sql = String.Format("DELETE FROM GRUPO WHERE GRUCODI = {0}", txtgrucodi.Text);
            Conexao.Active(true);
            try
            {
                FbCommand cmb = new FbCommand(sql, Conexao.FbCnn);
                cmb.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso");
                limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtgrucodi_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            try
            {
                if (txtgrucodi.Text != "")
                {
                    try
                    {
                        string sql = String.Format("SELECT * FROM GRUPO WHERE GRUCODI = {0}", txtgrucodi.Text);
                        FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                        FbDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            txtgrucodi.Text = dr["GRUCODI"].ToString();
                            txtgrunome.Text = dr["GRUNOME"].ToString();
                            txtgrunome.Focus();
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
                                txtgrunome.Clear();
                                txtgrunome.Focus();
                                ctrlIncluir();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void frmgrupo_Load(object sender, EventArgs e)
        {
            carregarDados();
            limpar();
        }

        private void carregarDados()
        {
            Conexao.Active(true);
            try
            {
                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter("SELECT * FROM GRUPO", Conexao.FbCnn);

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    table.Columns["GRUCODI"].ColumnName = "Código";
                    table.Columns["GRUNOME"].ColumnName = "Nome";
                    dgvgrupo.DataSource = table;
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

        private void dgvgrupo_DoubleClick(object sender, EventArgs e)
        {
            if (dgvgrupo.Rows.Count > 0 && dgvgrupo.SelectedRows.Count == 1)
            {
                int codigo = (int)dgvgrupo.SelectedRows[0].Cells[0].Value;

                string sql = String.Format("SELECT * FROM GRUPO WHERE GRUCODI = {0}", codigo);

                Conexao.Active(true);

                try
                {
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtgrucodi.Text = dr["GRUCODI"].ToString();
                        txtgrunome.Text = dr["GRUNOME"].ToString();
                        tbcgrupo.SelectedIndex = 1;
                        txtgrucodi.Focus();
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

        private void tbcgrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcgrupo.SelectedIndex == 0)
            {
                carregarDados();
            }
        }

        private void frmgrupo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
