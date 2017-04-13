using System;
using ObjCRuntime;

[Native]
public enum PMAlertActionStyle : nint
{
	Default = 0,
	Cancel = 1
}

[Native]
public enum PMAlertControllerStyle : nint
{
	Alert = 0,
	Walkthrough = 1
}
