using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TP4.Data;
using TP4.Entities;
using TP4.Logic;

namespace T4.Test
{
    [TestClass]
    public class ShippersTests
    {
        [TestMethod]
        public void GetAll_AlInstanciarObjetos_DevuelveObjetosDelTipoListaDeShippers()
        {
            var data = new List<Shippers>
            {
                new Shippers { CompanyName = "ShipperOneA" , ShipperID = 10 },
                new Shippers { CompanyName = "ShipperTwoA" , ShipperID = 20 },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Shippers>>();
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.Shippers).Returns(mockSet.Object);

            var service = new ShippersLogic(mockContext.Object);
            var blogs = service.GetAll();

            Assert.IsInstanceOfType(blogs, typeof(List<Shippers>));
        }

        [TestMethod]
        public void GetAll_AlInstanciarVariosObjetos_DeberiaRetornarTodosLosElementos()
        {
            var data = new List<Shippers>
            {
                new Shippers { CompanyName = "ShipperOne" },
                new Shippers { CompanyName = "ShipperTwo" },
                new Shippers { CompanyName = "ShipperThree" },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Shippers>>();
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Shippers>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NorthwindContext>();
            mockContext.Setup(c => c.Shippers).Returns(mockSet.Object);

            var service = new ShippersLogic(mockContext.Object);
            var blogs = service.GetAll();

            Assert.AreEqual(3, blogs.Count);
            Assert.AreEqual("ShipperOne", blogs[0].CompanyName);
            Assert.AreEqual("ShipperTwo", blogs[1].CompanyName);
            Assert.AreEqual("ShipperThree", blogs[2].CompanyName);
        }
    }
}
