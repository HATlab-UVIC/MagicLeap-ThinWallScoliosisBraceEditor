# Magic Leap 2 Adaption of the Thin Wall Scoliosis Brace Editor
The [Thin-Wall Scoliosis Brace Editor project](https://github.com/HATlab-UVIC/Thin-WallScoliosisBraceEditor) has been switched over to the Magic Leap 2 and this repo contains the Unity Project necessary for futher development.  

## Required Materials

The Thin-Wall Scoliosis brace editor requires the following equipment/software for implementation: 
- Magic Leap 2 and Magic Leap Hub [Linked here](https://www.magicleap.care/hc/en-us/articles/5340945010573-Magic-Leap-Hub)
- Unity Engine 2022.3.11f1 or later (Vuforia 10.18 requires 2022.3.5 +) - [Linked Here](https://unity.com/releases/editor/whats-new/2022.3.11)
- Microsoft Visual Studio 17.5.5 - [Linked here](https://visualstudio.microsoft.com/downloads/)
- Vuforia Engine 10.18 - [Linked here](https://developer.vuforia.com/downloads/sdk)
- Microsoft Mixed Reality ToolKit (MRKT) 2.8.3 and Open XR 1.9.0
- Magic Leap Development tools: MagicLeap SDK, MagicLeap Setup Tool [Steps to do that here](https://developer-docs.magicleap.cloud/docs/guides/unity/getting-started/configure-unity-settings/)
- 

## Getting Started 
If you already have the HoloLens application, porting guide can be found [here](https://developer-docs.magicleap.cloud/docs/guides/third-party/mrtk/hololens-porting/). 

In order to use the application from scratch, the following steps must be taken:
Guide to setting up MagicLeap 2 application in Unity [here](https://ml1-developer.magicleap.com/en-us/learn/guides/1-1a-unity-setup-manual-steps). 

1. Clone and open this repository in Unity
2. Import Vuforia Engine
3. Mixed Reality ToolKit using MixedRealityFeature.exe
4. Configure MRTK for Magic Leap 2 - [Set up guide linked here](https://ml1-developer.magicleap.com/en-us/learn/guides/unity-mrtk-project-setup)
   
## Future Development

The following features should be added/developed to better enhance the application:
- Microsoft Mesh: Create a shared experience for multiple clinicians to be able to see the scoliosis brace being edited
- Shaders: Doing research into the best shaders to use on the brace to allow clinicians to see everything they need to and creating those shaders for the app
- General stability: With the Vuforia, the app doesn't run as fast as it needs to for clinicians to be able to edit the brace, hopefully with more updates to the HoloLens, Vuforia and Unity the project can run better however finding ways to optimize these settings for the quickest runtime and best performance is necessary. Another image detection software or anchoring method could be researched as well, Vuforia is just very developer friendly and was the only one that worked for me while I tried a few. 
- Accuracy and Usability: Finding ways to optimize the brushes and brush sizes to allow for the most accurate fitting and implementing those features
