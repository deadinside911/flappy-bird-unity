# flappy bird

Flappy bird game in Unity

The twist to the original Flappy Bird game is a "Potion" effect that affects its flap strength. Inspiration includes on campus experiences at various restaurants, fests, etc. This was implemented using Unity Scriptable Objects. 

Although the docs primarily describe them as containers for shared data, such as data values that go into prefabs for example, but they can also define behaviour, which is what is done in this project. Following the tutorial, first an abstract class is defined that requires a method for the application of the powerup, and then a custom powerup is defined based on inheritance from that class. After this, the actual MonoBehaviour is defined that will trigger the powerup on collision with it.

No AI was used in the making of this project.

## Improvements I want to make

1. Sort the UI, start off with a "Play game" screen instead of starting right away
2. Add a camera shake when the powerup is applied and change the bird's color when the powerup is applied
3. Add a shop from where multiple "skins" can be bought
4. Track player highscore
5. Add some animations to the bird
6. Add sound effects
7. Add moving pipes
8. Add more powerups, and randomly spawn them
9. Add background clouds using the particle effect system

## Games I want to make

Based on the web novel `Shadow slave`, similar in concept to `Solo Levelling`, a dungeon crawler game with crazy art, camera angles, and cut scenes.

## Resources

1. [Powerups](https://www.youtube.com/watch?v=PkNRPOrtyls)
