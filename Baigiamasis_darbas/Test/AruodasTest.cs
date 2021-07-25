using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baigiamasis_darbas.Test
{
    public class AruodasTest : BaseTest
    {
        [Test]
        public void AruodasPageTestDropdownBoxes()
        {
            _aruodasPage.NavigateToDefaultPage()
                 .ClickCookiesButton()
                .SelectDropdownButtonSavivaldybe()
                .SelectSavivaldybeFromDropdown()
                .SelectDropdownButonMikrorajonas()
                .SelectMikrorajonasFromDropdown()
                .ClickSelectMikrorajonasButton()
                .SelectDropdownButtonGatve()
                .SelectGatveFromDropdown()
                .ClickSelectGatveButton()
                .SelectDropdownButtonNamoTipas()
                .SelectNamoTipasFromDropdown()
                .ClickSelectNamoTipasButton()
                .SelectDropdownButtonPlotas()
                .SelectPlotasNuoMaziausiuFromDropdown()
                .SelectPlotasIkiDidziausiuFromDropdown()
                .SelectDropdownButtonIrengimas()
                .SelectIrengimasFromDropdown()
                .ClickSelectIrengimasButton()
                .SelectDropdownButtonKaina()
                .InsertKainaFrom("20000")
                .InsertKainaTill("500000")
                .ClickIssaugotiKainaButton()
                .ClickIssaugotiButton()
                .CheckResult("Skelbimų pagal Jūsų paieškos kriterijus neradome");
        }
        [TestCase("panyseva@yahoo.com", "slaptazodis123", true, false, "Šis el. pašto adresas užimtas", TestName = ("Input elPastas, slaptazodis + gauti naujienlaiskius + sutikti su portalo taisyklemis = Šis el. pašto adresas užimtas"))]
        public void AruodasPage1TestRegistration(string elPastas, string slaptazodis, bool NoriuGautiAruodasLtNaujienlaiskius, bool SuPortaloTaisyklemisSutinku, string Result)
        {
            _aruodasPage1.NavigateToDefaultPage()
                .ClickCookiesButton()
                .ClickMeniuButton()
                .ClickPrisijungtiFromMeniuDropdown()
                .SelectButtonRegistruotis()
                .InputElPastoAdresas(elPastas)
                .InputSlaptazodis(slaptazodis)
                .InputElPastasAndSlaptazodis(elPastas, slaptazodis)
                .CheckResult("Labai stiprus slaptažodis")
                .ClickBoxNoriuGautiAruodasLtNaujienlaiskius(NoriuGautiAruodasLtNaujienlaiskius)
                .ClickBoxSuPortaloTaisyklemisSutinku(SuPortaloTaisyklemisSutinku)
                .ClickButtonRegistruotis()
                .Result("Šis el. pašto adresas užimtas");

        }
                
        [TestCase("panyseva@gmail.com", "SLAPTAZODIS123", "Mano aruodas", TestName = ("LogIn - Input El.Pastas, Input Slaptazodis = LogIn"))]
        public void AruodasPage2TestLogIn(string elPastas, string slaptazodis, string expectedResult)
        {
            _aruodasPage2.NavigateToDefaultPage()
                .ClickCookiesButton()
                .ClickPrisijungtiButton()
                .InputElPastas(elPastas)
                .InputSlaptazodis(slaptazodis)
                .InputElPastasAndSlaptazodis(elPastas, slaptazodis)
                .ClickButtonPrisijungti()
                .Result(true);
        }
    }
}
