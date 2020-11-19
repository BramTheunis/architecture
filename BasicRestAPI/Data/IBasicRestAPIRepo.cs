using System.Collections.Generic;
using BasicRestAPI.Models;

namespace BasicRestAPI.Data
{
    public interface IBasicRestAPIRepo
    {
        IEnumerable<Bouquet> GetBouquet();
        Bouquet GetBouquetById(int id);

        IEnumerable<Store> GetStore();
        Store GetStoreById(int id);
    }
}