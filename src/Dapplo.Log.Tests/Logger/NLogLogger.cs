﻿#region Dapplo 2016-2019 - GNU Lesser General Public License

// Dapplo - building blocks for .NET applications
// Copyright (C) 2016-2019 Dapplo
// 
// For more information see: http://dapplo.net/
// Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
// This file is part of Dapplo.Log
// 
// Dapplo.Log is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// Dapplo.Log is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have a copy of the GNU Lesser General Public License
// along with Dapplo.Log. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#endregion

using NLog;

namespace Dapplo.Log.Tests.Logger
{
    /// <summary>
    ///     Wrapper for Dapplo.Log.ILogger -> NLog.Logger
    /// </summary>
    public class NLogLogger : AbstractLogger
    {
        /// <inheritdoc />
        public override void Write(LogInfo logInfo, string messageTemplate, params object[] logParameters)
        {
            LogManager.GetLogger(logInfo.Source.Source).Log(Convert(logInfo.LogLevel), messageTemplate, logParameters);
        }

        private static LogLevel Convert(LogLevels logLevel)
        {
            switch (logLevel)
            {
                case LogLevels.Info:
                    return NLog.LogLevel.Info;
                case LogLevels.Warn:
                    return NLog.LogLevel.Warn;
                case LogLevels.Error:
                    return NLog.LogLevel.Error;
                case LogLevels.Fatal:
                    return NLog.LogLevel.Fatal;
            }
            return NLog.LogLevel.Debug;
        }
    }
}