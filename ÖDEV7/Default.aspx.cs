using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourNamespace
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var menuItems = new List<Menu>
                {
                    new Menu
                    {
                        Text = "BILGISAYAR",
                        Url = "bilgisayar.aspx",
                        SubItems = new List<Menu>
                        {
                            new Menu { Text = "Bilgisayar", Url = "#" },
                            new Menu { Text = "Elektronik", Url = "#" },
                            new Menu { Text = "Kontrol", Url = "http://www.google.com.tr" }
                        }
                    },
                    new Menu
                    {
                        Text = "MAKINE",
                        Url = "#"
                    },
                    new Menu
                    {
                        Text = "METAL",
                        Url = "#"
                    }
                };

                MenuRepeater.DataSource = menuItems;
                MenuRepeater.DataBind();
            }
        }

        private bool IsCurrentPage(object item)
        {
            var menu = item as Menu;
            if (menu == null) return false;

            string currentPage = Request.Url.Segments[Request.Url.Segments.Length - 1].TrimEnd('/');
            return currentPage == menu.Url;
        }
    }

    public class Menu
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public List<Menu> SubItems { get; set; }
    }
}