using MVVMTest2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTest2.Navigators
{
    public enum ViewType
    {
        Home,
        Alarms,
        Sources,
        Settings
    }

    public interface INavigator
    {
        ICommand UpdateCurrentView { get; }
        BaseViewModel CurrentViewModel { get; set; }
    }
}
