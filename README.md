# 🏴‍☠️ CossackLive

**Solo RPG prototype (UE5)** — core loop: camp → quest → skirmish → loot → rest.
Target: 60 FPS @1080p, single-player, client-side.

---

## 🧩 Architecture

| Module | Purpose                                       |
|--------|-----------------------------------------------|
| Core   | Character, Components, GameMode               |
| Data   | PrimaryDataAssets (ItemDef, QuestDef)         |
| UI     | Inventory, HUD, Menus                         |
| Levels | Persistent + Sublevels (Camp, House, Cellar)  |
| Art    | Static/Nanite meshes, Materials, Textures     |

---

## ⚙️ Technical Stack
- Unreal Engine 5.x
- C++ + Blueprints
- Enhanced Input
- Lumen + Nanite (Medium/High)
- Instanced Static Mesh optimization

---

## 📜 Git Commit Convention
feat: inventory component
fix: camera zoom limits
docs: repo structure
chore: init LFS + repo
