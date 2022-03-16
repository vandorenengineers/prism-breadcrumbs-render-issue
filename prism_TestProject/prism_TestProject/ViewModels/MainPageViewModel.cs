using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prism_TestProject.Views;

namespace prism_TestProject.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand navigateToPageA;

        public DelegateCommand NavigateToPageACommand => this.navigateToPageA ??
                                                         (this.navigateToPageA = new DelegateCommand(NavigateToPageA));

        private async void NavigateToPageA()
        {
            var result  = await NavigationService.NavigateAsync(nameof(APage));
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
