using Microsoft.Maui.Controls;
using ProjetoElemento.Models;
using System.Collections.ObjectModel;

namespace ProjetoElemento
{
    public partial class Cadastro : ContentPage
    {
        ObservableCollection<Animal> listaAnimais = new ObservableCollection<Animal>();
        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(ObservableCollection<Animal> listaAnimais)
        {
        }

        private void Salvar(object sender, EventArgs e)
        {
            var animal = new Animal
            {
                Nome = nome.Text,
                Idade = idade.Text,
                Dono = dono.Text,
                Especie = especie.Text,
                Motivo = motivo.Text,
            };
            var resposta = animal.Salva(animal);
            listaAnimais.Add(animal);

            DisplayAlert("Aviso", resposta, "OK");
            ApagaTudo();
        }

        private void Limpar(object sender, EventArgs e)
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
            idade.Text = "";
            dono.Text = "";
            especie.Text = "";
            motivo.Text = "";
        }
    }
}
