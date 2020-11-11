using System.Collections.Generic;
using BasicRestAPI.Models;

namespace BasicRestAPI.Data
{
    public interface IBasicRestAPIRepo
    {
        IEnumerable<Bouquet> GetBouquet();
        Bouquet GetBouquetById(int id);
    }
}