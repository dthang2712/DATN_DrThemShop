using log4net;
using System;
using System.Reflection;

namespace DrThemShop.WinLibrary.BusinessService
{
    public class LoggingService : BaseService<LoggingService>
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public enum LoggingType
        {
            Debug,
            Info,
            Error
        }

        public class LoggingData
        {
            public DateTime LoggingTime { get; set; }
            public LoggingType Type { get; set; }
            public string LoggingMessage { get; set; }
            public string LoggingCategory { get; set; }

            public LoggingData()
            {
                this.LoggingTime = DateTime.Now;
            }

            public override string ToString()
            {
                return string.Format("LoggingTime:{0} - Type:{1} - LoggingMessage:{2}", LoggingTime, Type, LoggingMessage);
            }
        }

        public delegate void LoggingEvent(LoggingData messageLog);

        public event LoggingEvent OnLogging;

        public void LogMessage(LoggingType type, string messageLog)
        {
            LogMessage(new LoggingData()
            {
                LoggingMessage = messageLog,
                Type = type
            });
        }

        public void LogMessage(LoggingData messageLog)
        {
            if (messageLog != null)
            {
                switch (messageLog.Type)
                {
                    case LoggingType.Debug:
                        _logger.Debug(messageLog.LoggingMessage);
                        break;
                    case LoggingType.Info:
                        _logger.Info(messageLog.LoggingMessage);
                        break;
                    case LoggingType.Error:
                        _logger.Error(messageLog.LoggingMessage);
                        break;
                }

                if (OnLogging != null)
                {
                    OnLogging(messageLog);
                }
            }
        }
    }
}
