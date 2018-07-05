using System;
using System.Collections.Generic;
using System.Text;

namespace AppImage.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private string imageSource;

        public string ImageSource
        {
            get { return imageSource; }
            set { SetProperty(ref imageSource, value); }
        }

        public MainViewModel()
        {
            ImageSource = "http://squad4.eastus.cloudapp.azure.com:81/v1/Users/GetPicture?token=PDgktIUEs0cO81TcADbk&identifier=RHUUQHW7PBGKOHB&maxW=300&maxH=300";
        }

    }
}
