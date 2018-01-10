﻿using System;

namespace AutumnBox.Basic.Function.Event
{
    public delegate void SingleFileSendedEventHandler(object sender, SingleFileSendedEventArgs e);
    public class SingleFileSendedEventArgs : EventArgs
    {
        public readonly string FileName;
        public SingleFileSendedEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}