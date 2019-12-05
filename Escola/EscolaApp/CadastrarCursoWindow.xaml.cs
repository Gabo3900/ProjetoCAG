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
    /// Lógica interna para CadastrarCursoWindow.xaml
    /// </summary>
    public partial class CadastrarCursoWindow : Window
    {
        private NCurso n = new NCurso();
        public CadastrarCursoWindow()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Curso c = new Curso();
            c.Nome = txtCurso.Text;
            n.Inserir(c);
            grid.ItemsSource = n.Listar();
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.Listar();
        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            Curso a = grid.SelectedItem as Curso;
            if(a != null)
            {
                a.Nome = txtCurso.Text;
                n.Atualizar(a);
            }
            else MessageBox.Show("Nenhum item foi selecionado!");
            grid.ItemsSource = n.Listar();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            Curso a = grid.SelectedItem as Curso;
            if (a != null)
            {
                n.Excluir(a);
            }
            else MessageBox.Show("Nenhum item foi selecionado!");
            grid.ItemsSource = n.Listar();
        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                Curso c = grid.SelectedItem as Curso;
                txtCurso.Text = c.Nome;
            }
        }
    }
}
