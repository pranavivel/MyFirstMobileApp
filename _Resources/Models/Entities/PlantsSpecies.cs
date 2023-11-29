namespace MyFirstMobileApp.Models.Entities
{
    public class PlantsSpecies
    {
        public string NameofPlant { get; set; }

        //Image Buttons
        public ImageSource EditButton { get; } = Buttons.ButtonEdit;
        public ImageSource DeleteButton { get; } = Buttons.ButtonDelete;

        public PlantsSpecies()
        {

        }

        public PlantsSpecies(string name)
        {
            NameofPlant = name;
        }

        public static List<PlantsSpecies> GetPlants()
        {
            return new List<PlantsSpecies>
            {
                new PlantsSpecies("Flowers"),
                new PlantsSpecies("Trees"),
            };
        }
    }
}
