# 2D Package Delivery Game

A top-down 2D delivery game built in Unity. Drive through a pixel-art town, pick up packages, deliver them to monster-like customers, collect boost pads for speed, and avoid crashes.

---

## Screenshots & Gameplay

### Game Map Overview

![Game Map](images/game_map.png)

---

### Boost Mechanic

> Video showing the car hitting the boost pads (cups), triggering the "Boost" text on the top left and increasing speed.

[Watch Boost Video](images/boost_demo.mp4)

---

### Package Pickup & Delivery

> Video showing the car touching the pink ice creams to pick up a package (pink particles appear), then delivering it to the monster-like customers (particles disappear on delivery).

[Watch Delivery Video](images/delivery_demo.mp4)

---

## Project Structure

```
Assets/
│
├── Scripts/
│   ├── driver.cs         # Car movement, boost collision, speed control
│   └── colllisions.cs    # Package pickup, delivery logic, win condition
│
├── Scenes/               # Unity scene files
├── Sprites/              # Pixel-art assets
└── ...
```

---

## Features

- Top-down 2D driving with WASD controls
- Package pickup system with particle effects on collection
- Delivery system — bring packages to customers to complete orders
- Boost pads increase car speed on contact with a HUD indicator
- Collision penalty — hitting obstacles reduces speed
- Win condition triggers after 5 successful deliveries

---

## Controls

| Key | Action        |
|-----|---------------|
| W   | Move forward  |
| S   | Move backward |
| A   | Steer left    |
| D   | Steer right   |

---

## How It Works

**Boost**
When the car enters a trigger tagged `boost`, the speed increases from the default value to the boosted speed and a "Boost" label appears on screen. The boost object is then destroyed.

**Package Pickup**
When the car touches an object tagged `package`, a particle system plays and the package is marked as collected.

**Delivery**
When the car reaches a `customer` trigger while carrying a package, the particle system stops, the customer object is destroyed, and the delivery counter increments. At 5 deliveries the game over/win text appears.

**Collision Penalty**
On any physics collision, the speed drops to the penalty value and the boost indicator is hidden.

---

## Requirements

- Unity 2021.3 or higher
- TextMeshPro package (included in Unity)
- New Input System package

---

## Setup

1. Clone the repository.
2. Open the project in Unity.
3. Open the main scene from the `Scenes/` folder.
4. Press Play.

---

## Notes

- `.meta` files are excluded via `.gitignore`.
- `boost`, `package`, `customer`, and `work` tags must be configured in Unity's Tag Manager for the scripts to function correctly.
- Videos can be added to the repo under a `videos/` folder or linked via GitHub Issues upload.