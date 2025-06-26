using ProjetoElemento.Models;
using ProjetoElemento.View;
using System.Collections.ObjectModel;


namespace ProjetoElemento
{
    public partial class MainPage : ContentPage
    {
        //List<Pessoa> listaPessoas = new List<Pessoa>();
        ObservableCollection<Pessoa> listaPessoas = new ObservableCollection<Pessoa>();
       
        
         public MainPage()
        {
            InitializeComponent();
        }

        public void Salvar(object sender, EventArgs e)
        {
            var pessoa = new Pessoa
            {
                Nome = nome.Text,
                Cpf = cpf.Text,
                Endereco = endereco.Text,
                Senha = senha.Text,
            };
            var resposta = pessoa.Salva(pessoa);
            listaPessoas.Add(pessoa);

            DisplayAlert("Aviso", resposta, "OK");
            ApagaTudo();

        }


        
        public async void Novo(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Show(listaPessoas));
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