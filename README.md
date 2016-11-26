FireTheme: Class 1
==================

##Licensing Information: NO LICENSE

##Project source download:  
https://github.com/UMD-AR-Club-Tutorial/FireTheme-Class-1.git

##Authors & Contributors

#####- Brian Servia  
#####- Mikhail Sorokin

#####Any questions can be sent to: umd.ar.club@gmail.com | VR

```
.:  
./Assets  
./ProjectSettings  
.gitignore  
README.md  
```
```
Assets:  
./Materials (Color)  
./Material  
./Scene  
./Scripts  
Assets(Blender).meta  
InkyDeals_Metal_016.jpg  
InkyDeals(Color).meta  
Materials(Color).meta  
New Material.mat  
New Material.mat.meta  
Scene.meta  
Scripts.meta  
Smoke.mat  
Smoke.mat.meta  
ojaq.obj  
ojaq.obj.meta  
shutterstock.mat  
shutterstock.mat.meta  
shutterstock_8562066.jpg  
shutterstock_7862066.jpg.meta  
smoke_texture2741.jpg  
smoke_texture2741.jpg.meta  
```
```
ProjectSettings:  
AudioManager.asset  
ClusterInputManager.asset  
DynamicsManager.asset  
EditorBuildSettings.asset  
EditorSettings.asset  
GraphicsSettings.asset  
InputManager.asset  
NavMeshAreas.asset  
NetworkManager.asset  
Physics2DSettings.asset  
ProjectVersion.txt  
QualitySettings.asset  
TagManager.asset  
TimeManager.asset  
UnityAdsSettings.asset  
UnityConnectSettings.asset  
```

##Download And Opening Scene  

###A] ZIP Folder
      
####1) Go to: https://github.com/UMD-AR-Club-Tutorial/FireTheme-Class-1.git

####2) Click "Clone or download," then proceed to click "Download ZIP."

####3) Unzip folder.

####4) Open and create new project in Unity.

####5) Go to Unzipped folder (FireTheme-Class-1) and double click "Assets" --> "Scene," and drag  
####   the scene ("FirstStove") to the Assets section in Unity.

####6) Open Scene in Unity by double cliking "FirstStove."

####7) Finally go back to the FireTheme-Class-1 folder and drag:  
	./Materials  
	./Materials(Color)  
	./Scripts  
	InkyDeals_Metal_016  
	New Material  
	ojaq  
	shutterstock  
	shutterstock_78562066  
	Smoke  
	smoke_texture2741  

####    to the Assets section in Unity.


###B] Cloning (using Git Bash, similar with other command prompts)

####1) Go to: https://github.com/UMD-AR-Club-Tutorial/FireTheme-Class-1.git and copy this link on clipboard.

####2) Open Git Bash and choose location (path) to have the FireTheme-Class-1 folder.

####3) Type on Git Bash "git clone https://github.com/UMD-AR-Club-Tutorial/FireTheme-Class-1.git"

####4) After folder is created in the desired location, open the folder and create new project in Unity.

####5) Go into the FireTheme-Class-1 folder and double click "Assets" --> "Scene," and drag
####   the scene ("FirstStove") to the Assets section in Unity.

####6) Open Scene in Unity by double clicking "FirstStove."

####7) Finally go back to the FireTheme-Class-1 folder and drag:
	./Materials  
	./Materials(Color)  
	./Scripts  
	InkyDeals_Metal_016  
	New Material  
	ojaq  
	shutterstock  
	shutterstock_78562066  
	Smoke  
	smoke_texture2741  

####   to the Assets section in Unity.


##Steps Of Tutorial In Unity:

###1) Right click on the Hierarchy window, hover over 3D Object, click Plane to create an object. 
###   After created, right click the Plane object and click Rename, in order to change it from Plane to floor. 
###2) Go to the transform settings of the floor, and make sure the position (x,y,z) are all zero.
###3) Then scale the floor: x = 10, y = 1, z = 10.
###4) Right click on the Hierarchy window, gover over 3D Object, click Capsule to create an object.
###   After created, right click the Capsule object and click Rename, in order to change it from Capsule to user.
###5) Drag and drop the Camera object into the user object (Assuming Unity created a Camera object automatically), 
###   making the Camera object a child of user. (If the Camera object wasn't created for you in the 
###   beginning of the scene, create the camera object, and drag and drop it in the user object).