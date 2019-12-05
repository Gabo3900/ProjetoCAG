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
    /// Lógica interna para PerfilWindow.xaml
    /// </summary>
    public partial class PerfilWindow : Window
    {
        private Aluno aluno;
        private NAluno n = new NAluno();
        public PerfilWindow(Aluno a)
        {
            InitializeComponent();
            aluno = a;
            txtNome.Text = a.Nome;
            txtMatricula.Text = a.Matricula;
            txtEmail.Text = a.Email;
            txtCpf.Text = a.Cpf;
            byte[] b = Convert.FromBase64String(a.Foto);
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = new MemoryStream(b);
            bi.EndInit();

            image.Source = bi;
        }

        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            InputBox box = new InputBox(txtEmail.Text);
            if (box.ShowDialog().Value)
            {
                txtEmail.Text = box.Input;
                aluno.Email = box.Input;
                n.Atualizar(aluno);
            }
        }

        private void Senha_Click(object sender, RoutedEventArgs e)
        {
            InputBox box = new InputBox(txtEmail.Text);
            if (box.ShowDialog().Value)
            {
                aluno.Senha = box.Input;
                n.Atualizar(aluno);
            }
        }

        private void Foto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog w = new OpenFileDialog();
            w.Filter = "Arquivos Jpg|*.jpg";
            if (w.ShowDialog().Value)
            {
                byte[] b = File.ReadAllBytes(w.FileName);
                aluno.Foto = Convert.ToBase64String(b);

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = new MemoryStream(b);
                bi.EndInit();

                image.Source = bi;
            }
            n.Atualizar(aluno);
        }
    }
}
