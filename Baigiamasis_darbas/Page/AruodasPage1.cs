using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas.Page
{
    public class AruodasPage1 : BasePage
    {
        private const string PageAddress = "https://m.aruodas.lt/?obj=2&change_region=1";

        private IWebElement _Cookies => Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[1]/div/div[2]/div/button[1]"));
        private IWebElement _MeniuButton => Driver.FindElement(By.CssSelector("#divBodyContainer > div.body-header-container > div > ul > li:nth-child(5) > a > span.icon-menu"));
        private IWebElement _MeniuDropdownPrisijungtiElement => Driver.FindElement(By.XPath("/html/body/div[1]/div/div[5]/ul/li[2]/a"));
        private IWebElement _SelectButtonRegistruotis => Driver.FindElement(By.CssSelector("body > div.popup-window-v2 > form > div.user-login-form > a"));
        private IWebElement _SelectInputElPastoAdresas => Driver.FindElement(By.Id("userName"));
        private IWebElement _SelectInputElSlaptazodis => Driver.FindElement(By.Id("password"));
        private IWebElement _Text => Driver.FindElement(By.CssSelector("#registerForm > div.user-login-form > div:nth-child(2) > div > div.password-strength__text"));
        private IWebElement _SelectBoxNoriuGautiAruodasLtNaujienlaiskius => Driver.FindElement(By.CssSelector("#registerForm > div.user-login-form > div:nth-child(3) > label > span"));
        private IWebElement _SelectBoxSuPortaloTaisyklemisSutinku => Driver.FindElement(By.CssSelector("#registerForm > div.user-login-form > div:nth-child(4) > label > span"));
        private IWebElement _ClickButtonRegistruotis => Driver.FindElement(By.CssSelector("#registerButton"));
        private IWebElement _Result => Driver.FindElement(By.CssSelector("#registerForm > div.user-login-form > div.login-form-input.user-login-form__error"));




        public AruodasPage1(IWebDriver webdriver) : base(webdriver)
        {
        }
        public AruodasPage1 NavigateToDefaultPage()
        {
            if (Driver.Url != PageAddress)
                Driver.Url = PageAddress;
            return this;
        }
        public AruodasPage1 ClickCookiesButton()
        {
            _Cookies.Click();
            return this;
        }
        public AruodasPage1 ClickMeniuButton()
        {
            _MeniuButton.Click();
            return this;
        }
        public AruodasPage1 ClickPrisijungtiFromMeniuDropdown()
        {
            _MeniuDropdownPrisijungtiElement.Click();
            return this;
        }
        public AruodasPage1 SelectButtonRegistruotis()
        {
            _SelectButtonRegistruotis.Click();
            return this;
        }
        public AruodasPage1 InputElPastoAdresas(string elPastas)
        {
            _SelectInputElPastoAdresas.Clear();
            _SelectInputElPastoAdresas.SendKeys(elPastas);
            return this;
        }
        public AruodasPage1 InputSlaptazodis(string slaptazodis)
        {
            _SelectInputElSlaptazodis.Clear();
            _SelectInputElSlaptazodis.SendKeys(slaptazodis);
            return this;
        }
        public AruodasPage1 InputElPastasAndSlaptazodis(string elPastas, string slaptazodis)
        {
            InputElPastoAdresas(elPastas);
            InputSlaptazodis(slaptazodis);
            return this;
        }
        public AruodasPage1 CheckResult(string text)
        {
            string result = _Text.Text;
            Assert.IsTrue(result == _Text.Text);
            return this;
        }
        public AruodasPage1 ClickBoxNoriuGautiAruodasLtNaujienlaiskius(bool shouldBeSelected)
        {
            if (shouldBeSelected != _SelectBoxNoriuGautiAruodasLtNaujienlaiskius.Selected)
                _SelectBoxNoriuGautiAruodasLtNaujienlaiskius.Click();
            return this;
        }
        public AruodasPage1 ClickBoxSuPortaloTaisyklemisSutinku(bool shouldBeSelected)
        {
            if (shouldBeSelected != _SelectBoxSuPortaloTaisyklemisSutinku.Selected)
                _SelectBoxSuPortaloTaisyklemisSutinku.Click();
            return this;
        }
        public AruodasPage1 ClickButtonRegistruotis()
        {
            _ClickButtonRegistruotis.Click();
            return this;
        }
        public AruodasPage1 Result(string expectedResult)
        {
            Assert.IsTrue(_Result.Text.Contains(expectedResult), $"Result is not the same, expected{expectedResult}, but was {_Result.Text}");
            return this;
        }
        

    }
}
