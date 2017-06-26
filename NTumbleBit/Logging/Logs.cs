﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTumbleBit.Logging
{
	public class Logs
	{
		static Logs()
		{
			Configure(new FuncLoggerFactory(n => NullLogger.Instance));
		}
		public static void Configure(ILoggerFactory factory)
		{
			Configuration = factory.CreateLogger("Configuration");
			Tumbler = factory.CreateLogger("Tumbler");
			Client = factory.CreateLogger("Client");
			Broadcasters = factory.CreateLogger("Broadcasters");
		}
		public static ILogger Tumbler
		{
			get; set;
		}
		public static ILogger Client
		{
			get; set;
		}
		public static ILogger Broadcasters
		{
			get; set;
		}
		public static ILogger Configuration
		{
			get; set;
		}
		public const int ColumnLength = 16;
	}
}
