namespace boasvindas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
            string nomeUsuario;//Declara��o de vari�vel tipo string//
            nomeUsuario = TxtNome.Txt;
            //Concatenar

            MessageBox.Show($"Bem vindo C# {nomeUsuario}", "Ol�", MessageBoxButtons.OK, MessageBoxIcon.Information);

            IblMensagem.Text = $"Bem vindo ao C# {nomeUsuario}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}