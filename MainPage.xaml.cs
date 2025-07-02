using ProjetoElemento.Models;
using System.Collections.ObjectModel;
using ProjetoElemento.View;


namespace ProjetoElemento
{
    public partial class MainPage : ContentPage
    {
        //List<Pessoa> listaPessoas = new List<Pessoa>();
        ObservableCollection<Animal> listaAnimais = new ObservableCollection<Animal>();
        public MainPage()
        {
            InitializeComponent();
            
        }

        public async void Mostrar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Show(listaAnimais));
        }

        public async void Cadastrar(object? sender, EventArgs e) // Add nullable annotation to sender
        {
            await Navigation.PushAsync(new Cadastro(listaAnimais));
        }
    }

}