# Haunted Jaunt Sandbox

A short sandbox demo based on Unity Technologies' John Lemon's Haunted Jaunt: 3D Beginner tutorial. It builds on the original tutorial by adding a gameplay element that incorporates a dot product function, as well as linear interpolation.

The tutorial can be found here: 

[https://learn.unity.com/project/john-lemon-s-haunted-jaunt-3d-beginner/](https://learn.unity.com/project/john-lemon-s-haunted-jaunt-3d-beginner/)

## Authors

- **Ryan Gurnick**
- **Samuel Lundquist**
- **Thomas Mitchell**

## Description

John Lemon's Haunted Jaunt is a Unity tutorial project that helps Unity user's to get comfortable with the development of a stealth game. It is a single-level, third-person game where the player, John Lemon, must navigate the rooms and corridors of a haunted house to find the exit. While doing this, the player must avoid getting caught by the spooky ghosts and goblins that inhabit the house. The player must sneak past them all and win, or get caught and be sent back to the start.

## Dot Product

In this project, we use a simple dot product calculation to determine how many degrees the character's look is from the exit. This is done within the Update() loop of Guidance.cs (coded by Thomas). The distance is displayed in the top left of the Player's User Interface during gameplay. 

## Linear Interpolation

In this game, the user has a temperature displayed in the top left corner of their screen. This temperature will change based upon the direction that the player's character model is looking. When the player is looking towards the exit, the temperature is displayed as "Hot". If the player is looking near the exit, the temperature is displayed as "Warmer." Otherwise, the temperature will be "Cold."

Linear interpolation with the Color.Lerp function is used to change the color of the text that is displayed to correlate with the current temperature. This expansion of Guidance.cs functionality was coded by Ryan.

*NOTE: The dot product and linear interpolation functionality can be found in the Guidance.cs script under "..\HauntedJauntSandbox\Assets\Scripts\Guidance.cs"*

## Additional Particle Effects

A spooky particle effect was added to the Ghost prefab by Sam, which gives them a more ethereal appearance.

## Running The Game

1.) Once the repo has been pulled, you can open it with the Unity Hub by clicking the *"Add"* button. 

2.) Navigate to the directory where you pulled the repository, then select the repository folder. 

3.) Once selected, the project should now show up in the main window of the Unity Hub. From there, open it.

4.) Once the game has been opened in Unity, you can either run the game in the editor, or build the game as a WebGL application.

More information about building a project for WebGL can be found here:

[https://docs.unity3d.com/Manual/webgl-building.html](https://docs.unity3d.com/Manual/webgl-building.html)

**Compatibility Notes:** This game was built and tested with Unity 2019.1.14f1. As such, we cannot guarantee 100% functionality of the game with other versions of Unity. For this reason, we strongly recommend using this particular version when testing/playing the game. It can be found here:

[https://unity3d.com/get-unity/download/archive](https://unity3d.com/get-unity/download/archive)



