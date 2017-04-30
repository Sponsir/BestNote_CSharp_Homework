using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BestNote_cs
{
    public class DataManagerFactor
    {
        public const int DATASAVE_MODE_MYSQL = 0;

        public static DataManager createDataManager(int dataSaveMode)
        {
            switch (dataSaveMode)
            {
                case DATASAVE_MODE_MYSQL:
                    return new DataManagerByMySQL();
                default:
                    throw new Exception("You used a wrong save mode");
            }
        }
    }
}