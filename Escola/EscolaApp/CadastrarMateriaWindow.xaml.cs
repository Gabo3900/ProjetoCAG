using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EscolaApp
{
    /// <summary>
    /// Lógica interna para CadastrarMateriaWindow.xaml
    /// </summary>
    public partial class CadastrarMateriaWindow : Window
    {
        NDisciplina n = new NDisciplina();
        public CadastrarMateriaWindow()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Disciplina d = new Disciplina();
            d.Nome = txtMateria.Text;
            d.CargaHoraria = txtCarga.Text;
            n.Inserir(d);
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.Listar();
        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            Disciplina d = grid.SelectedItem as Disciplina;
            if (d != null)
            {
                d.Nome = txtMateria.Text;
                d.CargaHoraria = txtCarga.Text;
                n.Atualizar(d);
            }
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            Disciplina d = grid.SelectedItem as Disciplina;
            if (d != null)
            {
                n.Excluir(d);
            }
        }
    }
}
