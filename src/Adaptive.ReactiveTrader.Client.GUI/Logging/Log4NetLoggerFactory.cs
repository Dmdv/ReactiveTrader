﻿using System;
using Adaptive.ReactiveTrader.Shared.Logging;
using log4net;
using ILog = Adaptive.ReactiveTrader.Shared.Logging.ILog;

namespace Adaptive.ReactiveTrader.Client.Logging
{
    public class Log4NetLoggerFactory : ILoggerFactory
    {
        public ILog Create(Type type)
        {
            return new Log4NetLoggerWrapper(LogManager.GetLogger(type));
        }
    }
}
