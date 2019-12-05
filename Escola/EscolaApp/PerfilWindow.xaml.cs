using Modelo;
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
    }
}
