using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMurder
{
    class Element
    {
        public static void SetText(IWebDriver driver,IWebElement ele,String xpath, string value)
        {
            driver.FindElement(By.XPath(xpath)).SendKeys(value);
        }
    }
}
