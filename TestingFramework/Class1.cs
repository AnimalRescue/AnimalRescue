using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace TestingFramework
{
    public class Class1
    {
        public void Go()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");
        }
    }
}
