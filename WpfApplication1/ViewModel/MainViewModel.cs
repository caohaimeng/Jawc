using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Windows;
using System.Windows.Controls;

namespace Jawc.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            _Index = 0;
            Views.ManualView manualView = new Views.ManualView();

            view = manualView;
        }
        #region property
        private UserControl view;
        public UserControl ShowView
        {
            get
            {
                return ShowView;
            }

            set
            {
                ShowView = value;
                RaisePropertyChanged("ShowView");
            }
        }
        private int _Index;
        public int Index
        {
            get
            {
                return _Index;
            }

            set
            {
                _Index = value;
                RaisePropertyChanged("Index");
            }
        }
        #endregion
        #region Command
        private RelayCommand loginViewCommand;

        public RelayCommand  LoginViewCommand
        {
            get
            {
                loginViewCommand = new RelayCommand(CloseWindow);
                return loginViewCommand;
            }

            set
            {
                loginViewCommand = value;
            }
        }

       

        private void CloseWindow()
        {
          
            System.Windows.Forms.MessageBox.Show(_Index.ToString());
        }
        #endregion
    }
}