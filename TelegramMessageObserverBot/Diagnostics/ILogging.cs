﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramMessageObserverBot.Diagnostics
{
    public interface ILogging
    {
        event Action<string, LogMessage> LogMessageReceived;
    }
}
