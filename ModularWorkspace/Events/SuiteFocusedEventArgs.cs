using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularWorkspace.Events
{
    public class SuiteFocusedEventArgs : EventArgs
    {
        public enum FocusedState
        {
            LostFocus,
            GotFocus
        }

        private decimal _opacity;
        private object _sender;
        private FocusedState _state;

        public SuiteFocusedEventArgs(object sender, decimal opacity, FocusedState state)
        {
            _sender = sender;
            _opacity = opacity;
            _state = state;
        }
        public object Sender
        {
            get { return _sender; }
        }

        public decimal Opacity
        {
            get { return _opacity; }
        }
        public FocusedState State
        {
            get { return _state; }
        }

    }
}
