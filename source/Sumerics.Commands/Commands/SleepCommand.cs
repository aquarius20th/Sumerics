﻿namespace Sumerics.Commands
{
    using System;

	sealed class SleepCommand : BaseCommand
	{
		public SleepCommand() : 
            base(1, 1)
		{
		}

		public String Invocation(String arg)
		{
			return "sleep(" + arg + ")";
		}
	}
}
