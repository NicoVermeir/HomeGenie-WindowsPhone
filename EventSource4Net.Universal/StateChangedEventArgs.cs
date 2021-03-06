﻿using System;

namespace EventSource4Net
{
    public class StateChangedEventArgs : EventArgs
    {
        public EventSourceState State { get; private set; }
        public StateChangedEventArgs(EventSourceState state)
        {
            State = state;
        }
    }
}
