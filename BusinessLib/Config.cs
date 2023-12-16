using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLib;

// public class of config
public class Config
{
    // the connection string
    public const string ConnectionString = """
                                           Server=skeena.database.windows.net;
                                           Initial Catalog=comp3602;
                                           User ID=student;
                                           Password=93nu5/crNKX;
                                           TrustServerCertificate=False;
                                           Connection Timeout=30;
                                           """;
}
