using SQLite;

namespace MyFirstMobileApp.Models.DataAccess
{
    public class Vacation
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public int Visited { get; set; } = 0;
    }
}
