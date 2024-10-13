# Boss Checklist - TShock Plugin

**Author**: HDSeventh, remade by Keyou  
**Version**: 1.0.1  
**TShock API Version**: 2.1

## Overview

The **Boss Checklist** plugin for TShock allows players to easily track their progress by checking which bosses they've defeated in Terraria. Players can categorize bosses into pre-hardmode, hardmode, or event-related groups.

## Features

- Lists bosses in three categories: Pre-Hardmode, Hardmode, and Event bosses.
- Displays the kill status of each boss in real-time.
  - **✔** indicates the boss has been defeated.
  - **✖** indicates the boss is still alive or not defeated.
- Simple command-based interface for players to interact with the checklist.

## Installation

1. Download the compiled plugin `.dll` file.
2. Place the `.dll` file into your server's `TShock/ServerPlugins` folder.
3. Restart your server.

## Usage

Players can use the `/bosses` command to view their progress for bosses in Terraria. The plugin groups bosses into three main categories:

1. **Pre-Hardmode Bosses**
2. **Hardmode Bosses**
3. **Event Bosses**

### Commands

- **/bosses** `[pre-hardmode/1] | [hardmode/2] | [event/3]`
  - View a list of bosses and their kill statuses.
  
  Example usages:
  - `/bosses pre-hardmode` or `/bosses 1` – Check all Pre-Hardmode bosses.
  - `/bosses hardmode` or `/bosses 2` – Check all Hardmode bosses.
  - `/bosses event` or `/bosses 3` – Check all Event bosses.
  
  The list will display each boss and its status as either:
  - **✔** (Killed)
  - **✖** (Not Killed)

### Boss List

#### Pre-Hardmode Bosses
- Eye of Cthulhu
- King Slime
- Evil Boss (Eater of Worlds or Brain of Cthulhu)
- Queen Bee
- Skeletron
- Deerclops
- Wall of Flesh

#### Hardmode Bosses
- Queen Slime
- The Destroyer
- The Twins
- Skeletron Prime
- Plantera
- Golem
- Duke Fishron
- Empress of Light
- Lunatic Cultist
- Moon Lord

#### Event Bosses
- Mourning Wood
- Pumpking
- Everscream
- Santa-NK1
- Ice Queen
- Martian Saucer
- Solar Pillar
- Nebula Pillar
- Vortex Pillar
- Stardust Pillar

### Permissions

The plugin uses the following permissions:
- `bcheck.use` – Allows the player to use the `/bosses` command.

## Uninstallation

1. Remove the plugin `.dll` file from the `TShock/ServerPlugins` directory.
2. Restart your server.

## License

This project is open-source under the [MIT License](LICENSE). Contributions are welcome!
