# 🧱 Tower Builder – Unity Game Project

This is a simple 3D tower stacking game developed in Unity, where players tap to drop blocks and build a tower. The game detects tilts and ends when the tower becomes unstable.

---

## 🎮 How to Play

- Tap or click on the platform to drop blocks.
- Each block gets randomly scaled and colored.
- The goal is to stack as many blocks as possible without the tower tipping over.
- The game ends when the last block tilts too far.
- Click the **Replay** button to reset and start again.

---

## 🛠️ How I Implemented This Game

- **TowerBuilder.cs** controls the main gameplay:
  - Detects player input (tap/click) to spawn a new block.
  - Randomizes each block’s **scale** and **color** for variety.
  - Tracks and updates the **score** based on the number of successfully stacked blocks.
- **BlockPhysics.cs** monitors the physics of each block:
  - Continuously checks if the latest block tilts beyond a certain angle threshold (e.g., 30 degrees).
  - If the block falls too much, the game triggers a **Game Over** event.
- **UI System**:
  - Displays the current **score**.
  - Shows a **Replay** button after game over, which reloads the scene and resets the tower.
- **Scene Setup**:
  - A simple platform acts as the base.
  - Blocks are instantiated above the platform and fall naturally using **Unity’s Rigidbody physics**.
- **Materials and Visuals**:
  - Blocks are assigned a random material color at spawn to create a lively, dynamic look.
- **Platform Targeting**:
  - Designed for both **Android** builds and **PC/Mac** (via mouse click).

---

## 🔗 Repository Link

[GitHub Repository](https://github.com/SyedHuzaifa007/Game-Dev-TowerBuilder-A3/tree/main)

---

## 🛠️ Tech Stack

- **Engine**: Unity (version 2022.3 LTS or later recommended)
- **Language**: C#
- **Platform**: Android (APK) + PC/Mac support

---

## 📁 Project Structure

```plaintext
Assets/
│
├── Materials/
│   └── BlockMat.mat
├── Prefabs/
│   └── Block.prefab
├── Scenes/
│   └── MainScene.unity
├── Scripts/
│   ├── TowerBuilder.cs
│   └── BlockPhysics.cs
├── UI/
│   ├── Canvas (Score Text, Replay Button)
│
└── Packages/
