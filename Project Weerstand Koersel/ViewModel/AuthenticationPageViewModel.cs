using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Newtonsoft.Json;
using Project_Weerstand_Koersel.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Weerstand_Koersel.ViewModel
{
    public partial class AuthenticationPageViewModel : BaseViewModel
    {
        public string webApiKey = "AIzaSyAG23_bOUdOb2ITOBdP0JbimaqKdoc2aGw";

        public string Email { get; set; }
        public string UserPassword { get; set; }


        public AuthenticationPageViewModel()
        {
            Title = "";
        }


        [RelayCommand]
        private async void LoginToStatsAsync() 
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(webApiKey));

            try
            {
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(Email, UserPassword);
                var content = await auth.GetFreshAuthAsync();
                var serializedContent = JsonConvert.SerializeObject(content);
                Preferences.Set("FreshFirebaseToken", serializedContent);
                await Shell.Current.GoToAsync(nameof(ChangeStatsPage), true);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
                throw;
            }
        }
    }
}
