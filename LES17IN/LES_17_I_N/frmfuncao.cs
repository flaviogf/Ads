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
    public partial class frmfuncao : Form
    {
        public frmfuncao()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO FUNCAO"
                    + " VALUES("
                    + txtfuccodi.Text + ", '"
                    + txtfucnome.Text + "', "
                    + Convert.ToInt32(cbocbos.SelectedValue)
                    + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txtfuccodi.Focus();
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
            string strAlterar = "UPDATE FUNCAO"
            + " SET FUCCODI = " + txtfuccodi.Text + ", "
            + " FUCNOME = '" + txtfucnome.Text + "', "
            + " CBOCODI = " + Convert.ToInt32(cbocbos.SelectedValue)
            + " WHERE FUCCODI = '" + txtfuccodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txtfuccodi.Focus();
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
            string strDelete = "DELETE FROM FUNCAO WHERE FUCCODI = " + txtfuccodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txtfuccodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmfuncao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void limpar()
        {
            txtfuccodi.Clear();
            txtfucnome.Clear();
            txtfuccodi.Focus();
        }

        private void txtfuccodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txtfuccodi.Text != "")
            {
                string strConsulta = "SELECT * FROM FUNCAO WHERE FUCCODI = " +
                txtfuccodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        consultaCbo(dr);
                        txtfucnome.Focus();
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
                            txtfucnome.Text = "";
                            txtfucnome.Focus();
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
            txtfuccodi.Text = dr["FUCCODI"].ToString();
            txtfucnome.Text = dr["FUCNOME"].ToString();
            int i = 0;
            for (i = 0; i <= this.cbocbos.Items.Count - 1; i++)
            {
                this.cbocbos.SelectedIndex = i;

                if (this.cbocbos.SelectedValue.ToString() == dr["CBOCODI"].ToString())
                {
                    return;
                }
            }
        }

        private void frmfuncao_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarCbos();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM FUNCAO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvfuncao.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dgvfuncao_DoubleClick(object sender, EventArgs e)
        {
            if (dgvfuncao.RowCount > 0 && dgvfuncao.SelectedRows.Count == 1)
            {
                int fucCodi = Convert.ToInt32(dgvfuncao.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM FUNCAO "
                           + "WHERE FUCCODI = " + fucCodi;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtfuccodi.Text = dr["FUCCODI"].ToString();
                        txtfucnome.Text = dr["FUCNOME"].ToString();
                        tbcfuncao.SelectedIndex = 1;
                        txtfucnome.Focus();
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

        private void tbcfuncao_Selected(object sender, TabControlEventArgs e)
        {
            if (tbcfuncao.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

        private void carregarCbos()
        {
            this.cbocbos.Items.Clear();

            string s = "SELECT * FROM CBO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["CBONOME"].ToString(), Convert.ToInt32(r["CBOCODI"]));

            }
            this.cbocbos.DataSource = new BindingSource(p, null);
            this.cbocbos.DisplayMember = "key";
            this.cbocbos.ValueMember = "value";
        }

        private void SelecionarItemCombo(int cboCodi)
        {
            int i = 0;
            for (i = 0; i <= this.cbocbos.Items.Count - 1; i++)
            {
                this.cbocbos.SelectedIndex = i;
                if (Convert.ToInt32(this.cbocbos.SelectedValue) == cboCodi)
                {
                    return;
                }
            }
        }
    }
}
