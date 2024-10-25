using System;
using Microsoft.Maui.Controls;

namespace jchicangoExamen.Views;

public partial class Login : ContentPage
{
    private readonly string[,] users = new string[,]
       {
            { "estudiante", "moviles" },
            { "uisrael", "2024" }
       };

    public Login()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        if (ValidateLogin(username, password))
        {
            ResultLabel.Text = "¡Login exitoso!";
            Navigation.PushAsync(new Views.Registro(username));


        }
        else
        {
            ResultLabel.Text = "Usuario o contraseña incorrectos.";
        }
    }

    private bool ValidateLogin(string username, string password)
    {
        for (int i = 0; i < users.GetLength(0); i++)
        {
            if (users[i, 0] == username && users[i, 1] == password)
            {
                return true;
            }
        }
        return false;
    }
}

