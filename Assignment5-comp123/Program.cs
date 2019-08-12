using Assignment5_comp123.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_comp123
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static OrderForm orderForm;
        public static SelectForm selectForm;
        public static Views.StartForm startForm;
        public static ProductInfoForm proudctInfotForm;
        public static SplashForm splashtForm;
        public static AboutForm aboutForm;
        //public static Product product;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // product = new Product();
            orderForm = new OrderForm();
            selectForm = new SelectForm();
            startForm = new Views.StartForm();
            splashtForm = new SplashForm();
            aboutForm = new AboutForm();
            Application.Run(selectForm);
        }
    }
}
