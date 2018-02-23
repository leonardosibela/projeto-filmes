using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace ProjetoFilmes
{
    public partial class MainWindow : Window
    {
        private List<Movie> movies = new List<Movie>();

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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string genre = txtGenre.Text;
            string director = txtDirector.Text;
            
            movies.Add(new Movie(name, genre, director));
            movies = movies.OrderBy(m => m.Name).ToList();
            dtgMovies.ItemsSource = movies;

        }
    }
}