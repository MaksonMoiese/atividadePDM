using ProjetoElemento.Models;
using ProjetoElemento.View;
using System.Collections.ObjectModel;


namespace ProjetoElemento
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Pessoa> pessoas = new ObservableCollection<Pessoa>();
        
         public MainPage()
        {
            InitializeComponent();
        }

        public void Salvar(object sender, EventArgs e)
        {

            var novaPessoa = new Pessoa
            {
                Nome = nome.Text,
                Cpf = cpf.Text,
                Endereco = endereco.Text,  
                Senha = senha.Text,
            };
            pessoas.Add(novaPessoa);

            var resposta = novaPessoa.Salva(novaPessoa);
            DisplayAlert("Aviso",resposta,"Ok");
            ApagaTudo();    


        }


        
        public async void Novo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Show(pessoas));
        }
        public async void Limpar(object sender, EventArgs e)
        {
            var resposta = await DisplayAlert("Tem Certeza?",
                "Todo o conteúdo do formulário será perdido",
                "sim", "não");
            if (resposta)
            {
                ApagaTudo();

                 await DisplayAlert("Apagou", "Tudo foi apagado", "OK");
            }
        }

        public void ApagaTudo()
        {
            nome.Text = "";
            cpf.Text = "";
            endereco.Text = "";
            senha.Text = "";
        }

    }

}