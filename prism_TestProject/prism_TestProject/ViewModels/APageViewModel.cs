using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prism_TestProject.ViewModels
{
    public class APageViewModel : ViewModelBase, IInitializeAsync
    {
        public APageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "A Page";
        }

        public async Task InitializeAsync(INavigationParameters parameters)
        {
            await Task.Delay(500);
        }
    }
}
