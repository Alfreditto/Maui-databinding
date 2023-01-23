using System.ComponentModel;
using Maui_databinding.Models;

namespace Maui_databinding;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    Persona persona = new Persona();

	public MainPage()
	{
		InitializeComponent();

        persona = new Persona
        {
			Nombre = "Jossé",
			Telefono = "22222",
			Direccion = "Calle 2"
        };
        BindingContext = persona;
    }


    private void BtnProbar_Clicked(object sender, EventArgs e)
    {
        /*persona.Nombre = "Luisa";
        persona.Telefono = "00000";
        persona.Direccion = "Calle 9";*/

        persona = new Persona
        {
            Nombre = "Luisa",
            Telefono = "00000",
            Direccion = "Otrakjfbgisa"
        };
    }
}

