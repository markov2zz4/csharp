using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repos
{
    public interface IRecordRep
    {
        Record[] Items { get; }
        Record Find(Guid id);
        void Delete(Record item);
        void Update(Record item);
    }
}
