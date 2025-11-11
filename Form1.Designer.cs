namespace Exercicio_Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Formulario = new ReaLTaiizor.Forms.ForeverForm();
            saida = new ListBox();
            entrada = new ReaLTaiizor.Controls.ForeverTextBox();
            entrada_divisao = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_porcentagem = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_parenteses = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_clear = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_multiplicacao = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_9 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_8 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_7 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_subtração = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_6 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_5 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_4 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_soma = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_3 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_2 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_1 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_resultado = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_virgula = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_0 = new ReaLTaiizor.Controls.HopeRoundButton();
            entrada_menos = new ReaLTaiizor.Controls.HopeRoundButton();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            foreverMaximize1 = new ReaLTaiizor.Controls.ForeverMaximize();
            foreverMinimize1 = new ReaLTaiizor.Controls.ForeverMinimize();
            Formulario.SuspendLayout();
            SuspendLayout();
            // 
            // Formulario
            // 
            Formulario.BackColor = Color.FromArgb(60, 70, 73);
            Formulario.BaseColor = Color.FromArgb(60, 70, 73);
            Formulario.BorderColor = Color.Transparent;
            Formulario.Controls.Add(saida);
            Formulario.Controls.Add(entrada);
            Formulario.Controls.Add(entrada_divisao);
            Formulario.Controls.Add(entrada_porcentagem);
            Formulario.Controls.Add(entrada_parenteses);
            Formulario.Controls.Add(entrada_clear);
            Formulario.Controls.Add(entrada_multiplicacao);
            Formulario.Controls.Add(entrada_9);
            Formulario.Controls.Add(entrada_8);
            Formulario.Controls.Add(entrada_7);
            Formulario.Controls.Add(entrada_subtração);
            Formulario.Controls.Add(entrada_6);
            Formulario.Controls.Add(entrada_5);
            Formulario.Controls.Add(entrada_4);
            Formulario.Controls.Add(entrada_soma);
            Formulario.Controls.Add(entrada_3);
            Formulario.Controls.Add(entrada_2);
            Formulario.Controls.Add(entrada_1);
            Formulario.Controls.Add(entrada_resultado);
            Formulario.Controls.Add(entrada_virgula);
            Formulario.Controls.Add(entrada_0);
            Formulario.Controls.Add(entrada_menos);
            Formulario.Controls.Add(foreverClose1);
            Formulario.Controls.Add(foreverMaximize1);
            Formulario.Controls.Add(foreverMinimize1);
            Formulario.Dock = DockStyle.Fill;
            Formulario.Font = new Font("Segoe UI", 12F);
            Formulario.ForeverColor = Color.FromArgb(35, 168, 109);
            Formulario.HeaderColor = Color.FromArgb(45, 47, 49);
            Formulario.HeaderMaximize = false;
            Formulario.HeaderTextFont = new Font("Segoe UI", 12F);
            Formulario.Image = null;
            Formulario.Location = new Point(0, 0);
            Formulario.Margin = new Padding(0);
            Formulario.MinimumSize = new Size(210, 50);
            Formulario.Name = "Formulario";
            Formulario.Padding = new Padding(1, 51, 1, 1);
            Formulario.Sizable = true;
            Formulario.Size = new Size(320, 569);
            Formulario.TabIndex = 0;
            Formulario.Text = "Calculadora";
            Formulario.TextColor = Color.FromArgb(234, 234, 234);
            Formulario.TextLight = Color.SeaGreen;
            Formulario.Click += Formulario_Click;
            // 
            // saida
            // 
            saida.BackColor = Color.FromArgb(60, 70, 73);
            saida.BorderStyle = BorderStyle.None;
            saida.FormattingEnabled = true;
            saida.ItemHeight = 21;
            saida.Location = new Point(16, 120);
            saida.Name = "saida";
            saida.Size = new Size(280, 63);
            saida.TabIndex = 25;
            // 
            // entrada
            // 
            entrada.BackColor = Color.Transparent;
            entrada.BaseColor = Color.FromArgb(45, 47, 49);
            entrada.BorderColor = Color.FromArgb(35, 168, 109);
            entrada.FocusOnHover = false;
            entrada.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entrada.ForeColor = Color.FromArgb(192, 192, 192);
            entrada.Location = new Point(16, 64);
            entrada.MaxLength = 32767;
            entrada.Multiline = false;
            entrada.Name = "entrada";
            entrada.ReadOnly = false;
            entrada.Size = new Size(280, 54);
            entrada.TabIndex = 24;
            entrada.TextAlign = HorizontalAlignment.Left;
            entrada.UseSystemPasswordChar = false;
            // 
            // entrada_divisao
            // 
            entrada_divisao.BackColor = Color.Transparent;
            entrada_divisao.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_divisao.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_divisao.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_divisao.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_divisao.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entrada_divisao.HoverTextColor = Color.FromArgb(66, 140, 25);
            entrada_divisao.ImeMode = ImeMode.NoControl;
            entrada_divisao.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_divisao.Location = new Point(232, 208);
            entrada_divisao.Margin = new Padding(0);
            entrada_divisao.Name = "entrada_divisao";
            entrada_divisao.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_divisao.Size = new Size(60, 60);
            entrada_divisao.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_divisao.TabIndex = 23;
            entrada_divisao.Text = "÷";
            entrada_divisao.TextColor = Color.FromArgb(103, 194, 58);
            entrada_divisao.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_porcentagem
            // 
            entrada_porcentagem.BackColor = Color.Transparent;
            entrada_porcentagem.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_porcentagem.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_porcentagem.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_porcentagem.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_porcentagem.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            entrada_porcentagem.HoverTextColor = Color.FromArgb(66, 140, 25);
            entrada_porcentagem.ImeMode = ImeMode.NoControl;
            entrada_porcentagem.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_porcentagem.Location = new Point(161, 208);
            entrada_porcentagem.Margin = new Padding(0);
            entrada_porcentagem.Name = "entrada_porcentagem";
            entrada_porcentagem.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_porcentagem.Size = new Size(60, 60);
            entrada_porcentagem.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_porcentagem.TabIndex = 22;
            entrada_porcentagem.Text = "%";
            entrada_porcentagem.TextColor = Color.FromArgb(103, 194, 58);
            entrada_porcentagem.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_parenteses
            // 
            entrada_parenteses.BackColor = Color.Transparent;
            entrada_parenteses.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_parenteses.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_parenteses.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_parenteses.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_parenteses.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            entrada_parenteses.HoverTextColor = Color.FromArgb(66, 140, 25);
            entrada_parenteses.ImeMode = ImeMode.NoControl;
            entrada_parenteses.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_parenteses.Location = new Point(96, 208);
            entrada_parenteses.Margin = new Padding(0);
            entrada_parenteses.Name = "entrada_parenteses";
            entrada_parenteses.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_parenteses.Size = new Size(60, 60);
            entrada_parenteses.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_parenteses.TabIndex = 21;
            entrada_parenteses.Text = "()";
            entrada_parenteses.TextColor = Color.FromArgb(103, 194, 58);
            entrada_parenteses.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_clear
            // 
            entrada_clear.BackColor = Color.Transparent;
            entrada_clear.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_clear.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_clear.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_clear.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_clear.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            entrada_clear.HoverTextColor = Color.FromArgb(179, 65, 65);
            entrada_clear.ImeMode = ImeMode.NoControl;
            entrada_clear.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_clear.Location = new Point(22, 208);
            entrada_clear.Margin = new Padding(0);
            entrada_clear.Name = "entrada_clear";
            entrada_clear.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_clear.Size = new Size(60, 60);
            entrada_clear.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_clear.TabIndex = 20;
            entrada_clear.Text = "C";
            entrada_clear.TextColor = Color.FromArgb(245, 108, 108);
            entrada_clear.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_multiplicacao
            // 
            entrada_multiplicacao.BackColor = Color.Transparent;
            entrada_multiplicacao.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_multiplicacao.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_multiplicacao.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_multiplicacao.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_multiplicacao.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            entrada_multiplicacao.HoverTextColor = Color.FromArgb(66, 140, 25);
            entrada_multiplicacao.ImeMode = ImeMode.NoControl;
            entrada_multiplicacao.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_multiplicacao.Location = new Point(232, 280);
            entrada_multiplicacao.Margin = new Padding(0);
            entrada_multiplicacao.Name = "entrada_multiplicacao";
            entrada_multiplicacao.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_multiplicacao.Size = new Size(60, 60);
            entrada_multiplicacao.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_multiplicacao.TabIndex = 19;
            entrada_multiplicacao.Text = "x";
            entrada_multiplicacao.TextColor = Color.FromArgb(103, 194, 58);
            entrada_multiplicacao.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_9
            // 
            entrada_9.BackColor = Color.Transparent;
            entrada_9.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_9.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_9.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_9.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_9.Font = new Font("Segoe UI", 18F);
            entrada_9.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_9.ImeMode = ImeMode.NoControl;
            entrada_9.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_9.Location = new Point(161, 280);
            entrada_9.Margin = new Padding(0);
            entrada_9.Name = "entrada_9";
            entrada_9.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_9.Size = new Size(60, 60);
            entrada_9.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_9.TabIndex = 18;
            entrada_9.Text = "9";
            entrada_9.TextColor = Color.White;
            entrada_9.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_8
            // 
            entrada_8.BackColor = Color.Transparent;
            entrada_8.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_8.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_8.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_8.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_8.Font = new Font("Segoe UI", 18F);
            entrada_8.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_8.ImeMode = ImeMode.NoControl;
            entrada_8.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_8.Location = new Point(96, 280);
            entrada_8.Margin = new Padding(0);
            entrada_8.Name = "entrada_8";
            entrada_8.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_8.Size = new Size(60, 60);
            entrada_8.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_8.TabIndex = 17;
            entrada_8.Text = "8";
            entrada_8.TextColor = Color.White;
            entrada_8.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_7
            // 
            entrada_7.BackColor = Color.Transparent;
            entrada_7.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_7.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_7.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_7.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_7.Font = new Font("Segoe UI", 18F);
            entrada_7.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_7.ImeMode = ImeMode.NoControl;
            entrada_7.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_7.Location = new Point(22, 280);
            entrada_7.Margin = new Padding(0);
            entrada_7.Name = "entrada_7";
            entrada_7.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_7.Size = new Size(60, 60);
            entrada_7.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_7.TabIndex = 16;
            entrada_7.Text = "7";
            entrada_7.TextColor = Color.White;
            entrada_7.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_subtração
            // 
            entrada_subtração.BackColor = Color.Transparent;
            entrada_subtração.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_subtração.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_subtração.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_subtração.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_subtração.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entrada_subtração.HoverTextColor = Color.FromArgb(66, 140, 25);
            entrada_subtração.ImeMode = ImeMode.NoControl;
            entrada_subtração.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_subtração.Location = new Point(232, 352);
            entrada_subtração.Margin = new Padding(0);
            entrada_subtração.Name = "entrada_subtração";
            entrada_subtração.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_subtração.Size = new Size(60, 60);
            entrada_subtração.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_subtração.TabIndex = 15;
            entrada_subtração.Text = "-";
            entrada_subtração.TextColor = Color.FromArgb(103, 194, 58);
            entrada_subtração.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_6
            // 
            entrada_6.BackColor = Color.Transparent;
            entrada_6.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_6.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_6.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_6.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_6.Font = new Font("Segoe UI", 18F);
            entrada_6.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_6.ImeMode = ImeMode.NoControl;
            entrada_6.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_6.Location = new Point(161, 352);
            entrada_6.Margin = new Padding(0);
            entrada_6.Name = "entrada_6";
            entrada_6.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_6.Size = new Size(60, 60);
            entrada_6.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_6.TabIndex = 14;
            entrada_6.Text = "6";
            entrada_6.TextColor = Color.White;
            entrada_6.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_5
            // 
            entrada_5.BackColor = Color.Transparent;
            entrada_5.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_5.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_5.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_5.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_5.Font = new Font("Segoe UI", 18F);
            entrada_5.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_5.ImeMode = ImeMode.NoControl;
            entrada_5.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_5.Location = new Point(96, 352);
            entrada_5.Margin = new Padding(0);
            entrada_5.Name = "entrada_5";
            entrada_5.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_5.Size = new Size(60, 60);
            entrada_5.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_5.TabIndex = 13;
            entrada_5.Text = "5";
            entrada_5.TextColor = Color.White;
            entrada_5.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_4
            // 
            entrada_4.BackColor = Color.Transparent;
            entrada_4.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_4.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_4.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_4.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_4.Font = new Font("Segoe UI", 18F);
            entrada_4.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_4.ImeMode = ImeMode.NoControl;
            entrada_4.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_4.Location = new Point(22, 352);
            entrada_4.Margin = new Padding(0);
            entrada_4.Name = "entrada_4";
            entrada_4.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_4.Size = new Size(60, 60);
            entrada_4.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_4.TabIndex = 12;
            entrada_4.Text = "4";
            entrada_4.TextColor = Color.White;
            entrada_4.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_soma
            // 
            entrada_soma.BackColor = Color.Transparent;
            entrada_soma.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_soma.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_soma.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_soma.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_soma.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entrada_soma.HoverTextColor = Color.FromArgb(66, 140, 25);
            entrada_soma.ImeMode = ImeMode.NoControl;
            entrada_soma.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_soma.Location = new Point(232, 424);
            entrada_soma.Margin = new Padding(0);
            entrada_soma.Name = "entrada_soma";
            entrada_soma.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_soma.Size = new Size(60, 60);
            entrada_soma.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_soma.TabIndex = 11;
            entrada_soma.Text = "+";
            entrada_soma.TextColor = Color.FromArgb(103, 194, 58);
            entrada_soma.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_3
            // 
            entrada_3.BackColor = Color.Transparent;
            entrada_3.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_3.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_3.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_3.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_3.Font = new Font("Segoe UI", 18F);
            entrada_3.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_3.ImeMode = ImeMode.NoControl;
            entrada_3.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_3.Location = new Point(161, 424);
            entrada_3.Margin = new Padding(0);
            entrada_3.Name = "entrada_3";
            entrada_3.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_3.Size = new Size(60, 60);
            entrada_3.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_3.TabIndex = 10;
            entrada_3.Text = "3";
            entrada_3.TextColor = Color.White;
            entrada_3.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_2
            // 
            entrada_2.BackColor = Color.Transparent;
            entrada_2.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_2.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_2.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_2.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_2.Font = new Font("Segoe UI", 18F);
            entrada_2.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_2.ImeMode = ImeMode.NoControl;
            entrada_2.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_2.Location = new Point(96, 424);
            entrada_2.Margin = new Padding(0);
            entrada_2.Name = "entrada_2";
            entrada_2.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_2.Size = new Size(60, 60);
            entrada_2.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_2.TabIndex = 9;
            entrada_2.Text = "2";
            entrada_2.TextColor = Color.White;
            entrada_2.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_1
            // 
            entrada_1.BackColor = Color.Transparent;
            entrada_1.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_1.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_1.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_1.Font = new Font("Segoe UI", 18F);
            entrada_1.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_1.ImeMode = ImeMode.NoControl;
            entrada_1.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_1.Location = new Point(22, 424);
            entrada_1.Margin = new Padding(0);
            entrada_1.Name = "entrada_1";
            entrada_1.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_1.Size = new Size(60, 60);
            entrada_1.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_1.TabIndex = 8;
            entrada_1.Text = "1";
            entrada_1.TextColor = Color.White;
            entrada_1.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_resultado
            // 
            entrada_resultado.BackColor = Color.Transparent;
            entrada_resultado.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_resultado.ButtonType = ReaLTaiizor.Util.HopeButtonType.Success;
            entrada_resultado.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_resultado.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_resultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            entrada_resultado.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_resultado.ImeMode = ImeMode.NoControl;
            entrada_resultado.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_resultado.Location = new Point(232, 496);
            entrada_resultado.Margin = new Padding(0);
            entrada_resultado.Name = "entrada_resultado";
            entrada_resultado.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_resultado.Size = new Size(60, 60);
            entrada_resultado.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_resultado.TabIndex = 7;
            entrada_resultado.Text = "=";
            entrada_resultado.TextColor = Color.White;
            entrada_resultado.WarningColor = Color.FromArgb(230, 162, 60);
            entrada_resultado.Click += hopeRoundButton4_Click;
            // 
            // entrada_virgula
            // 
            entrada_virgula.BackColor = Color.Transparent;
            entrada_virgula.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_virgula.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_virgula.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_virgula.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_virgula.Font = new Font("Segoe UI", 18F);
            entrada_virgula.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_virgula.ImeMode = ImeMode.NoControl;
            entrada_virgula.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_virgula.Location = new Point(161, 496);
            entrada_virgula.Margin = new Padding(0);
            entrada_virgula.Name = "entrada_virgula";
            entrada_virgula.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_virgula.Size = new Size(60, 60);
            entrada_virgula.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_virgula.TabIndex = 6;
            entrada_virgula.Text = ",";
            entrada_virgula.TextColor = Color.White;
            entrada_virgula.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_0
            // 
            entrada_0.BackColor = Color.Transparent;
            entrada_0.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_0.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_0.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_0.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_0.Font = new Font("Segoe UI", 18F);
            entrada_0.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_0.ImeMode = ImeMode.NoControl;
            entrada_0.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_0.Location = new Point(96, 496);
            entrada_0.Margin = new Padding(0);
            entrada_0.Name = "entrada_0";
            entrada_0.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_0.Size = new Size(60, 60);
            entrada_0.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_0.TabIndex = 5;
            entrada_0.Text = "0";
            entrada_0.TextColor = Color.White;
            entrada_0.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // entrada_menos
            // 
            entrada_menos.BackColor = Color.Transparent;
            entrada_menos.BorderColor = Color.FromArgb(220, 223, 230);
            entrada_menos.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            entrada_menos.DangerColor = Color.FromArgb(245, 108, 108);
            entrada_menos.DefaultColor = Color.FromArgb(255, 255, 255);
            entrada_menos.Font = new Font("Segoe UI", 18F);
            entrada_menos.HoverTextColor = Color.FromArgb(224, 224, 224);
            entrada_menos.ImeMode = ImeMode.NoControl;
            entrada_menos.InfoColor = Color.FromArgb(144, 147, 153);
            entrada_menos.Location = new Point(22, 496);
            entrada_menos.Margin = new Padding(0);
            entrada_menos.Name = "entrada_menos";
            entrada_menos.PrimaryColor = Color.FromArgb(27, 36, 38);
            entrada_menos.Size = new Size(60, 60);
            entrada_menos.SuccessColor = Color.FromArgb(103, 194, 58);
            entrada_menos.TabIndex = 4;
            entrada_menos.Text = "+/-";
            entrada_menos.TextColor = Color.White;
            entrada_menos.WarningColor = Color.FromArgb(230, 162, 60);
            entrada_menos.Click += hopeRoundButton2_Click;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(290, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 2;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverMaximize1
            // 
            foreverMaximize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverMaximize1.BackColor = Color.White;
            foreverMaximize1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverMaximize1.DefaultLocation = true;
            foreverMaximize1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverMaximize1.Font = new Font("Marlett", 12F);
            foreverMaximize1.Location = new Point(266, 16);
            foreverMaximize1.Name = "foreverMaximize1";
            foreverMaximize1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverMaximize1.Size = new Size(18, 18);
            foreverMaximize1.TabIndex = 1;
            foreverMaximize1.Text = "foreverMaximize1";
            foreverMaximize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // foreverMinimize1
            // 
            foreverMinimize1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverMinimize1.BackColor = Color.White;
            foreverMinimize1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverMinimize1.DefaultLocation = true;
            foreverMinimize1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverMinimize1.Font = new Font("Marlett", 12F);
            foreverMinimize1.Location = new Point(242, 16);
            foreverMinimize1.Name = "foreverMinimize1";
            foreverMinimize1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverMinimize1.Size = new Size(18, 18);
            foreverMinimize1.TabIndex = 0;
            foreverMinimize1.Text = "foreverMinimize1";
            foreverMinimize1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 569);
            Controls.Add(Formulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            Formulario.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm Formulario;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.ForeverMaximize foreverMaximize1;
        private ReaLTaiizor.Controls.ForeverMinimize foreverMinimize1;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_menos;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_resultado;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_virgula;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_0;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_divisao;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_porcentagem;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_parenteses;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_clear;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_multiplicacao;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_9;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_8;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_7;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_subtração;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_6;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_5;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_4;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_soma;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_3;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_2;
        private ReaLTaiizor.Controls.HopeRoundButton entrada_1;
        private ReaLTaiizor.Controls.ForeverTextBox entrada;
        private ListBox saida;
    }
}
