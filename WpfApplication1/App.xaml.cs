using System;
using System.Threading;
using System.Windows;


namespace WpfApplication1
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public EventWaitHandle ProgramStarted { get; set; }


        protected override void OnStartup(StartupEventArgs e)
        {
            bool createNew;
            ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, "MyTctiApp", out createNew);


            if (!createNew)
            {
                MessageBox.Show("请勿重复打开！");
                App.Current.Shutdown();
                Environment.Exit(0);
            }
            base.OnStartup(e);
        }

    }
}
