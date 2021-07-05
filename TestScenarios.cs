using NUnit.Framework;
using RIBCCS.Pages;

namespace RIBCCS
{
    public class Tests : TestSetup
    {
        [Test]
        public void Scenario1()
        {
            string itemToDrag = "High Tatras 2";
            DragAndDropPage dragAndDropPage = new DragAndDropPage(driver);

            dragAndDropPage.DragItem(itemToDrag);

            string countryName = "South Africa";
            DropDownMenuPage dropDownMenuPage = new DropDownMenuPage(driver);
            
            Navigate(dropDownMenuPage.Link);
            dropDownMenuPage.SelectCountry(countryName);

            string name = "TestName";
            string email = "test@email.com";
            string website = "www.test.com";
            string experience = "3-5";
            string comment = "This is a test comment";

            SamplePage samplePage = new SamplePage(driver);
            Navigate(samplePage.Link);
            samplePage.FillInSamplePage(name, email, website, experience, comment);
        }

        [Test]
        public void Scenario2()
        {
 
        }

    }
}