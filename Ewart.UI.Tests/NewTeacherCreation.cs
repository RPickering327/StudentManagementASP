using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace Ewart.UI.Tests
{
    public class NewTeacherCreation : IDisposable
    {

        //Make a new instance of the webdriver called driver.
        private readonly IWebDriver _driver;

        public NewTeacherCreation()
        {
            _driver = new ChromeDriver("D:\\Desktop\\Ewart.UI.Tests\\bin\\Debug\\netcoreapp2.1\\");
        }




        [Fact]
        public void HomePageShouldLoad_Smoke()
        {

            _driver.Navigate().GoToUrl("https://localhost:44379/BaseUsers");
            Assert.Equal("Employees - Ewart", _driver.Title);



        }





        public void Dispose()
        {

            _driver.Quit();
            _driver.Dispose();

        }
    }
}
