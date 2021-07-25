using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas.Page
{
    public class AruodasPage2 : BasePage
    {
        private const string PageAddress = "https://www.aruodas.lt/";
        private IWebElement _Cookies => Driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        private IWebElement _SelectPrisijungtiButton => Driver.FindElement(By.CssSelector("body > div.main.filter-form > div.header-strip > div.header-main-menu > div:nth-child(3) > div.personal-menu > div.personal-menu-item-a > div > div.reg-menu-div-2 > div"));
        private IWebElement _SelectInputElPastoAdresas => Driver.FindElement(By.Id("userName"));
        private IWebElement _SelectInputElSlaptazodis => Driver.FindElement(By.Id("password"));
        private IWebElement _SelectButtonPrisijungti => Driver.FindElement(By.Id("loginAruodas"));


        public AruodasPage2(IWebDriver webdriver) : base(webdriver)
        {
        }
        public AruodasPage2 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
        public AruodasPage2 ClickCookiesButton()
        {
            _Cookies.Click();
            return this;
        }
        public AruodasPage2 ClickPrisijungtiButton()
        {
            _SelectPrisijungtiButton.Click();
            return this;
        }
        public AruodasPage2 InputElPastas(string elPastas)
        {
            _SelectInputElPastoAdresas.Clear();
            _SelectInputElPastoAdresas.SendKeys(elPastas);
            return this;
        }
        public AruodasPage2 InputSlaptazodis(string slaptazodis)
        {
            _SelectInputElSlaptazodis.Clear();
            _SelectInputElSlaptazodis.SendKeys(slaptazodis);
            return this;
        }
        public AruodasPage2 InputElPastasAndSlaptazodis(string elPastas, string slaptazodis)
        {
            InputElPastas(elPastas);
            InputSlaptazodis(slaptazodis);
            return this;
        }
        public AruodasPage2 ClickButtonPrisijungti()
        {
            _SelectButtonPrisijungti.Click();
            return this;
        }
    }
}
