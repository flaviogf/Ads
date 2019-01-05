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
    public partial class frmhorario : Form
    {
        public frmhorario()
        {
            InitializeComponent();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO HORARIO"
            + " VALUES("
            + txthorcodi.Text + ", '"
            + txthornome.Text + "', '"
            + txthormane.Text + "', '"
            + txthormans.Text + "', '"
            + txthortare.Text + "', '"
            + txthortars.Text + "', "
            + Convert.ToInt32(cbotipos.SelectedValue)
            + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro incluído com sucesso !!!");
                limpar();
                txthorcodi.Focus();
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
            string strAlterar = "UPDATE HORARIO"
            + " SET HORCODI = " + txthorcodi.Text + ", "
            + " HORNOME = '" + txthornome.Text + "', "
            + " HORMANE = '" + txthormane.Text + "', "
            + " HORMANS = '" + txthormans.Text + "', "
            + " HORTARE = '" + txthortare.Text + "', "
            + " HORTARS = '" + txthortars.Text + "', "
            + " THOCODI = " + Convert.ToInt32(cbotipos.SelectedValue)
            + " WHERE HORCODI = '" + txthorcodi.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro gravado com sucesso !!!");
                limpar();
                txthorcodi.Focus();
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
            string strDelete = "DELETE FROM HORARIO WHERE HORCODI = " + txthorcodi.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro excluído com sucesso !!!");
                limpar();
                txthorcodi.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

            limpar();
        }

        private void frmhorario_KeyDown(object sender, KeyEventArgs e)
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
            txthorcodi.Clear();
            txthornome.Clear();
            txthormane.Clear();
            txthormans.Clear();
            txthortare.Clear();
            txthortars.Clear();
        }

        private void txthorcodi_Leave(object sender, EventArgs e)
        {
            btnincluir.Enabled = true;
            btngravar.Enabled = true;
            btnexcluir.Enabled = true;

            Conexao.Active(true);
            if (txthorcodi.Text != "")
            {
                string strConsulta = "SELECT * FROM HORARIO WHERE HORCODI = " +
                txthorcodi.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        consultarTipos(dr);
                        txthornome.Focus();
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
                            txthornome.Text = "";
                            txthormane.Text = "";
                            txthormans.Text = "";
                            txthortare.Text = "";
                            txthortars.Text = "";
                            txthornome.Focus();
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

        private void consultarTipos(FbDataReader dr)
        {
            txthorcodi.Text = dr["HORCODI"].ToString();
            txthornome.Text = dr["HORNOME"].ToString();
            txthormane.Text = dr["HORMANE"].ToString();
            txthormans.Text = dr["HORMANS"].ToString();
            txthortare.Text = dr["HORTARE"].ToString();
            txthortars.Text = dr["HORTARS"].ToString();
            int i = 0;
            for (i = 0; i <= this.cbotipos.Items.Count - 1; i++)
            {
                this.cbotipos.SelectedIndex = i;

                if (this.cbotipos.SelectedValue.ToString() == dr["THOCODI"].ToString())
                {
                    return;
                }
            }
        }

        private void frmhorario_Load(object sender, EventArgs e)
        {
            DgvDados();
            carregarTipos();
        }

        private void DgvDados()
        { //traz os dados da tabela para o dgv, conforme o select feito
            Conexao.Active(true);
            try
            {
                //Trazer tabela do banco para DGV
                DataTable dt = new DataTable();
                FbDataAdapter da = new FbDataAdapter("SELECT * FROM HORARIO", Conexao.FbCnn);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgvhorario.DataSource = dt;
                }
            }
            finally
            {
                Conexao.Active(false);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dgvhorario.RowCount > 0 && dgvhorario.SelectedRows.Count == 1)
            {
                int tipoCodi = Convert.ToInt32(dgvhorario.SelectedRows[0].Cells[0].Value);
                string sql = "SELECT * FROM HORARIO "
                           + "WHERE HORCODI = " + tipoCodi;
                try
                {
                    Conexao.Active(true);
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);

                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txthorcodi.Text = dr["HORCODI"].ToString();
                        txthornome.Text = dr["HORNOME"].ToString();
                        txthormane.Text = dr["HORMANE"].ToString();
                        txthormans.Text = dr["HORMANS"].ToString();
                        txthortare.Text = dr["HORTARE"].ToString();
                        txthortars.Text = dr["HORTARS"].ToString();
                        tbchorario.SelectedIndex = 1;
                        txthorcodi.Focus();
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

        private void tbchorario_Selected(object sender, TabControlEventArgs e)
        {
            if (tbchorario.SelectedIndex == 0)
            {
                DgvDados();
            }
        }

        private void carregarTipos()
        {
            this.cbotipos.Items.Clear();

            string s = "SELECT * FROM TIPOHORARIO";
            Conexao.Active(true);
            FbCommand cmd = new FbCommand(s, Conexao.FbCnn);
            FbDataReader r = cmd.ExecuteReader();

            Dictionary<string, int> p = new Dictionary<string, int>();
            while (r.Read())
            {
                p.Add(r["THONOME"].ToString(), Convert.ToInt32(r["THOCODI"]));

            }
            this.cbotipos.DataSource = new BindingSource(p, null);
            this.cbotipos.DisplayMember = "key";
            this.cbotipos.ValueMember = "value";
        }

        private void SelecionarItemCombo(int paicodi)
        {
            int i = 0;
            for (i = 0; i <= this.cbotipos.Items.Count - 1; i++)
            {
                this.cbotipos.SelectedIndex = i;
                if (Convert.ToInt32(this.cbotipos.SelectedValue) == paicodi)
                {
                    return;
                }
            }
        }
    }
}
