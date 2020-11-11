using System.Collections.Generic;
using Architecture.Models;

namespace Architecture.Data
{
    public interface IArchitectureRepo
    {
        IEnumerable<Flower> GetBouquet();
        Command GetBouquetById(int id);
    }
}