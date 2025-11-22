namespace Exercicio_Calculadora
{
    using System.Globalization;
    using System.Text;
    using System.Text.RegularExpressions;
    using static System.Windows.Forms.DataFormats;

    public partial class Form1 : Form
    {
        int ContarCasasDecimais(string numeroStr)
        {
            if (string.IsNullOrEmpty(numeroStr))
                return 0;

            string[] partes = numeroStr.Split(',');

            // Retorna 0 se não tiver vírgula ou parte decimal não for numérica
            if (partes.Length < 2 || !Regex.IsMatch(partes[1], @"^\d+$"))
                return 0;

            return partes[1].Length;
        }
        string nAposVirgula = "F2";
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
        MatchCollection valores = null;
        string conta(string entrada)
        {

            ///função simples que calcula valores, como "5x20+10" seguindo a ordem (multiplicação,divisão,soma,subtração)
            ///não reconhece parenteses. precisa ser executada após outra função reconhecer a ordem.
            ///é recursiva
            string multiplicacaoDivisao = @"\d+(?:,\d+)?[÷x]\d+(?:,\d+)?";
            string somaSubtracao = @"\d+(?:,\d+)?[\+\-]\d+(?:,\d+)?";
            if (Regex.IsMatch(entrada, multiplicacaoDivisao))
            {
                valores = Regex.Matches(Regex.Match(entrada, multiplicacaoDivisao).Value, @"\d+(?:,\d+)?");
            }
            else if (Regex.IsMatch(entrada, somaSubtracao))
            {
                valores = Regex.Matches(Regex.Match(entrada, somaSubtracao).Value, @"\d+(?:,\d+)?");
            }
            else
            {
                valores = Regex.Matches(Regex.Match(entrada, @"\d+(?:,\d+)?").Value, @"\d+(?:,\d+)?");
            }

            if (valores.Count < 2)
            {
                int casasDecimais = ContarCasasDecimais(valores[0].Value);
                nAposVirgula = casasDecimais switch
                {
                    0 => "F0",
                    1 => "F1",
                    2 => "F2",
                    _ => "F2"
                };
                return (float.Parse(valores[0].Value, new CultureInfo("pt-BR"))).ToString();
            }
            int tamanho = 0;
            string operacao = null;
            string valor = null;
            if (Regex.IsMatch(entrada, @"[÷x]"))
            {
                operacao = Convert.ToString(Regex.Match(entrada, @"[÷x]").Value);
                valor = Regex.Match(entrada,multiplicacaoDivisao).Value;
                tamanho = valor.Length;
            }
            else if(Regex.IsMatch(entrada, @"[\+\-]"))
            {
                operacao = Convert.ToString(Regex.Match(entrada, @"[\+\-]").Value);
                valor = Regex.Match(entrada,somaSubtracao).Value;
                tamanho = valor.Length;
            }
            float valor1 = float.Parse(valores[0].Value);
            float valor2 = float.Parse(valores[1].Value);
            float resultado = operacao switch
            {
                "÷" => valor1 / valor2,
                "x" => valor1 * valor2,
                "+" => valor1 + valor2,
                "-" => valor1 - valor2
            };
            return conta(entrada.Substring(0, entrada.IndexOf(valor)) + (resultado.ToString(nAposVirgula) + entrada.Substring(entrada.IndexOf(valor) + tamanho)));
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
