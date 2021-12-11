using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointsBet.Test

{
    public interface IDatabaseConnector
    {
        IDatabase ConnectDB(string databaseRepoURL);

       
    }
}
