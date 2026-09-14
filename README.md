# Find A Way

**Find A Way** is a mobile arcade game originally developed independently as a self-taught developer at the age of 15. The game focuses on simple, fast-paced gameplay where the player controls a car and avoids incoming obstacles for as long as possible.

I recently revisited the project after several years, understood and worked through the existing systems, and polished the game for my CRUx project submission.

## Features

* Mobile touch-based car movement
* Randomized obstacle generation
* Collision-based game-over system
* Score and high-score system
* Increasing game difficulty over time
* Double-tap pause functionality
* Pause and lose-game menus
* Arcade-style button interactions
* Particle effects and sound effects
* Persistent high score using Unity PlayerPrefs

## Gameplay

The player controls a car using touch input and attempts to avoid incoming obstacles.

Successfully passing obstacles increases the player's score. The obstacles are continuously repositioned and randomized, allowing the game to continue indefinitely.

As the game progresses, the obstacle movement gradually becomes faster, increasing the difficulty.

The game ends when the player collides with an obstacle.

## Controls

### Mobile

* **Touch and drag:** Move the car
* **Double tap:** Pause / resume the game

## Development

The original version of *Find A Way* was built independently as a self-taught developer when I was 15.

The project was created from scratch in Unity, including the gameplay systems, obstacle behaviour, scoring system, UI, and game flow.

For the current version, I revisited the project after several years and worked through the existing code and systems before making improvements and UI/UX changes.

Some of the recent improvements include:

* Added double-tap pause functionality
* Updated and standardized fonts across the game
* Added arcade-style button interactions
* Improved the visual consistency of the UI
* Polished the overall presentation for the project submission

## Project Structure

The project is organized as a standard Unity project.

Important systems include:

* **Player** - Handles player movement, collision detection, player state, and game-over behaviour.
* **LooseCollider** - Detects obstacles passing the player and handles score increases and obstacle repositioning.
* **Barectates** - Controls obstacle movement and increasing difficulty.
* **PrimarySystem** - Handles score, high score, lose-menu behaviour, and scene transitions.
* **ArcadeButton** - Handles the visual press interaction for arcade-style UI buttons.

## Technologies

* **Unity**
* **C#**
* **Unity Input System**
* **Unity UI / TextMeshPro**
* **Unity Particle System**
* **PlayerPrefs**

## How to Open the Project

1. Clone or download this repository.
2. Open **Unity Hub**.
3. Select **Add Project** / **Open**.
4. Select the root `Find-A-Way (1)` folder.
5. Open the project using a compatible Unity version.
6. Open the relevant scene from the `Assets` folder and press **Play**.

## Repository

This repository contains the complete Unity project, including the `Assets`, `Packages`, and `ProjectSettings` required to open and work on the project.

## CRUx Submission

This version represents the final polished version of *Find A Way* submitted as a project for CRUx.

The project is intended both as a playable mobile game and as an example of my development process, including returning to and extending a project originally created several years ago.
