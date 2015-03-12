using System;
using ObjCRuntime;

[assembly: LinkWith ("libSocketRocket.a", LinkTarget.ArmV7 | LinkTarget.Simulator, "-licucore", ForceLoad = true)]
