#!/usr/bin/env bash

msbuild -t:Clean,Build -p:Configuration=Release Twilio.Video.Android.csproj
# nuget pack twilio-video.nuspec 