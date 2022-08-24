# Advanced-graphics-
Game is created using terrain tools 

Used below packs for layers
1) Conifers[BOTD]
2)Grass and Flowers Pack1
3)TerrainTexturePackFree

In this game there are 5 objects 
1)Sphere
2)Cube
3)Capusle
4)Capsule2
5)Cylinder

Sphere
 
 When user focusses on Sphere; it starts to descend down ; stops desecnd when focused out

Cube

When user focusses on cube color chnages from red to green - back to red when focussed out

Capsule
 
 Capusule when focussed emits sparkling particles

Capsule2
  
  This capusle explodes into small spheres on focus  and the spheres start to descend down

Cylinder
  
  Cylinder turns to cube on focus
  
 How coding is done:
 
 Raycast check is used to see which gameobject is currently focussed at in CameraPointer.cs file .
 Depending on which gameobject focussed that method is invoked for logic.
 
  
  
              _gazedAtObject?.SendMessage("OnPointerExit");
                _gazedAtObject = hit.transform.gameObject;
               if(_gazedAtObject.name == "Sphere") {
               _gazedAtObject.SendMessage("OnPointerEnterSphere");}
               if(_gazedAtObject.name == "Cube"){
                     _gazedAtObject.SendMessage("OnPointerEnterCube");}
                if(_gazedAtObject.name == "Cylinder"){
                      _gazedAtObject.SendMessage("OnPointerEnterCylinder");}
                if(_gazedAtObject.name == "Capsule"){
                _gazedAtObject.SendMessage("OnPointerEnterCapsule");}
                  if(_gazedAtObject.name == "Capsule1"){
                _gazedAtObject.SendMessage("OnPointerEnterCapsule1");}
  
  Each of the gameobject has associated cs file linked to exceute logic depening on focus method called from CameraPointer.cs 
  
  path of scene - MyProject/Assets/Samples/Google Cardboard XR Plugin for Unity/1.17.0/Hello Cardboard/Scenes/HelloCardboard.unity
  
  path of scripts - MyProject/Assets/Samples/Google Cardboard XR Plugin for Unity/1.17.0/Hello Cardboard/Scripts
  
  
  
  
  
  <img width="957" alt="image" src="https://user-images.githubusercontent.com/59860538/186444584-0e95fbbf-39fd-4cbc-83aa-a5f1ec285b3c.png">
  
 ![image](https://user-images.githubusercontent.com/59860538/186453039-986c5124-39fe-477c-8d58-747dc031bdaf.png)



  
