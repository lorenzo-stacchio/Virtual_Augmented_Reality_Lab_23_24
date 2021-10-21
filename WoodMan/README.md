# Virtual and augmented reality laboratory session - 2st
This simple and small project aims at teaching students basic concepts of Unity and Mobile development:
* Menus
* Navigation systems
* Google XR cardboard 
* Android/iOS development

## Requirements
This project requires Unity [Unity 2018.4.35f1](https://unity3d.com/es/unity/whats-new/2018.4.35) you can install it through [Unity Hub] (https://unity3d.com/get-unity/download) **including android support**. 

However, this is a necessary but not sufficient condition to work with it. Indeed, you must download and include in the ```Asset``` directory the [Google Virtual Reality SDK](https://github.com/googlevr/gvr-unity-sdk/releases). This Unity packages includes, among others, components used in this project, such as the ``` ada```.


## Mobile application export requirements
To export your application in an android device, you have to select a valid SDK,NDK and JDK from the Unity Preference Menu. The JDK should be delivered along with Unity installation if you picked the "Android support" option when you installed it.   
I will provide you a valid [android sdk](https://liveunibo-my.sharepoint.com/:f:/g/personal/lorenzo_stacchio_studio_unibo_it/ErQlrS44KG5NqITleTV00SABDTTg37RKeoMvN204zaHClA?e=gq9Wtx) (**access is only valid for unibo students**) . However, you can also install it following instruction provided by the officialy [Unity 2018.4 documentation](https://docs.unity3d.com/2018.4/Documentation/Manual/android-sdksetup.html).

Once the Android SDK,NDK and JDK is installed in your system, you could deploy your application to an android device.

## Troubleshooting

The sdk, along with the NDK, can be installed in two different file system locations:
* The Windows **user** dir, precisely under ```C:\Users\**user**\AppData\Local\Android\```;
* In any directory of a non-system disk, as long as the father dir is named as **Android** (e.g. ```D:\Android\```), 
