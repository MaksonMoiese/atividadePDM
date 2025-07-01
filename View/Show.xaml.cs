using ProjetoElemento.Models;
using System.Collections.ObjectModel;


namespace ProjetoElemento.View;

public partial class Show : ContentPage
{
	public Show(ObservableCollection<Animal> animal)
	{
        InitializeComponent();
		listaAnimais.ItemsSource = animal;
		    
    }
}