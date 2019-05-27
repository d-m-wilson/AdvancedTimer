AdvancedTimer v1.0.2.0 alpha
=============

AdvancedTimer implementation for Xamarin.Forms

![#f03c15](https://placehold.it/15/f03c15/000000?text=+) **Warning**: This is an unstable, alpha-quality version which has not been tested AT ALL.. yet. I will be testing it in the near future as I use it in a Xamarin.Forms app, currently in development.

## AdvancedTimer
Timer object and its methods are implemented for extended support for timers.
You can start, stop, change interval of a timer.
For Xamarin.Forms projects
Can be used with Dependency service.

#### Setup
* Available on NuGet: https://www.nuget.org/packages/info.dmwilson.AdvancedTimer.Forms.Plugin
* In your .NET Standard 2.0 project, add a reference to AdvancedTimer.Forms.Plugin.Abstractions.dll
* In your Android project, add a reference to AdvancedTimer.Forms.Plugin.Android.dll
* In your iOS project, add a reference to AdvancedTimer.Forms.Plugin.iOSUnified.dll

In your iOS and Android projects please call:

iOS
```
AdvancedTimer.Forms.Plugin.iOS.AdvancedTimerImplementation.Init();
```

Android
```
AdvancedTimer.Forms.Plugin.Droid.AdvancedTimerImplementation.Init();
```

You must do this AFTER you call Xamarin.Forms.Init();


#### API Usage

To gain access to the Timer class simply use the dependency service:

```
IAdvancedTimer timer = DependencyService.Get<IAdvancedTimer>();
```

You MUST call initTimer for timer initialization;

```
timer.initTimer(3000, timerElapsed, true);
```
initTimer(interval, Eventhandler function, AutoReset);
                
                
#### Methods

```
timer.startTimer();
```
```
timer.stopTimer();
```
```
timer.getInterval()
```
```
timer.setInterval(5000);
```
```
timer.isTimerEnabled();
```

#### Release Notes
* Version 1.0.2.0-alpha2:
  * Resolved issue with the nuspec file which resulted in a build error for Android client projects
* Version 1.0.2.0-alpha:
  * Migrated from Portable Class Library (PCL) to .NET Standard 2.0
  * Removed deprecated WinPhone and iOS classic projects
  * Upgraded Xamarin.Forms from 1.3.1.6296 to 3.0.0.482510

#### Contributors
* [ufuf](https://github.com/ufuf)
* [d-m-wilson](https://github.com/d-m-wilson)

Thanks!

#### License
MIT License
