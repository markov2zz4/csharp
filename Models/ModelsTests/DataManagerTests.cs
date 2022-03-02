using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Models.DataProviders.DataTest;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Tests
{
    [TestClass()]
    public class DataManagerTests
    {
        [TestMethod()]
        public void DataManager_Crud_Success()
        {
            DataManager data = new DataManager(new RecordRep());

            
            Assert.IsTrue(data.Records.Items.Length == 4);


            Guid id = Guid.NewGuid();
            var masha = new Record() { Id = id, Name = "Masha", Number = 0 };
            data.Records.Update(masha);
            Assert.IsTrue(data.Records.Items[data.Records.Items.Length - 1] == masha);

            var rec = data.Records.Items[2];
        }
    }
}