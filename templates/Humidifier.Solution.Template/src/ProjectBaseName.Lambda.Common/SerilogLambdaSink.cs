using System;
using System.IO;
using Amazon.Lambda.Core;
using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting;

namespace ProjectBaseName.Lambda.Common
{
    public class SerilogLambdaSink : ILogEventSink
    {
        readonly ITextFormatter textFormatter;

        public SerilogLambdaSink(ITextFormatter textFormatter)
        {
            this.textFormatter = textFormatter ?? throw new ArgumentNullException(nameof(textFormatter));
        }

        public void Emit(LogEvent logEvent)
        {
            if (logEvent == null) throw new ArgumentNullException(nameof(logEvent));
            using (var writer = new StringWriter())
            {
                textFormatter.Format(logEvent, writer);
                LambdaLogger.Log(writer.ToString());
            }
        }
    }

    public static class SerilogLambdaSinkConfigurationExtensions
    {
        public static LoggerConfiguration LambdaLogger(this LoggerSinkConfiguration config, ITextFormatter formatter, LogEventLevel restrictedToMinimumLevel = LevelAlias.Minimum, LoggingLevelSwitch levelSwitch = null)
        {
            if (config == null) throw new ArgumentNullException(nameof(config));
            if (formatter == null) throw new ArgumentNullException(nameof(formatter));
            return config.Sink(new SerilogLambdaSink(formatter), restrictedToMinimumLevel, levelSwitch);
        }
    }
}