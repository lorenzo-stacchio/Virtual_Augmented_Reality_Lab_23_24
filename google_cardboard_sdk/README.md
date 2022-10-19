## General info
This project will introduce Unity ad Google Cardboard SDK to develop a simple android application with basic interactions.

In particular, this project aims to show how to develop a simple game where the game generates random spawned objects and the player should collect them all.


## Requirements
To open and use the project created during the lab lessons, you should have installed [Unity 2019.4.39f1](https://unity3d.com/es/unity/whats-new/2019.4.39) along with android build support.

You can install it via [Unity Hub](https://unity3d.com/get-unity/download) (**recommended**) by clicking [here](unityhub://2019.4.39f1/78d14dfa024b). 

You also need to install the [GoogleVRForUnity package](https://github.com/googlevr/gvr-unity-sdk/releases) and import the asset into the project.



## Android build and run

For building the app on an android device you should check and change several settings in the Player settings in Unity. 


Finally, if you have installed the correct [Unity version](unityhub://2019.4.39f1/78d14dfa024b) along with the android deployment support, you should not have any problem in targeting android devices with android > 7.0.


To build and run directly on the android device, you must uninstall the app with the same package name if installed.




## Google and debugging: a tragicomic Unity story

Don't know why the novel version of the Google Cardboard does not possess an emulator debugging for Unity.

You can find the issue related to that [here](https://github.com/googlevr/cardboard/issues/324#issuecomment-1021380509).