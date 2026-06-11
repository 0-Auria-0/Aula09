namespace Aula09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AcessoBancoDados db = new AcessoBancoDados();
            db.Conectar();
            MessageBox.Show("Conectar, eu acho");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Cpf = textBoxCPF.Text;
            pessoa.Telefone = textBoxTelefone.Text;
            pessoa.Nome = textBoxNome.Text;

            string sql = "insert into clientes(nome, cpf, telefone)";
            sql += $" values('{pessoa.Nome}','{pessoa.Cpf}','{pessoa.Telefone}')";

            AcessoBancoDados db = new AcessoBancoDados();
            db.Conectar();
            db.ExecutarComandoSQL(sql);

            textBoxCPF.Clear();
            textBoxTelefone.Clear();
            textBoxNome.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
