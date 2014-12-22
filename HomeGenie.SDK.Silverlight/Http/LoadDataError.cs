﻿using System;

namespace HomeGenie.SDK.Http
{
    public class LoadDataError : Exception
    {
        public LoadDataError()
        {
        }

        public LoadDataError(string message)
            :base(message)
        {
        }
    }
}