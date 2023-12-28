# Flying_Spacecraft

By Muhi Eddin Tahhan

## Game Features:

* The game is a spaceship’s shooting game where the player controls a spaceship that is set on a specific course to victory. Of course, the road to victory is not as easy to get to as it sounds. You need to pass through obstacles and more battleships on the road to get to the final boss and to victory.
* Used Timeline animation as a base in this project. Everything is set to fit in the timeframe that the player has to go through the entire map.
* Used assets for the spaceships, terrain’s textures, trees, and skybox.
* Used good practices like starting objects with an empty game object as a parent and then adding the prefab spaceship as a child of the empty game object, adding more features like lasers, and then prefab it again so it can be used later.

## Player:

* The player game contains the spaceship body prefab with the main camera.
* The script that is added to the player prefab are the controllers script that is responsible for the ship’s movement and firing, and the collision scripts that tells the program what to do when the box collider of the ship collides with the terrain or other ships.
* The ship’s movement is constrained by the camera’s view dimensions. The ship can’t move beyond that.
* The laser’s are made of Unity’s particle system where we added a long trail and reduced the size of the particle to get the wanted result.

![Screenshot 2023-12-22 225912](https://github.com/MuhiEddinTahhan/Flying_Spacecraft/assets/96084107/679d4659-5866-404c-b603-3c449005f601)

* Reused the enemy’s explosion effect for the player's explosion effect with the difference in coloring where we put the color scheme as subtractive “takes the original color and puts the opposite color” which explains why the explosion of the player is blue. The explosion has a certain randomness to its particles and noise to its trails so it can give a better look for a true explosion. Also we added an explosion sound to the prefab that is triggered when a collision happens.
* The movement of the ship is made so that it saves the position that is currently in at all time. That gives a more dynamic mechanics to shooting when the player comes to a specific tight spot in the game.
The laser is made so that it can bounce off objects colliders, it gives more of a chaotic theme to the game and a better way to shoot enemies.

## Enemies:

* Used assets from the asset store and we played with the scale to give a variety of enemies in the game.
* Each enemy has a certain amount of hits and it gives a certain amount of points every time it gets hit.
* Enemies use the enemy script and the collision script to function in the game.
* The enemies are designed to come in waves and every wave is a prefab by itself.
* A wave contains enemies objects that have a certain timeline that dictate their movements.
* Put a variety of enemy waves throughout the game to give a good mix of obstacles and so that it becomes harder with time.
![Screenshot 2023-12-22 235958](https://github.com/MuhiEddinTahhan/Flying_Spacecraft/assets/96084107/719d6439-2470-4f24-8f62-25f66b2458b7)

## Terrain:

* The terrain is made locally, and we imported the textures from the assets store.
* Used a variety of textures and played with some attributes like the scale of the texture and how metallic it is to give it a realistic look.
* Added a post processing effect so that the game has a certain bloom to it and we lowered the temperature so it gives it an outer space look after mixing it with the skybox prefab.
* Imported the trees so that we can add to the scene.
* Increased the maximum height of the terrain to 100 and lowered the terrain’s position to -100 so that the train’s transform would be at 0 but it would allow us to create valleys in the terrain which adds a good mix to the map.
![Screenshot 2023-12-22 235827](https://github.com/MuhiEddinTahhan/Flying_Spacecraft/assets/96084107/b73b57b5-0cee-4c71-a1df-0144cee89ce4)

## Timeline:

* Designed the game to go on a certain timeline.
* The player has a specific route that the camera will follow throughout the game.
* Used that feature to increase the speed of the game with time and to create a variety of effects.
* Each enemy wave has a specific route and shows at a specific time to the player to interact with.
* Added a small character that is made by AI to give hints to the player as he plays and add more life to the game experience.

## Special features:

* Added Text Mesh Pro to put a scoreboard to the player and show how many points he accumulated. The scoreboard uses a script that is designed to set its behavior.
* Added a music object that runs with the game. The music is made by AI and we wrote a script that makes the music only repeats when it is over. That solves the annoying problem of repeating the song every time you lose and repeat the game.
* Added an empty game object that collects all the enemies' explosion objects and destroys it from the game so that it won’t clutter the map and game hierarchy.
* The game repeats automatically when you lose allowing a more dynamic game experience.
