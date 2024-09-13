﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabalinaYP.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShabalinaYP.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Юля";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Юля", res);
        }
    }
}
