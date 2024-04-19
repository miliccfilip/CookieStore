using BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Shared.DataInterface;
using Shared.Models;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class BillBusinessTest
    {
        private Mock<IBillRepository> mockBillRepository = new Mock<IBillRepository>();

        private Bill bill1 = new Bill
        {
            Date = DateTime.Now,
            Id = 15,
            Id_Stuff = 35,
            Total = 121511
        };
        private Bill bill2 = new Bill
        {
            Date = DateTime.Now,
            Id = 32,
            Id_Stuff = 11,
            Total = 1012
        };
        private Bill bill3 = new Bill
        {
            Date = DateTime.Now,
            Id = 5,
            Id_Stuff = 2,
            Total = 2352
        };
        private BillBusiness billBusiness;
        private List<Bill> list = new List<Bill>();

        public BillBusinessTest()
        {
            list.Add(bill1);
            list.Add(bill2);
            list.Add(bill3);
        }

        [TestMethod]
        public void GetAllBillsTest()
        {
            mockBillRepository.Setup(a => a.GetAllBills()).Returns(list);
            this.billBusiness = new BillBusiness(mockBillRepository.Object);
            var result = billBusiness.GetAllBills();
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void UpdateBillTest()
        {
            mockBillRepository.Setup(x => x.UpdateBill(bill1)).Returns(1);
            this.billBusiness = new BillBusiness(mockBillRepository.Object);

            var result = billBusiness.UpdateBill(bill1);

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void InsertBillTest()
        {
            mockBillRepository.Setup(x => x.InsertBill(bill3)).Returns(1);
            this.billBusiness = new BillBusiness(mockBillRepository.Object);

            var result = billBusiness.InsertBill(bill3);

            Assert.AreEqual(result, true);
        }
    }
}

