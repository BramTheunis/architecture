using System.Collections.Generic;
using BasicRestAPI.Models;

namespace BasicRestAPI.Data
{
    public class MockBasicRestAPIRepo : IBasicRestAPIRepo
    {
        public IEnumerable<Bouquet> GetBouquet()
        {
            var bouquets = new List<Bouquet>
            {
                new Bouquet{Id=0, Name="orchidee", Price=5, Description="mooie bloemen"},
                new Bouquet{Id=1, Name="roos", Price=7, Description="rode bloemen"},
                new Bouquet{Id=2, Name="mix", Price=15, Description="verschillende bloemen"}
            };

            return bouquets;
        }

        public Bouquet GetBouquetById(int id)
        {
            return new Bouquet{Id=0, Name="orchidee", Price=5, Description="mooie bloemen"};
        }
    }
}