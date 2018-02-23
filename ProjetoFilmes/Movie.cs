namespace ProjetoFilmes
{
    class Movie
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }

        public Movie(string name, string genre, string director)
        {
            Name = name;
            Genre = genre;
            Director = director;
        }
    }
}