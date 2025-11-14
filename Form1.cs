namespace Exercicio_Calculadora
{
    public partial class Form1 : Form
    {
        void AddEntrada(string a)
        {
            int LocalDoMouse = entrada.SelectionStart;
            entrada.Text = entrada.Text.Insert(LocalDoMouse, a);
            entrada.SelectionStart = LocalDoMouse + 1;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void hopeRoundButton1_Click(object sender, EventArgs e)
        {

        }

        private void hopeRoundButton2_Click(object sender, EventArgs e)
        {

        }

        private void Formulario_Click(object sender, EventArgs e)
        {

        }

        private void hopeRoundButton4_Click(object sender, EventArgs e)
        {

        }

        private void entrada_1_Click(object sender, EventArgs e)
        {
            AddEntrada("1");
        }

        private void entrada_2_Click(object sender, EventArgs e)
        {
            AddEntrada("2");
        }
        private void entrada_3_Click(object sender, EventArgs e)
        {
            AddEntrada("3");
        }
        private void entrada_4_Click(object sender, EventArgs e)
        {
            AddEntrada("4");
        }
        private void entrada_5_Click(object sender, EventArgs e)
        {
            AddEntrada("5");
        }
        private void entrada_6_Click(object sender, EventArgs e)
        {
            AddEntrada("6");
        }
        private void entrada_7_Click(object sender, EventArgs e)
        {
            AddEntrada("7");
        }
        private void entrada_8_Click(object sender, EventArgs e)
        {
            AddEntrada("8");
        }
        private void entrada_9_Click(object sender, EventArgs e)
        {
            AddEntrada("9");
        }
        private void entrada_0_Click(object sender, EventArgs e)
        {
            AddEntrada("0");
        }

        private void entrada_soma_Click(object sender, EventArgs e)
        {
            AddEntrada("+");
        }

        private void entrada_subtração_Click(object sender, EventArgs e)
        {
            AddEntrada("-");
        }

        private void entrada_multiplicacao_Click(object sender, EventArgs e)
        {
            AddEntrada("x");
        }

        private void entrada_divisao_Click(object sender, EventArgs e)
        {
            AddEntrada("÷");
        }

        private void entrada_porcentagem_Click(object sender, EventArgs e)
        {
            AddEntrada("%");
        }

        private void entrada_virgula_Click(object sender, EventArgs e)
        {
            AddEntrada(",");
        }

        private void entrada_clear_Click(object sender, EventArgs e)
        {
            entrada.Text = string.Empty;
            saida.Text = string.Empty;
        }
    }
}
