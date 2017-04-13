namespace Xam.PMAlertController
{
	using System;
	using ObjCRuntime;

	[Native]
	public enum PMAlertActionStyle : ulong
	{
		Default = 0,
		Cancel = 1
	}

	[Native]
	public enum PMAlertControllerStyle : ulong
	{
		Alert = 0,
		Walkthrough = 1
	}
}
