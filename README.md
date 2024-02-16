# Lost In Space
## An environmental puzzle game set on an abandoned spaceship, made in Unity.
## Ben Sheldon

“Lost in Space” is a puzzle game where the player finds themself alone in an empty, eerie spaceship. As they explore their environment, they find that they can interact with the pedestals to move their environment. However, they must also collect the orbs in order to progress. As they progress through, the puzzles get progressively harder, with the player having to use their creativity to solve them. When the player completes the final puzzle, they come across the main controls for the space station and DANGER warnings. Upon interacting with the control station, the space station explodes, ending the game.

The main Unity project is contained in the PuzzleGame directory, and files showcasing the game are located in the Showcase directory.

## How to Play:
- Use WASD to move the character around the space station. 

- Use F to interact with pedestals, and walk over the glowing orbs to collect them. 

- The camera is fixed in place, and as the player moves into areas the camera can’t see, the camera will move to show the next area.

## What I Accomplished:

- I created a game where the player has to navigate through a space station, solving environmental puzzles to advance.
- I created animations for the environment to move (stairs moving, platforms moving).
- I created pedestals that have a trigger volume that activates a canvas UI, prompting the player to press F to interact (with a UI Image + Text).
- When the player presses F while in one of these trigger volumes, it triggers a piece of the environment to move, allowing the player to access a new area.
- I also created orbs that glow (emit light and have a point light inside) and oscillate up and down. When the player walks into their collider, they disappear, and the orb is “collected”.
- I created a counter that tracks the number of orbs the player has collected, and displays it on screen. When the player has collected a certain number of orbs, the door to the next level opens.
- I also created a set of trigger volumes and animations for the game camera. When the player walks into one of these trigger volumes (usually going out of view of the current camera), the camera moves to show a better view of where the player is going.
- I added sound effects to many of the actions that happen (collecting an orb, interacting with a pedestal, door opening) as well as a background ambient sound. These sound effects were all scavenged.
- I added lighting to the scene, making two directional lights match the effect of the skybox, as well as many lights throughout the game. All of the lights were baked except for the orbs.
- I created a Canvas with text for the first scene that provides a small introduction, and provides a hint on how to proceed if the button on it is clicked.
- I constructed all of the rooms and created all of the environmental puzzles, increasing in difficulty as the player progresses through the game.
- I created a particle system for the final cutscene, making the space station explode

## What I Scavenged:
A full list of everything I scavenged is below. My main inspiration for the game was Monument Valley.
- I scavenged the models and textures for the main structures (floors, walls, stairs, ceiling, orb, doors, windows, lights, and corridors) from the Sci-Fi Styled Modular Pack. 
- I scavenged the avatar model from ReadyPlayerMe, and everything else about the character from the Third Person Starter Assets Pack.
- I scavenged the audio clips from Pixabay.
- I scavenged the F interact image and the Danger Self-Destruct from Google.
- I scavenged the skybox material from the Skybox Volume 2 Assets Pack.

# Links to Scavenged Resources:
- Inspiration: Monument Valley: https://www.monumentvalleygame.com/mvpc
- Letter F Image: https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.spreadshirt.ie%2Fshop%2Fdesign%2Fletter%2Bf%2Balphabet%2Bf%2Bsquare%2Bfridge%2Bmagnet-D5f9ad8b68cb3ce1cc3bf3c0d%3Fsellable%3DQzMgxr7p2zF40OZE22RA-1599-217&psig=AOvVaw3VmuThUKb30g8z32riroHh&ust=1705627637029000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCLD8tZ_k5YMDFQAAAAAdAAAAABAI
- Emergency Self-Destruct Image: https://www.google.com/url?sa=i&url=https%3A%2F%2Ftwitter.com%2Fbellucci_0%2Fstatus%2F1347432671794786304&psig=AOvVaw0Ad847LqjdOUV9HLi07dVt&ust=1705804694992000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCOC5qun36oMDFQAAAAAdAAAAABAD
- Sci-Fi Styled Modular Pack: https://assetstore.unity.com/packages/3d/environments/sci-fi/sci-fi-styled-modular-pack-82913
- ReadyPlayerMe: https://readyplayer.me/
- All Sound Effects: https://pixabay.com/sound-effects/
- Third Person Starter Assets: https://assetstore.unity.com/packages/essentials/starter-assets-thirdperson-updates-in-new-charactercontroller-pa-196526
- Skybox Volume 2: https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-volume-2-nebula-3392
