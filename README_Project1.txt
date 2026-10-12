Project 1 
CPSC 386 

1. Game Description:

Space Defender is a 2D arcade shooter developed in Unity 6. The player controls a spaceship and must destroy incoming asteroids while avoiding collisions. Destroying asteroids increases the player's score, while collisions reduce their health. The game ends when the player runs out of health.

The game includes a main menu, gameplay scene, scoring system, object pooling, pause functionality, 2D physics, and persistent high-score saving.

2. Controls:

- W / A / S / D: Move the spaceship
- Arrow keys: Alternative movement controls
- Spacebar: Shoot
- Escape: Pause or resume

3. Scenes:

MainMenu: Contains the game title, instructions, Start Game button, Quit button, and high-score display. The Start button loads the Gameplay scene.

Gameplay: Contains the spaceship, asteroids, bullet and asteroid object pools, Tilemap arena, lighting effect, gameplay UI, pause menu, and Game Over screen.

4. Script Summary:

- PlayerMovement.cs: Uses the new Input System and Rigidbody2D to move the spaceship.
- PlayerShooter.cs: Receives the Fire input action and retrieves bullets from the object pool.
- Bullet.cs: Moves lasers upward, detects asteroid collisions, and disables bullets for reuse.
- SimplePool.cs: Creates a fixed number of reusable prefab objects and provides inactive instances when requested.
- Asteroid.cs: Moves asteroids downward and detects collisions with the player.
- AsteroidSpawner.cs: Requests pooled asteroids and places them at random spawn positions.
- GameManager.cs: Manages score, health, the Game Over condition, and saved high scores.
- MainMenu.cs: Handles Start Game, Quit, and the saved high-score display.
- PauseMenu.cs: Handles pausing, resuming, restarting, and returning to the Main Menu.

5. Project Requirements
------------------------------------------------------

1. Scenes: MainMenu and Gameplay are connected through SceneManager.LoadScene().
2. Input System: The player uses a PlayerInput component and Input Actions asset to move and fire.
3. Tilemap: The Gameplay scene uses a Tilemap arena with Tilemap Collider 2D.
4. Object Pooling: Bullet and asteroid prefabs are pre-created and reused with SetActive() instead of repeatedly instantiated and destroyed.
5. Tags, Layers, and Triggers: Player and Asteroid tags, physics layers, and OnTriggerEnter2D detect interactions.
6. Pause Menu: The Canvas pause menu uses Time.timeScale to pause and resume gameplay, with a Quit-to-Menu button.
7. PlayerPrefs: The high score is saved with PlayerPrefs.SetInt() and loaded using PlayerPrefs.GetInt().
8. Lighting: A 2D Light provides a visual glow effect on the player's spaceship.
------------------------------------------------------

6. Object Pooling Explanation:

The SimplePool script creates a fixed number of bullet or asteroid objects during initialization.

When an object is needed, an inactive instance is activated and repositioned. When the object hits something or leaves the screen, it is deactivated and becomes available for reuse.

This minimizes runtime instantiation and destruction.

7. Assets, Packages, and References

The game uses Unity's built-in sprites, 2D physics, Tilemap tools, UI components, and rendering tools.

The implementation draws on course lecture examples covering scripting, object pooling, Input System controls, PlayerPrefs, scene management, Canvas UI, and pause functionality.
Used some assistance from ChatGPT when stuck to troubleshoot, most assets are self made or a collaborative effort with friends.

8. GitHub Repository

https://github.com/maslam3-git/MyProj1

9. Build and Testing

Unity version: 6000.0.83f1 LTS

Build platform: Windows

Testing: Tested the main menu and pause menu function. All buttons perform as they should. Movement controls function correctly along with gameplay functions. Added music perform correctly. The score tracking functions as expected. No known bugs. 


