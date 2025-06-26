using ProjetoElemento.Models;
using System.Collections.ObjectModel;

namespace ProjetoElemento.View;

public partial class Show : ContentPage
{
	public Show(ObservableCollection<Pessoa> pessoa)
	{
		InitializeComponent();
		listaPessoas.ItemsSource = pessoa;
		    
    }
}