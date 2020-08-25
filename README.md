# MeshRenderer Activation Track

This package can control your gameobjects' visibility using timeline without stopping any behaviour update.

![Main](https://github.com/ProjectBLUE-000/Unity_MeshRendererActivationTrack/blob/master/Assets/ProjectBlueSDK/Packages/MeshRendererActivationTrack/Thumbnails/Main.gif)

# How to use

### Attach a script
First, attach the `MeshRendererActivationControl.cs` script to any object.
And register some MeshRenderers you want to control visibility to the property `targetMeshRenderers`. 

![Conponent](https://github.com/ProjectBLUE-000/Unity_MeshRendererActivationTrack/blob/master/Assets/ProjectBlueSDK/Packages/MeshRendererActivationTrack/Thumbnails/Component.png)

### Make a track
Second, make a timeline and add track called `ProjectBlue.MeshRendererActivationTimeline > Mesh Renderer Activation Track`.
![AddTrack](https://github.com/ProjectBLUE-000/Unity_MeshRendererActivationTrack/blob/master/Assets/ProjectBlueSDK/Packages/MeshRendererActivationTrack/Thumbnails/AddTrack.png)

### Bind and add clip
Finally, add some clips on the track and bind the hierarchy object you attached `MeshRendererActivationControl.cs` to the track. 

![TrackView](https://github.com/ProjectBLUE-000/Unity_MeshRendererActivationTrack/blob/master/Assets/ProjectBlueSDK/Packages/MeshRendererActivationTrack/Thumbnails/TrackView.png)