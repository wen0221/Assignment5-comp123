using System;
using Assignment5_comp123.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Diagnostics;

namespace DollarComputersUnitTestProjec
{
    [TestClass]
    public class UnitTest1
    {
        SelectForm selectForm;

        [TestMethod]
        public void TestSelectFormHasLoadedDataSource()
        {
            

            selectForm = new SelectForm();
            //selectForm.ShowInTaskbar = false;
            //selectForm.ShowDialog();

            selectForm = new SelectForm();


            Assert.IsTrue(selectForm.HasLoadedDataSource());
        }
            public void TestThatSelectLabelDisplaysItemSelected()
        {
           


            selectForm = new SelectForm();
            selectForm.ShowInTaskbar = false;
            selectForm.ShowDialog();
            string outputString = selectForm.SelectLabel.Text;

            Assert.AreEqual("Asus G71GX-RXO5 $719.97", outputString);
        }


        
    }
}
