namespace MyFirstMobileApp.Models.Entities
{
    public class MarvelMovies
    {
        public string NameofMovie { get; set; }

        //Image Buttons
        public ImageSource EditButton { get; } = Buttons.ButtonEdit;
        public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;

        public MarvelMovies()
        {

        }

        public MarvelMovies(string name)
        {
            NameofMovie = name;
        }

        public static List<MarvelMovies> GetMovies()
        {
            return new List<MarvelMovies>
            {
                new MarvelMovies("Guardians of The Galaxy"),
                new MarvelMovies("Spiderman"),
                new MarvelMovies("The Hulk"),
                new MarvelMovies("Iron Man"),
                new MarvelMovies("Batman"),
                new MarvelMovies("Aquaman"),
                new MarvelMovies("Superman"),
                new MarvelMovies("Wonder Woman")
            };
        }
    }
}
