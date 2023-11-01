namespace MyFirstMobileApp.Models.Entities
{
    public class KungFuPandaMovies
    {
        public string NameofMovie { get; set; }

        //Image Buttons
        public ImageSource EditButton { get; } = Buttons.ButtonEdit;
        public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;

        public KungFuPandaMovies()
        {

        }

        public KungFuPandaMovies(string name)
        {
            NameofMovie = name;
        }

        public static List<KungFuPandaMovies> GetMovies()
        {
            return new List<KungFuPandaMovies>
            {
                new KungFuPandaMovies("Kung Fu Panda"),
                new KungFuPandaMovies("Kung Fu Panda 2"),
                new KungFuPandaMovies("Kung Fu Panda 3"),
                new KungFuPandaMovies("Kung Fu Panda 4"),
            };
        }
    }
}
