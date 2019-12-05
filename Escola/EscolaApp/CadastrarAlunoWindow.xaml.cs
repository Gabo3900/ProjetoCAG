using Microsoft.Win32;
using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica interna para CadastrarAlunoWindow.xaml
    /// </summary>
    public partial class CadastrarAlunoWindow : Window
    {
        NAluno n = new NAluno();
        private string foto = "";
        public CadastrarAlunoWindow()
        {
            InitializeComponent();
            NTurma t = new NTurma();
            box.ItemsSource = t.Listar();
        }

        private void Foto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
            if (w.ShowDialog().Value)
            {
                byte[] b = File.ReadAllBytes(w.FileName);
                foto = Convert.ToBase64String(b);

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();

                image.Source = bi;
            }
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = n.Listar();
        }

        private void Inserir_Click(object sender, RoutedEventArgs e)
        {
            Aluno a = new Aluno();
            a.Nome = txtAluno.Text;
            a.Senha = txtSenha.Password;
            a.Email = txtEmail.Text;
            a.Foto = foto;
            a.Matricula = txtMatricula.Text;
            a.Cpf = txtCpf.Text;
            a.TurmaId = (box.SelectedItem as Turma).Id;
            n.Inserir(a);
            grid.ItemsSource = n.Listar();
        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            Aluno a = grid.SelectedItem as Aluno;
            if (a != null)
            {
                a.Nome = txtAluno.Text;
                a.Senha = txtSenha.Password;
                a.Email = txtEmail.Text;
                a.Foto = foto;
                a.Matricula = txtMatricula.Text;
                a.Cpf = txtCpf.Text;
                a.TurmaId = (box.SelectedItem as Turma).Id;
                n.Atualizar(a);
            }
            grid.ItemsSource = n.Listar();
        }

        private void Excluir_Click(object sender, RoutedEventArgs e)
        {
            Aluno a = grid.SelectedItem as Aluno;
            if (a != null)
            {
                n.Excluir(a);
            }
            grid.ItemsSource = n.Listar();
        }

        private void Grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (grid.SelectedItem != null)
            {
                Aluno a = grid.SelectedItem as Aluno;
                txtAluno.Text = a.Nome;
                txtSenha.Password = a.Senha;
                txtEmail.Text = a.Email;
                txtMatricula.Text = a.Matricula;
                txtCpf.Text = a.Cpf;
                byte[] b = Convert.FromBase64String(a.Foto);
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();
                image.Source = bi;
            }
        }
    }
}
