
namespace CalculadoraBásica;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCalcularCliked(object sender, EventArgs e)
    {
        if(!double.TryParse(Num1Entry.Text, out double numero1) ||
           !double.TryParse(Num2Entry.Text, out double numero2))
        {
            ResultadoLabel.Text = "Por favor, insira números válidos! ";
            return;
        }
        
        if(OperacaoEscolhida.SelectedIndex == -1)
        {
            ResultadoLabel.Text = "Selecione uma operação.";
            return;
        }

        String operacao = OperacaoEscolhida.SelectedItem.ToString();
        double resultado = 0;

        switch (operacao)
        {
            case "Somar":
                resultado = numero1 + numero2;
                break;

            case "Subtrair":
                resultado = numero1 - numero2;
                break;

            case "Multiplicar":
                resultado = numero1 * numero2;
                break;

            case "Dividir":
                if(numero2 == 0)
                {
                    ResultadoLabel.Text = "Não é possivel dividir por zero.";
                    return;
                }
               
                    resultado = numero1 / numero2;
                    break;
        }
        ResultadoLabel.Text = $"Resultado: {resultado}";
    }
}


