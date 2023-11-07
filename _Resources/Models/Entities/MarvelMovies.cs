namespace MyFirstMobileApp.Models.Entities
{
    public class Plants
    {
        public string NameofPlant { get; set; }

        //Image Buttons
        public ImageSource EditButton { get; } = Buttons.ButtonEdit;
        public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;

        public Plants()
        {

        }

        public Plants(string name)
        {
            NameofPlant = name;
        }

        public static List<Plants> GetMovies()
        {
            return new List<Plants>
            {
                new Plants("Flowers"),
                new Plants("Trees"),
            };
        }
    }
}
