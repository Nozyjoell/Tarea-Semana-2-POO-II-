using Calculadora.Controladores;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double primero;
        double segundo;
        String Operacion;

        public Form1()
        {
            InitializeComponent();
        }

        Controladores.Clase_Suma S = new Controladores.Clase_Suma();
        Controladores.Clase_Resta R = new Controladores.Clase_Resta();
        Controladores.Clase_Multiplicacion M = new Controladores.Clase_Multiplicacion();
        Controladores.Clase_Division D = new Controladores.Clase_Division();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_0_Click_1(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "0";
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "1";
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "2";
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "3";
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "4";
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "5";
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "6";
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "7";
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "8";
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + "9";
        }

        private void Btn_punto_Click(object sender, EventArgs e)
        {
            Caja_texto.Text = Caja_texto.Text + ".";
        }

        private void Btn_CE_Click(object sender, EventArgs e)
        {
            Caja_texto.Clear();
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            Operacion = "/";
            primero = double.Parse(Caja_texto.Text);
            Caja_texto.Clear();
        }

        private void Btn_multi_Click(object sender, EventArgs e)
        {
            Operacion = "*";
            primero = double.Parse(Caja_texto.Text);
            Caja_texto.Clear();
        }

        private void Btn_resta_Click(object sender, EventArgs e)
        {
            Operacion = "-";
            primero = double.Parse(Caja_texto.Text);
            Caja_texto.Clear();
        }

        private void Btn_suma_Click(object sender, EventArgs e)
        {
            Operacion = "+";
            primero = double.Parse(Caja_texto.Text);
            Caja_texto.Clear();
        }

        private void Btn_igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Caja_texto.Text);

            double sum;
            double res;
            double division;
            double multiplicar;

            switch (Operacion)
            {
                case "+":
                    sum = S.Sumar(primero, segundo);
                    Caja_texto.Text = sum.ToString();
                    break;
                case "-":
                    res = R.Restar(primero, segundo);
                    Caja_texto.Text = res.ToString();
                    break;
                case "*":
                    multiplicar = M.Multi(primero, segundo);
                    Caja_texto.Text = multiplicar.ToString();
                    break;
                case "/":
                    division = D.Div(primero, segundo);
                    Caja_texto.Text = division.ToString();
                    break;
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (Caja_texto.Text.Length == 1)
                Caja_texto.Text = "";
            else
                Caja_texto.Text = Caja_texto.Text.Substring(0, Caja_texto.Text.Length - 1);
        }
    }
}
