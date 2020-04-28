﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dime.Linq.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.Linq.Tests
{
    [TestClass]
    public class ExceptionHandlerTests
    {
        [TestMethod]
        public void Linq_CatchExceptions_LoopsWithoutErrors()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer(1, "Handsome B. Wonderful", "World"),
                null,
                new Customer(15, "Hello", "World")
            };

            List<Client> clients = customers.Select(x => new Client { Id = x.Id }).CatchExceptions(x => { }).ToList();
            Assert.IsTrue(clients.Count() == 2);
        }
    }
}
