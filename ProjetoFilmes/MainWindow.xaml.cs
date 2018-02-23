using System.Windows;

namespace ProjetoFilmes
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            txtName.Text = "";
            txtGenre.Text = "";
            txtDirector.Text = "";
        }
    }
}