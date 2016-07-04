using Caliburn.Micro;
using System;
using System.Windows;
using System.Windows.Input;
namespace ModularWorkspace {
    public class ShellViewModel : Conductor<IScreen>.Collection.AllActive, IShell {

        IWindowManager _windowManager;
        IEventAggregator _eventAggregator;

        public ShellViewModel(IWindowManager windowManager, IEventAggregator eventAggregator)
        {
            _windowManager = windowManager;
            _eventAggregator = eventAggregator;
        }
        public void OpenNewWindow()
        {
            var item = new ModularWindowViewModel(300, 200, _eventAggregator);
            Items.Add(item);
            _windowManager.ShowWindow(item);
        }

        public void DragWindow(Object sender, MouseButtonEventArgs e)
        {
            var view = (Window)sender;
            view.DragMove();
        }
        public void CloseButton()
        {
            TryClose();
        }

        public void TryClose()
        {
            base.TryClose();
        }
    }
}