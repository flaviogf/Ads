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
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }

        private void frmcliente_Load(object sender, EventArgs e)
        {
            limpar();
            carregarDados();
            carregarEndereco();
            carregarRamo();
        }

        private void limpar()
        {
            btnincluir.Enabled = false;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            txtclicodi.Focus();
            txtclicodi.Clear();
            txtclinome.Clear();
            txtclifant.Clear();
            txtcliapel.Clear();
            txtclilimi.Clear();
            dtpclidtin.ResetText();
            txtclicnpj.Clear();
            txtcliines.Clear();
            txtcliemai.Clear();
            txtclifone.Clear();
            txtclicelu.Clear();
            txtclicel1.Clear();
            txtclinume.Clear();
            txtclistat.Clear();
            cmbendereco.SelectedIndex = -1;
            cmbramo.SelectedIndex = -1;
        }

        private void carregarDados()
        {
            try
            {
                Conexao.Active(true);

                string sql = "SELECT C.clicodi, C.clinome, C.clifant, C.cliapel, C.clilimi, C.clidtin, C.clicnpj, C.cliines, C.cliemai, C.clifone, C.clicelu, C.clicel1, C.clinume, C.clistat, R.ramcodi, R.ramnome, E.endcep, E.endende FROM CLIENTE C INNER JOIN ENDERECO E ON C.ENDCEP = E.ENDCEP INNER JOIN RAMO R ON R.RAMCODI = C.RAMCODI";

                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter(sql, Conexao.FbCnn);

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    table.Columns["CLICODI"].ColumnName = "Código";
                    table.Columns["CLINOME"].ColumnName = "Nome";
                    table.Columns["CLIFANT"].ColumnName = "Nome fantasia";
                    table.Columns["CLIAPEL"].ColumnName = "Apelido";
                    table.Columns["CLILIMI"].ColumnName = "Limite";
                    table.Columns["CLIDTIN"].ColumnName = "Primeira compra";
                    table.Columns["CLICNPJ"].ColumnName = "CNPJ";
                    table.Columns["CLIINES"].ColumnName = "Inscrição estadual";
                    table.Columns["CLIEMAI"].ColumnName = "E-mail";
                    table.Columns["CLIFONE"].ColumnName = "Telefone";
                    table.Columns["CLICELU"].ColumnName = "Celular 1";
                    table.Columns["CLICEL1"].ColumnName = "Celular 2";
                    table.Columns["CLINUME"].ColumnName = "Numero da rua";
                    table.Columns["CLISTAT"].ColumnName = "Stat";
                    table.Columns["RAMCODI"].ColumnName = "Codigo ramo";
                    table.Columns["RAMNOME"].ColumnName = "Nome ramo";
                    table.Columns["ENDCEP"].ColumnName = "Cep";
                    table.Columns["ENDENDE"].ColumnName = "Endereço";

                    dgvcliente.DataSource = table;
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

        private void tbccliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbccliente.SelectedIndex == 0)
            {
                carregarDados();
            }
        }

        private void ctrlInserir()
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

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtclicodi_Leave(object sender, EventArgs e)
        {
            if (txtclicodi.Text != "")
            {
                try
                {
                    Conexao.Active(true);

                    string sql = $"SELECT C.clicodi, C.clinome, C.clifant, C.cliapel, C.clilimi, C.clidtin, C.clicnpj, C.cliines, C.cliemai, C.clifone, C.clicelu, C.clicel1, C.clinume, C.clistat, R.ramcodi, R.ramnome, E.endcep, E.endende FROM CLIENTE C INNER JOIN ENDERECO E ON C.ENDCEP = E.ENDCEP INNER JOIN RAMO R ON R.RAMCODI = C.RAMCODI WHERE CLICODI = {txtclicodi.Text}";

                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        setDados(dr);
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
                            string aux = txtclicodi.Text;
                            limpar();
                            txtclinome.Focus();
                            txtclicodi.Text = aux;
                            ctrlInserir();
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

        private void setDados(FbDataReader dr)
        {
            txtclinome.Focus();
            txtclinome.Text = dr["CLINOME"].ToString();
            txtclifant.Text = dr["CLIFANT"].ToString();
            txtcliapel.Text = dr["CLIAPEL"].ToString();
            txtclilimi.Text = dr["CLILIMI"].ToString();
            dtpclidtin.Value = DateTime.Parse(dr["CLIDTIN"].ToString());
            txtclicnpj.Text = dr["CLICNPJ"].ToString();
            txtcliines.Text = dr["CLIINES"].ToString();
            txtcliemai.Text = dr["CLIEMAI"].ToString();
            txtclifone.Text = dr["CLIFONE"].ToString();
            txtclicelu.Text = dr["CLICELU"].ToString();
            txtclicel1.Text = dr["CLICEL1"].ToString();
            txtclinume.Text = dr["CLINUME"].ToString();
            txtclistat.Text = dr["CLISTAT"].ToString();
            cmbendereco.SelectedIndex = cmbendereco.FindString(dr["ENDENDE"].ToString());
            cmbramo.SelectedIndex = cmbramo.FindString(dr["RAMNOME"].ToString());
            ctrlUpdate();
        }

        private void dgvcliente_DoubleClick(object sender, EventArgs e)
        {
            if (dgvcliente.Rows.Count > 0 && dgvcliente.SelectedRows.Count == 1)
            {
                try
                {
                    Conexao.Active(true);
                    int codigo = (int)dgvcliente.SelectedRows[0].Cells[0].Value;

                    string sql = $"SELECT C.clicodi, C.clinome, C.clifant, C.cliapel, C.clilimi, C.clidtin, C.clicnpj, C.cliines, C.cliemai, C.clifone, C.clicelu, C.clicel1, C.clinume, C.clistat, R.ramcodi, R.ramnome, E.endcep, E.endende FROM CLIENTE C INNER JOIN ENDERECO E ON C.ENDCEP = E.ENDCEP INNER JOIN RAMO R ON R.RAMCODI = C.RAMCODI WHERE C.CLICODI = {codigo}";

                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        txtclicodi.Text = dr["CLICODI"].ToString();
                        setDados(dr);
                        tbccliente.SelectedIndex = 1;
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

        private void carregarEndereco()
        {
            cmbendereco.Items.Clear();

            try
            {
                Conexao.Active(true);
                string sql = "SELECT * FROM ENDERECO";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> enderecos = new Dictionary<string, string>();

                while (dr.Read())
                {
                    enderecos.Add(dr["ENDCEP"].ToString(), dr["ENDENDE"].ToString());
                }

                cmbendereco.DataSource = new BindingSource(enderecos, null);
                cmbendereco.DisplayMember = "value";
                cmbendereco.ValueMember = "key";
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

        private void carregarRamo()
        {
            cmbramo.Items.Clear();

            try
            {
                Conexao.Active(true);
                string sql = "SELECT * FROM RAMO";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> ramos = new Dictionary<string, string>();

                while (dr.Read())
                {
                    ramos.Add(dr["RAMCODI"].ToString(), dr["RAMNOME"].ToString());
                }

                cmbramo.DataSource = new BindingSource(ramos, null);
                cmbramo.DisplayMember = "value";
                cmbramo.ValueMember = "key";
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

                string date = dtpclidtin.Text.Replace("/", ".");

                string sql = $"INSERT INTO CLIENTE VALUES({txtclicodi.Text}, '{txtclinome.Text}', '{txtclifant.Text}', {txtclilimi.Text}, '{date}', '{txtclicnpj.Text}', '{txtcliines.Text}', '{txtcliemai.Text}', '{txtclifone.Text}', '{txtclicelu.Text}', '{txtclicel1.Text}', '{txtclinume.Text}', {txtclistat.Text}, '{cmbendereco.SelectedValue}', {cmbramo.SelectedValue}, '{txtcliapel.Text}')";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro incluido com sucesso!!!");

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

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string date = dtpclidtin.Text.Replace("/", ".");
                string sql = $"UPDATE CLIENTE SET CLICODI = {txtclicodi.Text}, CLINOME = '{txtclinome.Text}', CLIFANT = '{txtclifant.Text}', CLILIMI = {txtclilimi.Text}, CLIDTIN = '{date}', CLICNPJ = '{txtclicnpj.Text}', CLIINES = '{txtcliines.Text}', CLIEMAI = '{txtcliemai.Text}', CLIFONE = '{txtclifone.Text}', CLICELU = '{txtclicelu.Text}', CLICEL1 = '{txtclicel1.Text}', CLINUME = '{txtclinume.Text}', CLISTAT = {txtclistat.Text}, ENDCEP = {cmbendereco.SelectedValue}, RAMCODI = {cmbramo.SelectedValue}, CLIAPEL = '{txtcliapel.Text}' WHERE CLICODI = {txtclicodi.Text}";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro atualizado com sucesso");
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

                string sql = $"DELETE FROM CLIENTE WHERE CLICODI = {txtclicodi.Text}";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro excluido com sucesso!!!");
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

        private void frmcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
        }
    }
}
