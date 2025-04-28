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
