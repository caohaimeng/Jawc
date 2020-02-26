using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Jawc.ViewModel
{
    class EventArgsConverter :IEventArgsConverter
    {
        
public object Convert(object value, object parameter)
        {
            var Args = (RoutedEventArgs)value;

            var index = parameter as ListView;
            return index.SelectedIndex;
        }
    }
}
