# Boss Checklist - TShock Plugin

**Author**: HDSeventh, remade by Keyou  
**Version**: 1.0.2  
**TShock API Version**: 2.1

## Overview

The **Boss Checklist** plugin for TShock helps players track their boss-killing progress in Terraria by displaying the status of Pre-Hardmode, Hardmode, and Event bosses. It provides an easy-to-use command interface to check which bosses are defeated and which are still active.

## Features

- **Categorized Boss Lists**:
  - Pre-Hardmode, Hardmode, and Event bosses are separated into distinct categories with page numbers for clarity.
  
- **Real-Time Kill Status**:
  - Displays kill status with updated symbols:
    - **O** for defeated bosses.
    - **X** for alive or undefeated bosses.

- **Enhanced Command Feedback**:
  - Usage instructions and error handling for invalid parameters.
  
## Installation

1. Download the `.dll` file for the plugin.
2. Place the `.dll` into your server's `TShock/ServerPlugins` folder.
3. Restart your server.

## Usage

Players can use the `/bosses` command to view their kill status for bosses across three categories:

1. **Pre-Hardmode Bosses** `(Bosses 1/3)`
2. **Hardmode Bosses** `(Bosses 2/3)`
3. **Event Bosses** `(Bosses 3/3)`

### Commands

- **/bosses** `[pre-hardmode/1] | [hardmode/2] | [event/3]`
  - View the status of bosses for each category.

  Example usages:
  - `/bosses pre-hardmode` or `/bosses 1` – Displays Pre-Hardmode bosses and their statuses.
  - `/bosses hardmode` or `/bosses 2` – Displays Hardmode bosses and their statuses.
  - `/bosses event` or `/bosses 3` – Displays Event bosses and their statuses.

  Boss statuses will be shown as:
  - **O** (Defeated)
  - **X** (Not Defeated)

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

To use the `/bosses` command, the following permission is required:
- `bcheck.use` – Grants players access to the boss checklist command.

## Uninstallation

1. Remove the `.dll` file from your server's `TShock/ServerPlugins` directory.
2. Restart your server.

## License

This project is licensed under the [MIT License](LICENSE). Contributions and improvements are welcome!
