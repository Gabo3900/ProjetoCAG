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
    /// Lógica interna para CadastrarTurmaWindow.xaml
    /// </summary>
    public partial class CadastrarTurmaWindow : Window
    {
        NTurma n = new NTurma(); 
        public CadastrarTurmaWindow()
        {
            InitializeComponent();
            NCurso c = new NCurso();
            box.ItemsSource = c.Listar();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Turma t = new Turma();
            t.Codigo = txtTurma.Text;
            t.CursoId = (box.SelectedItem as Curso).Id;
            n.Inserir(t);
            grid.ItemsSource = n.Listar();
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.Listar();
        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            Turma a = grid.SelectedItem as Turma;
            if (a != null)
            {
                a.Codigo = txtTurma.Text;
                n.Atualizar(a);
            }
            grid.ItemsSource = n.Listar();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            Turma a = grid.SelectedItem as Turma;
            if (a != null)
            {
                n.Excluir(a);
            }
            grid.ItemsSource = n.Listar();
        }
    }
}
