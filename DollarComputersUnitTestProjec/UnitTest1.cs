using System;
using Assignment5_comp123.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms; 

namespace DollarComputersUnitTestProjec
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSelectFormHasLoadedDataSource()
        {
            SelectForm selectForm;


            selectForm = new SelectForm();
            Assert.IsTrue(selectForm.HasLoadedDataSource());


        }
    }
}
