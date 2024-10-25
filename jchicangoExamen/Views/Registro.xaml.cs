namespace jchicangoExamen.Views;

public partial class Registro : ContentPage
{
    string user_global = "";
    public Registro(string username)
    {
        InitializeComponent();
        lblUsuario.Text = "USUARIO CONECTADO " + username;
        user_global = username;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {

        if (double.TryParse(entryMontoInicial.Text, out double montoInicial) && montoInicial <= 1500)
        {

            double costoTotal = 1500.0;


            double saldoRestante = costoTotal - montoInicial;

            if (saldoRestante > 0)
            {

                double cuotaBase = saldoRestante / 4;
                double cuotaFinal = cuotaBase + (cuotaBase * 0.04);
                entryMontoInicial.Text = cuotaFinal.ToString("F2");
                entryPagoMensual.Text = cuotaFinal.ToString("F2");
            }
            else
            {
                DisplayAlert("Error", "El monto inicial no puede ser mayor o igual al costo total del curso.", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Por favor, ingrese un monto inicial válido (máximo 1500).", "OK");
        }


    }

    
}