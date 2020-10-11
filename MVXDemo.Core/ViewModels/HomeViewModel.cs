using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVXDemo.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public HomeViewModel()
        {
            EnterCommand = new MvxCommand(Enter);
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                SetProperty(ref _name, value);
                RaisePropertyChanged(() => Name);
                RaisePropertyChanged(() => DisplayName);


            }
        }

        public IMvxCommand EnterCommand { get; set; }
        public void Enter()
        {
            //do code
        }

        public string DisplayName => $"Your name is {Name}";

    }
}
