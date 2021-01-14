# Twilio Video Xamarin Android

Twilio Video Android SDK binding for Xamarin

[![NuGet][nuget-img]][nuget-link]

[nuget-img]: https://img.shields.io/badge/nuget-5.13.0.0-blue.svg
[nuget-link]: https://www.nuget.org/packages/Twilio.Video.Android.XamarinBinding

## How to Build

### Twilio.Video Android 5.13.0 (January 13, 2021)

_AndroidDexTool_ should be set to _d8_ for _TargetFrameworkVersion_ == _v9.0_ or later.
You also need ReLinker Xamarin Bindings for Android: https://github.com/xbindings/relinker-android-binding

```
The aar is already included into this repostiory. So just build the project.    
```    
or    

Download aar/jar version you needed from https://bintray.com/twilio/releases/video-android and copy it to src\Jars. Then you will need to change res/values/values.xml and add missing \<attr format="boolean" name="overlaySurface"/> attribute there. And rename /src/Jars/ARR/libs/libwebrtc.jar to libwebrtc_2.jar if you are going to use Twilio.Voice SDK in you project.
```    
$ unzip video-android-5.13.0.aar -d tempFolder    
# Change whatever you need    
$ jar cvf video-android-5.13.0.aar -C tempFolder/ .
```

#### Changed properties
ScaleType, mirror, or overlaySurface have been prefixed. These attributes defined for VideoView and VideoTextureView have been prefixed with tvi to prevent attribute name clashes. Reference the following snippets to update your application layout files. For example: app:tviScaleType="fit"

##### Proguard settings

-keep class org.webrtc.** { *; }
-dontwarn org.webrtc.**
-keep class com.twilio.video.** { *; }
-keep class com.twilio.common.** { *; }
-keepattributes InnerClasses

## Sample

####  I don't have C# version of twilio quickstart application, so I highly recommend you to read about using native library bindings for xamarin and check official Twilio quickstart guides.

[video-quickstart-android](https://github.com/twilio/video-quickstart-android)

## Contributions

Members of the community have contributed to improving and update bindings:

- Jørgen (@jtorvald)

If you have a bugfix or an update you'd like to add, please open an issue. 
All pull requests should be opened against the `master` branch.
