using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prism_TestProject.ViewModels
{
    public class BPageViewModel : ViewModelBase
    {
        public BPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "B Page";
        }
    }
}
