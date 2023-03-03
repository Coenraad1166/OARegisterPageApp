using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RegisterPageApp.Models;

namespace RegisterPageApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            btnSubmit.IsEnabled = e.Value;
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            User user = new User
            {
                FirstName = entryFirstName.Text,
                LastName = entryLastName.Text,
                Password = entryPassword.Text,
                Age = Convert.ToInt32(entryAge.Text),
                Gender= pickerGender.SelectedItem.ToString(),
                Email = entryEmail.Text,
                Phone = entryPhone.Text,

        };
            Navigation.PushAsync(new ProfilePage(user));
        }
    }
}