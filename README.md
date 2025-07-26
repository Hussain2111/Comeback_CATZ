# ⚽ ComebackFC

ComebackFC is a 2D football-themed mini-game developed in Unity. The game was created in collaboration with the ComebackCatz initiative to raise awareness about microaggressions through interactive gameplay.

Players respond to inappropriate comments by selecting the best comeback — the right choice scores a goal, and the wrong one concedes. The game uses a timer, score tracker, and evolving scenarios to create a meaningful, engaging loop.

---

## 🎮 Gameplay

- The game starts with a sexist or inappropriate **comment** displayed on-screen (top goal area).
- The player is presented with **4 witty comebacks** in custom speech bubble UI.
- Tapping a comeback passes the ball — a correct response scores for the player, a bad one scores for the opponent.
- Each round loads a new scenario (comment + comebacks) while keeping the score and timer persistent.
- The game ends when the timer runs out.

---

## 🧠 Features

- ✅ Dynamic scenario system powered by `ScenarioManager` and `Scenario` scripts
- ⏱️ Countdown timer and live scoreboard
- 🎯 Speech bubble UI with transparent center for stylish text display
- 🔄 Smooth scene transitions without interrupting game flow
- 🧠 Built for WebGL deployment for easy browser testing
- 🎨 Custom design to match the ComebackCatz brand (purple-blue gradient)

---

## 📁 File Structure

Assets/
│
├── Scripts/
│ ├── BallController.cs
│ ├── Timer.cs
│ ├── Scenario.cs
│ └── ScenarioManager.cs
│
├── Scenes/
│ └── SampleScene.unity
│
├── Art/
│ └── Speech Bubbles/
│ └── speech-bubble.png
│
├── UI/
│ ├── ScoreBoard
│ ├── TimerText
│ └── GameOverPanel
│
└── Pitch/
└── Field + Ball Assets


---

## 🔧 Tech Stack

- **Engine**: Unity 6 (2D Core Template)
- **Language**: C#
- **Platform**: WebGL (HTML5)
- **UI**: Unity UI Toolkit, TextMeshPro
- **Design**: Canva, Figma (for early layout)
- **Target Device**: Mobile-first (1080x1920 resolution)

---

## 🚀 How to Play / Build

### Option 1: Play in Web Browser

> A WebGL version is available (link goes here once deployed).

### Option 2: Run Locally (Unity)

1. Open Unity 6 and clone/download this repo.
2. Open `SampleScene.unity` inside `/Scenes`.
3. Press ▶️ Play to test in the Unity Editor.
4. For Web build:
   - Go to `File > Build Settings > WebGL`
   - Click **Build and Run**

---

## ✍️ Contribution

This game was developed as part of a volunteer initiative with **ComebackCatz**, an organization committed to fighting gender-based harassment through creative digital tools.

### Developer:
- **Syed Ali Hussain**  
  Computer Science BSc (Hons), University of Kent  
  Unity Developer · Data Science Enthusiast · Marvel nerd ⚡

---

## 📸 Screenshots

> Add before/after screenshots here if you'd like.

---

## 📜 License

This project is for educational and social impact purposes only. Contact [ComebackCatz](https://app.comebackcatz.com/) for collaboration or licensing details.

