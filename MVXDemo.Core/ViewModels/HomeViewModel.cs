using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVXDemo.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                SetProperty(ref _name, value);
                RaisePropertyChanged(() => Name);
                    
            
            }
        }



    }
}
