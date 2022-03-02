using Models.Entities;
using Models.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.DataProviders.DataTest
{

    public class RecordRep : IRecordRep
    {
        private Record[] _records;
        public RecordRep() 
        {
            _records = new Record[4]
            {
                new Record {Id = Guid.NewGuid()},
                new Record {Id = Guid.NewGuid(), Name = "Petya"},
                new Record {Id = Guid.NewGuid(), Number = 13},
                new Record {Id = Guid.NewGuid(), Name = "Vasya", Number = 7}
                
            };
        }

        public Record[] Items => _records;

        public void Delete(Record item)
        {
            for (int i = 0; i < _records.Length; i++)
            {
                if(item.Id == _records[i].Id)
                {
                    _records[i] = null; 
                    return;
                }

            }
        }

        public Record Find(Guid id)
        { 
            for (int i = 0; i < _records.Length; i++)
            {
                if(id == _records[i].Id)
                {
                    return _records[i];
                }
            }
            return null;
        }

        public void Update(Record item)
        {
            Record result = Find(item.Id);

            if(result is null)
            {
                Record[] buff = new Record[_records.Length + 1];
                for (int i = 0; i < _records.Length; i++)
                {
                    buff[i] = _records[i];

                }
                buff[_records.Length] = item;
                _records = buff;
            }
            else if(result != item)
            {
                result = item;
            }

        }
    }
}
