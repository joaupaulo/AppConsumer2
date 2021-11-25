using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppConsumer.DatabaseSettings
{
    public interface IAppConsumerDatabase
    {
        string ProdutosCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
