using JsonFx.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace YouTrackSharp.Issues
{
	public class IssueChanges
	{
		public Issue Issue { get; set; }

		[JsonName("change")]
		public Change[] Changes { get; set; }

	}
}
