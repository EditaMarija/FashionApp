using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }

        public List<Profile> MyProfiles { get => GetProfiles(); }

        private List<Profile> GetProfiles()
        {
            var colList = new List<Profile>();
            colList.Add(new Profile { Image = "floral.png", Title = "MY ORDERS" });
            colList.Add(new Profile { Image = "leatherbag.png", Title = "POPULAR ITEMS" });
            colList.Add(new Profile { Image = "satchel.png", Title = "ORDER AGAIN" });
            return colList;
        }
    }

    public class Profile
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
    }

}