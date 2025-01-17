﻿#region Dapplo 2016-2019 - GNU Lesser General Public License

//  Dapplo - building blocks for .NET applications
//  Copyright (C) 2016-2019 Dapplo
// 
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
// 
//  This file is part of Dapplo.Log
// 
//  Dapplo.Log is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  Dapplo.Log is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
// 
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Log. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

#endregion

#if !PCL

using System.Diagnostics;

namespace Dapplo.Log.Loggers
{
    /// <summary>
    ///     A trace logger, the simplest implementation for logging trace messages
    /// </summary>
    public class TraceLogger : AbstractLogger
    {
        /// <summary>
        ///     Write a message with parameters to the Trace
        /// </summary>
        /// <param name="logInfo">LogInfo</param>
        /// <param name="messageTemplate">string with the message template</param>
        /// <param name="logParameters">object array with the parameters for the template</param>
        public override void Write(LogInfo logInfo, string messageTemplate, params object[] logParameters)
        {
            Trace.Write(Format(logInfo, messageTemplate, logParameters));
        }
    }
}
#endif