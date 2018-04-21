using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace Test
{
    
    public class TestBase : IDisposable
    {
        //protected IWebDriver driver;
        //public TestBase(IWebDriver driver)
        //{
        //    this.driver = driver;
        //}

        protected ChromeDriver driver;

        public TestBase()
        {
            try
            {
                driver = new ChromeDriver();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inicializar.", ex);
            }
        }

        public void Dispose()
        {
            try{
                driver.Close();
                driver.Quit();    
            }catch(Exception ex){
                Console.WriteLine("Erro no dispose.",ex);  
            }

        }
    }
}
