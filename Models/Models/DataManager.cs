using Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DataManager
    {
        public DataManager(IRecordRep records)
        {
            Records = records;

        }
        public IRecordRep Records { get; init; }
    }
}
