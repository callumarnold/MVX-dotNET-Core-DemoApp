using MvvmCross.ViewModels;
using MVXDemo.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVXDemo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}
