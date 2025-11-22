namespace Exercicio_Calculadora
{
    using System.Text;
    using System.Text.RegularExpressions;
    public partial class Form1 : Form
    {
        string nAposVirgula = "F0";
        void AddEntrada(string a)
        {
            int LocalDoMouse = entrada.SelectionStart;
            entrada.Text = entrada.Text.Insert(LocalDoMouse, a);
            entrada.SelectionStart = LocalDoMouse + 1;
        }
        string calcular(string entrada)
        {
            return conta(entrada);
        }
        string conta(string entrada)
        {

            ///função simples que calcula valores, como "5x20+10" seguindo a ordem (multiplicação,divisão,soma,subtração)
            ///não reconhece parenteses. precisa ser executada após outra função reconhecer a ordem.
            ///é recursiva
            string multiplicacaoDivisao = @"\d+(?:,\d+)?[÷x]\d+(?:,\d+)?";
            string somaSubtracao = @"\d+(?:,\d+)?[\+\-]\d+(?:,\d+)?";
            if (!Regex.IsMatch(entrada, @"\d+(?:,\d+)?[÷x\+\-]\d+(?:,\d+)?"))
            {
                return entrada;
            }
            int tamanho = Convert.ToString(Regex.Match(entrada, multiplicacaoDivisao)).Length;
            string operacao = Convert.ToString(Regex.Match(entrada, @"[÷x\+\-]"));
            var valores = Regex.Matches(entrada, @"\d+(?:,\d+)?");
            if (operacao == "÷")
            {
                float resultado = Convert.ToInt64(valores[0].Value) / Convert.ToInt64(valores[1].Value);
                return conta(resultado.ToString(nAposVirgula) + entrada.Substring(tamanho));
            }
            if (operacao == "x")
            {
                float resultado = Convert.ToInt64(valores[0].Value) * Convert.ToInt64(valores[1].Value);
                return conta(resultado.ToString(nAposVirgula) + entrada.Substring(tamanho));
            }
            if (operacao == "+")
            {
                float resultado = Convert.ToInt64(valores[0].Value) + Convert.ToInt64(valores[1].Value);
                return conta(resultado.ToString(nAposVirgula) + entrada.Substring(tamanho));
            }
            if (operacao == "-")
            {
                float resultado = Convert.ToInt64(valores[0].Value) - Convert.ToInt64(valores[1].Value);
                return conta(resultado.ToString(nAposVirgula) + entrada.Substring(tamanho));
            }
            return entrada;
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
            entrada.Text = calcular(entrada.Text);
            entrada.SelectionStart = entrada.Text.Length;
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
            if (entrada.Text.Length > 0)
            {
                entrada.Clear();
                saida.Items.Clear();
            }
        }

        private void remover1_Click(object sender, EventArgs e)
        {
            if (entrada.Text.Length > 0)
            {
                int LocalDoMouse = entrada.SelectionStart;
                entrada.Text = entrada.Text.Remove(LocalDoMouse - 1);
                entrada.SelectionStart = LocalDoMouse - 1;
            }
        }
    }
}
