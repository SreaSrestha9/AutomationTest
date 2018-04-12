
namespace Shakar.PageObject
{
    class ManCityPageObjects
    {    //[FindsBy(How = How.CssSelector, Using = "#author")]
        public string css_txtAuthor {
            get { return "#author"; }
        }
        //[FindsBy(How = How.CssSelector, Using = "#email")]
        public string css_txtemail {
            get { return "#email"; }
        }
        //[FindsBy(How = How.CssSelector, Using = "#url")]
        public string css_txtUrl {
            get { return "#url"; }
        }
        //[FindsBy(How = How.CssSelector, Using = "#comment")]
        public string css_txtComment {
            get { return "#comment"; }
        }
        //[FindsBy(How = How.CssSelector, Using = "#submit")]
        public string css_btnSubmit {
            get { return "#submit"; }
        }
       }
}
