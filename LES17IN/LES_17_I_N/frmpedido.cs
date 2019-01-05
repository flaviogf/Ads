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
    public partial class frmpedido : Form
    {
        public frmpedido()
        {
            InitializeComponent();
        }

        private void ctrlInsert()
        {
            btnincluir.Enabled = true;
            btnexcluir.Enabled = false;
            btngravar.Enabled = false;
            txtpedperc.Enabled = true;
        }

        private void ctrlUpdate()
        {
            btnincluir.Enabled = false;
            btnexcluir.Enabled = true;
            btngravar.Enabled = true;
            txtpedperc.Enabled = false;
        }

        private void limpar()
        {
            txtpedcodi.Clear();
            dtppeddtem.ResetText();
            dtppeddtba.ResetText();
            txtpedtota.Text = "0";
            txtpedperc.Clear();
            txtpeddesc.Text = "0";
            txtpedliqu.Text = "0";
            txtpedcond.Clear();
            txtpedobs.Clear();
            cmbcliente.SelectedIndex = -1;
            cmbfuncionario.SelectedIndex = -1;
            btnincluir.Enabled = false;
            btngravar.Enabled = false;
            btnexcluir.Enabled = false;
            dgvitens.DataSource = null;
            txtitecodi.Clear();
            cmbproduto.SelectedIndex = -1;
            txtiteqtde.Clear();
            txtitetota.Clear();
            txtitevalo.Clear();
            btnincluiri.Enabled = false;
        }

        private void carregarDados()
        {
            try
            {
                dgvpedido.DataSource = null;

                Conexao.Active(true);
                string sql = $"select p.pedcodi, p.peddtem, p.peddtba, p.pedtota, p.pedperc, p.peddesc, p.pedliqu, p.pedcond, p.pedobs, p.clicodi, c.clinome, p.funcodi, f.funnome from pedido p inner join cliente c on p.clicodi = c.clicodi inner join funcionario f on p.funcodi = f.funcodi";
                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter(sql, Conexao.FbCnn);

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    table.Columns["pedcodi"].ColumnName = "Código";
                    table.Columns["peddtem"].ColumnName = "Emissão";
                    table.Columns["peddtba"].ColumnName = "Baixa";
                    table.Columns["pedtota"].ColumnName = "Total";
                    table.Columns["pedperc"].ColumnName = "Percentual de desconto";
                    table.Columns["peddesc"].ColumnName = "Desconto";
                    table.Columns["pedliqu"].ColumnName = "Valor liquido";
                    table.Columns["pedcond"].ColumnName = "Condição de pagamento";
                    table.Columns["pedobs"].ColumnName = "Observações";
                    table.Columns["clicodi"].ColumnName = "Codigo do cliente";
                    table.Columns["clinome"].ColumnName = "Nome do cliente";
                    table.Columns["funcodi"].ColumnName = "Codigo do funcionario";
                    table.Columns["funnome"].ColumnName = "Nome do funcionario";

                    dgvpedido.DataSource = table;
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

        private void carregarCliente()
        {
            try
            {
                Conexao.Active(true);
                string sql = "SELECT * FROM CLIENTE";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> clientes = new Dictionary<string, string>();

                while (dr.Read())
                {
                    clientes.Add(dr["clicodi"].ToString(), dr["clinome"].ToString());
                }

                cmbcliente.DataSource = new BindingSource(clientes, null);
                cmbcliente.DisplayMember = "value";
                cmbcliente.ValueMember = "key";
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

        private void carregarFuncionario()
        {
            try
            {
                Conexao.Active(true);
                string sql = "SELECT * FROM FUNCIONARIO";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> funcionarios = new Dictionary<string, string>();

                while (dr.Read())
                {
                    funcionarios.Add(dr["funcodi"].ToString(), dr["funnome"].ToString());
                }

                cmbfuncionario.DataSource = new BindingSource(funcionarios, null);
                cmbfuncionario.DisplayMember = "value";
                cmbfuncionario.ValueMember = "key";
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
                string sql = $"INSERT INTO PEDIDO VALUES('{txtpedcodi.Text}', '{dtppeddtem.Text.Replace("/", ".")}', '{dtppeddtba.Text.Replace("/", ".")}', {txtpedtota.Text}, {txtpedperc.Text}, {txtpeddesc.Text}, {txtpedliqu.Text}, '{txtpedcond.Text}', '{txtpedobs.Text}', {cmbcliente.SelectedValue}, {cmbfuncionario.SelectedValue})";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro incluido com sucesso!!!");
                ctrlUpdate();
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

        private void txtpedcodi_Leave(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string sql = $"select p.pedcodi, p.peddtem, p.peddtba, p.pedtota, p.pedtota, p.pedperc, p.peddesc, p.pedliqu, p.pedcond, p.pedobs, p.clicodi, c.clinome, p.funcodi, f.funnome from pedido p inner join cliente c on p.clicodi = c.clicodi inner join funcionario f on p.funcodi = f.funcodi where p.pedcodi = {txtpedcodi.Text}";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    limpar();
                    txtpedcodi.Text = dr["pedcodi"].ToString();
                    dtppeddtem.Value = DateTime.Parse(dr["peddtem"].ToString());
                    dtppeddtba.Value = DateTime.Parse(dr["peddtba"].ToString());
                    txtpedtota.Text = dr["pedtota"].ToString();
                    txtpedperc.Text = dr["pedperc"].ToString();
                    txtpeddesc.Text = dr["peddesc"].ToString();
                    txtpedliqu.Text = dr["pedliqu"].ToString();
                    txtpedcond.Text = dr["pedcond"].ToString();
                    txtpedobs.Text = dr["pedobs"].ToString();
                    cmbcliente.SelectedIndex = cmbcliente.FindString(dr["clinome"].ToString());
                    cmbfuncionario.SelectedIndex = cmbfuncionario.FindString(dr["funnome"].ToString());
                    carregarItens();
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
                        string aux = txtpedcodi.Text;
                        limpar();
                        txtpedcodi.Text = aux;
                        txtpedtota.Focus();
                        ctrlInsert();
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

        private void frmpedido_Load(object sender, EventArgs e)
        {
            carregarCliente();
            carregarFuncionario();
            carregarProduto();
            carregarDados();
            limpar();
        }

        private void dgvpedido_DoubleClick(object sender, EventArgs e)
        {
            if (dgvpedido.Rows.Count > 0 && dgvpedido.SelectedRows.Count == 1)
            {
                try
                {
                    carregarDadosPedidos();
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

        private void carregarDadosPedidos()
        {
            Conexao.Active(true);
            int codigo = (int)dgvpedido.SelectedRows[0].Cells[0].Value;
            string sql = $"select p.pedcodi, p.peddtem, p.peddtba, p.pedtota, p.pedtota, p.pedperc, p.peddesc, p.pedliqu, p.pedcond, p.pedobs, p.clicodi, c.clinome, p.funcodi, f.funnome from pedido p inner join cliente c on p.clicodi = c.clicodi inner join funcionario f on p.funcodi = f.funcodi where p.pedcodi = {codigo}";
            FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
            FbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtpedcodi.Text = dr["pedcodi"].ToString();
                dtppeddtem.Value = DateTime.Parse(dr["peddtem"].ToString());
                dtppeddtba.Value = DateTime.Parse(dr["peddtba"].ToString());
                txtpedtota.Text = dr["pedtota"].ToString();
                txtpedperc.Text = dr["pedperc"].ToString();
                txtpeddesc.Text = dr["peddesc"].ToString();
                txtpedliqu.Text = dr["pedliqu"].ToString();
                txtpedcond.Text = dr["pedcond"].ToString();
                txtpedobs.Text = dr["pedobs"].ToString();
                cmbcliente.SelectedIndex = cmbcliente.FindString(dr["clinome"].ToString());
                cmbfuncionario.SelectedIndex = cmbfuncionario.FindString(dr["funnome"].ToString());
                tbcpedido.SelectedIndex = 1;
                txtpedcodi.Focus();
                carregarItens();
            }
        }

        private void tbcpedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcpedido.SelectedIndex == 0)
            {
                carregarDados();
            }
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Active(true);
                string sql = $"update pedido set pedcodi = {txtpedcodi.Text}, peddtem = '{dtppeddtem.Text.Replace("/", ".")}', peddtba = '{dtppeddtba.Text.Replace("/", ".")}', pedtota = {txtpedtota.Text}, pedperc = {txtpedperc.Text}, peddesc = {txtpeddesc.Text}, pedliqu = {txtpedliqu.Text}, pedcond = '{txtpedcond.Text}', pedobs = '{txtpedobs.Text}', clicodi = {cmbcliente.SelectedValue}, funcodi = {cmbfuncionario.SelectedValue} where pedcodi = {txtpedcodi.Text}";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro gravado com sucesso!!!");
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
                string sql = $"DELETE FROM PEDIDO WHERE PEDCODI = {txtpedcodi.Text}";
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

        private void frmpedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void carregarProduto()
        {
            try
            {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand("select * from produto", Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();

                Dictionary<string, string> produtos = new Dictionary<string, string>();

                while (dr.Read())
                {
                    produtos.Add(dr["procodi"].ToString(), dr["pronome"].ToString());
                }

                cmbproduto.DataSource = new BindingSource(produtos, null);
                cmbproduto.DisplayMember = "value";
                cmbproduto.ValueMember = "key";
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

        private void btnincluiri_Click(object sender, EventArgs e)
        {
            try
            {
                double percentual = Double.Parse(txtpedperc.Text) / 100;
                Conexao.Active(true);
                string sql = $"insert into pedido_item values({txtpedcodi.Text}, {txtitecodi.Text}, {cmbproduto.SelectedValue}, {txtiteqtde.Text}, {txtitevalo.Text}, {txtitetota.Text})";
                FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                string sql2 = $"update pedido set pedtota = pedtota + {txtitetota.Text} where pedcodi = {txtpedcodi.Text}";
                FbCommand cmd2 = new FbCommand(sql2, Conexao.FbCnn);
                string sql3 = $"update pedido set peddesc = ({percentual.ToString().Replace(",", ".")} * pedtota) where pedcodi = {txtpedcodi.Text}";
                FbCommand cmd3 = new FbCommand(sql3, Conexao.FbCnn);
                string sql4 = $"update pedido set pedliqu = pedtota - peddesc where pedcodi = {txtpedcodi.Text}";
                FbCommand cmd4 = new FbCommand(sql4, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();

                MessageBox.Show("Registro incluido com sucesso !!!");
                carregarItens();
                txtpedcodi.Focus();
                txtpedtota.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txtitetota.Text = (Double.Parse(txtiteqtde.Text) * Double.Parse(txtitevalo.Text)).ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void carregarItens()
        {
            try
            {
                Conexao.Active(true);
                DataTable table = new DataTable();
                FbDataAdapter adapter = new FbDataAdapter($"select pitem.itecodi, p.pronome,  pitem.iteqtde, pitem.itevalo, pitem.itetota from pedido_item pitem inner join produto p on pitem.procodi = p.procodi where pedcodi = {txtpedcodi.Text}", Conexao.FbCnn);

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    table.Columns["itecodi"].ColumnName = "Codigo do item";
                    table.Columns["pronome"].ColumnName = "Produto";
                    table.Columns["iteqtde"].ColumnName = "Quantidade";
                    table.Columns["itevalo"].ColumnName = "Valor unitario";
                    table.Columns["itetota"].ColumnName = "Valor total";

                    dgvitens.DataSource = table;
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

        private void ctrlInsertI()
        {
            btnincluiri.Enabled = true;
        }

        private void ctrlUpdateI()
        {
            btnincluiri.Enabled = false;
        }

        private void txtitecodi_Leave(object sender, EventArgs e)
        {
            if (txtitecodi.Text != "")
            {
                try
                {
                    Conexao.Active(true);
                    string sql = $"select pit.itecodi, p.pronome, pit.iteqtde, pit.itevalo, pit.itetota from pedido_item pit inner join produto p on p.procodi = pit.procodi where itecodi = {txtitecodi.Text} and pedcodi = {txtpedcodi.Text}";
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        setTextItens(dr);
                    }
                    else
                    {
                        bool resposta = MessageBox.Show("Registro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No;
                        if (!resposta)
                        {
                            string aux = txtitecodi.Text;
                            ctrlInsertI();
                            limparItens();
                            txtitecodi.Text = aux;
                            cmbproduto.Focus();
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

        private void setTextItens(FbDataReader dr)
        {
            txtitecodi.Text = dr["itecodi"].ToString();
            cmbproduto.SelectedIndex = cmbproduto.FindString(dr["pronome"].ToString());
            txtiteqtde.Text = dr["iteqtde"].ToString();
            txtitevalo.Text = dr["itevalo"].ToString();
            txtitetota.Text = dr["itetota"].ToString();
            ctrlUpdateI();
        }

        private void limparItens()
        {
            txtitecodi.Clear();
            txtiteqtde.Clear();
            txtitetota.Clear();
            txtitevalo.Clear();
            cmbproduto.SelectedIndex = -1;
        }

        private void dgvitens_DoubleClick(object sender, EventArgs e)
        {
            if (dgvitens.Rows.Count > 0 && dgvitens.SelectedRows.Count == 1)
            {
                try
                {
                    int itecodi = (int)dgvitens.SelectedRows[0].Cells[0].Value;
                    Conexao.Active(true);
                    string sql = $"select pit.itecodi, p.pronome, pit.iteqtde, pit.itevalo, pit.itetota from pedido_item pit inner join produto p on p.procodi = pit.procodi where itecodi = {itecodi} and pedcodi = {txtpedcodi.Text}";
                    FbCommand cmd = new FbCommand(sql, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        setTextItens(dr);
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
