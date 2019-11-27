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
    /// Lógica interna para AdministradorWindow.xaml
    /// </summary>
    public partial class AdministradorWindow : Window
    {
        public AdministradorWindow()
        {
            InitializeComponent();
        }

        private void Curso_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCursoWindow w = new CadastrarCursoWindow();
            w.Show();
        }

        private void Turma_Click(object sender, RoutedEventArgs e)
        {
            CadastrarTurmaWindow w = new CadastrarTurmaWindow();
            w.Show();
        }

        private void Aluno_Click(object sender, RoutedEventArgs e)
        {
            CadastrarAlunoWindow w = new CadastrarAlunoWindow();
            w.Show();
        }

        private void Materia_Click(object sender, RoutedEventArgs e)
        {
            CadastrarMateriaWindow w = new CadastrarMateriaWindow();
            w.Show();
        }

        private void Exit(object sender, EventArgs e)
        {
            MainWindow w = new MainWindow();
            w.Show();
        }

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
