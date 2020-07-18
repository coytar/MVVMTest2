using MVVMTest2.Navigators;
using MVVMTest2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTest2.Commands
{
    public class UpdateCurrentView : ICommand
    {
        private INavigator navigator;

        public UpdateCurrentView(INavigator navigator)
        {
            this.navigator = navigator;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Alarms:
                        navigator.CurrentViewModel = new AlarmViewModel();
                        break;
                    case ViewType.Sources:
                        break;
                    case ViewType.Settings:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
