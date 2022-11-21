using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeProject.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeProject.Page
{
    public class DashboardPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserMenu => driver.FindElement(By.ClassName("oxd-userdropdown-name"));
       
        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(driver.FindElement(By.ClassName("oxd-dropdown-menu")));
            element.SelectByText(text);
        }

    }
}
