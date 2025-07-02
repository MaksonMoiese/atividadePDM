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
            InitializeComponent();
            this.listaAnimais = listaAnimais;
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
        }

        private void Limpar(object sender, EventArgs e) 
        {
            nome.Text = string.Empty;
            idade.Text = string.Empty;
            dono.Text = string.Empty;
            especie.Text = string.Empty;
            motivo.Text = string.Empty;

            DisplayAlert("Aviso", "Campos Limpos com sucesso", "OK");
        }
    }
}
