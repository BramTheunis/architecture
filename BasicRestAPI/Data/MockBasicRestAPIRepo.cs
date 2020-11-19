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



        public IEnumerable<Store> GetStore()
        {
            var stores = new List<Store>
            {
                new Store{Id=0, Name="Winkel0", Street="straat0", Number=0, Region="regio0"},
                new Store{Id=1, Name="Winkel1", Street="straat1", Number=1, Region="regio1"},
                new Store{Id=2, Name="Winkel2", Street="straat2", Number=2, Region="regio2"}
            };

            return stores;
        }

        public Store GetStoreById(int id)
        {
            return new Store{Id=0, Name="Winkel0", Street="straat0", Number=0, Region="regio0"};
        }
    }
}