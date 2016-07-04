using Caliburn.Micro;
using ModularWorkspace.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ModularWorkspace
{
    public class ModularWindowViewModel : Screen, IHandle<SuiteFocusedEventArgs>
    {
        private IEventAggregator _eventAggregator;
        private int _height = 300;
        private int _width = 300;
        private decimal _opacity = 1;
        private bool _isAlwaysOnTop = false;

        public ModularWindowViewModel(int width, int height, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _height = height; 
            _width = width;
        }

        public void DragWindow(Object sender, MouseButtonEventArgs e)
        {
            var view = (Window)sender;
            view.DragMove();
        }

        public void IGotFocus()
        {
            //Set to full visibility
            Opacity = 1;
        }

        public void ILostFocus()
        {
            //Set to some value less than fully visible
            Opacity = .5M;
        }

        public bool IsAlwaysOnTop
        {
            get { return _isAlwaysOnTop;  }
            set { _isAlwaysOnTop = value;
                NotifyOfPropertyChange(() => IsAlwaysOnTop);
            }
        }

        public void Handle(SuiteFocusedEventArgs e)
        {
        
        }

        public decimal Opacity
        {
            get { return _opacity; }
            set { _opacity = value; NotifyOfPropertyChange(() => Opacity); }
        }

        public int Height { get { return _height; } set { _height = value; NotifyOfPropertyChange(() => Height);} }
        public int Width { get { return _width; } set { _width = value; NotifyOfPropertyChange(() => Width); } }
    }
}
