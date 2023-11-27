namespace MyFirstMobileApp.Models.Entities
{
    public class FlowerSpeciesInfo
    {
        //Properties - Initialized to an Empty String
        public string FlowerName { get; set; } = string.Empty;
        public ImageSource FlowerImage { get; set; } = null;
        public string FlowerNumber { get; set; } = string.Empty;

        public FlowerSpeciesInfo() 
        {
            //Constructor
        }

        public FlowerSpeciesInfo(string flowerName, ImageSource flowerImage, string flowerNumber)
        {
            //Constructor with Parameters
            FlowerName = flowerName;
            FlowerImage = flowerImage;
            FlowerNumber = flowerNumber;
        }

        ///<summary>
        /// Retrieves a list of sample flower data, each representing an flower's name, an image URL, and the flower they portray.
        ///</summary>
        ///<returns>A list of FlowerSpeciesInfo objects containing sample data.</returns>
        public static List<FlowerSpeciesInfo> GetSampleFlowerData()
        {
            var flowers = new List<FlowerSpeciesInfo>
            {
                // Create ActorCharacterInfo objects with sample data
                new FlowerSpeciesInfo("Lily of the Valley", ImageSource.FromFile("Resources/Images/lily.jpg"), "Lily"),
                new FlowerSpeciesInfo("Lotus", ImageSource.FromFile("Resources/Images/hib.jpg"), "Hibiscus"),
                new FlowerSpeciesInfo("Hibiscus", ImageSource.FromFile("Resources/Images/lotus.jpg"), "Lotus"),
            };

            return flowers;
        }

        ///<summary>
        ///Retrieves a list of flower names from the sample flower data.
        ///</summary>
        ///<returns>A list of flower names extracted from the sample data.</returns>
        public static List<string> GetFlowerNames()
        {
            // Get the sample flower data
            var sampleData = GetSampleFlowerData();

            // Select and convert flower names to a list
            return sampleData.Select(info => info.FlowerNumber).ToList();
        }

    }
}
