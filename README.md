# Unibo Virtual Augmented Reality Lab 2021/2022
![varlab_unibo_logo](./images/varlab_unibo.png)

This repository contains some Unity projects presented during laboratory classes for the [Virtual and Augmented Reality Laboratory course](https://www.unibo.it/it/didattica/insegnamenti/insegnamento/2020/447969) of the [Alma Mater Studiorum University](https://www.unibo.it/en). 


## General info
Each folder contains a Unity project, which could be divided into various Unity Scenes.
The slides of the lessons can be found on [the virtual page dedicated to the course](https://virtuale.unibo.it/course/view.php?id=18319).


## Requirements
To open and use the project created during the lab lessons, you should have installed [Unity 2018.4.35f1](https://unity3d.com/es/unity/whats-new/2018.4.35).

You can install it via [Unity Hub](https://unity3d.com/get-unity/download) (**recommended**). 

You also need to install the [GoogleVRForUnity package](https://github.com/googlevr/gvr-unity-sdk/releases) and insert into project where is needed. This package is used to export a Unity application to the smartphone (read more [here](https://developers.google.com/cardboard/develop/unity/quickstart)).


Finally, you need an [HTC Vive](https://www.vive.com/us/) along with a working installation of [Steam](https://store.steampowered.com/) and [SteamVR](https://store.steampowered.com/steamvr?l=italian).

More details about what to install are in the README file of different projects. 


## Troubleshooting

There is an open issue regarding the integration of "Install this version with Unity Hub." in Ubuntu. To install a specific version of Unity there is a workaround: 

- Take the link using browser inspector and scraping the link associated with to the ```href``` attribute of web html element. E.g., version 2018.4.35f1 is identified with the url ```unityhub://2018.4.35f1/dbb5675dce2d```;

- Execute ```./$DIR/UnityHub.AppImage unityhub://2018.4.35f1/dbb5675dce2d```, where ```$DIR``` is the dir where the UnityHub app image is located;

- You can ease your work adding ```$DIR``` to your ```$PATH``` as stated [here](https://askubuntu.com/questions/60218/how-to-add-a-directory-to-the-path/226947#226947).
