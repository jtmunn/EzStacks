# EzStacks

A utility tool for 7 Days to Die that modifies item stack sizes in the game's `items.xml` configuration file.

## Description

EzStacks is a tool that automatically updates the stack size of all items in 7 Days to Die to 50,000 units. It works by modifying the `Stacknumber` property in the game's `items.xml` configuration file.

## Installation & Usage

There are two ways to use EzStacks:

### Method 1: Context Menu Integration (Recommended)

1. Copy `EzStacks.exe` to `C:\Utilities\7d2d\` (create folders if they don't exist)
2. Double-click `AddEzStacksContext.reg` to add the context menu entry
3. Right-click any XML file and select "Update Stacknumber with EzStacks"

### Method 2: Command Line

Run the program directly from the command line:

```bash
EzStacks.exe <path_to_items.xml>
```

Example:
```bash
EzStacks.exe "C:\Games\Steam\steamapps\common\7 Days To Die\Data\Config\items.xml"
```

## Features

- Modifies all item stack sizes to 50,000
- Preserves XML formatting and comments
- Two usage methods:
  - Context menu integration for easy access
  - Command line interface for advanced users
- Automatically processes all items in the configuration file

## Requirements

- .NET 8.0 Runtime
- 7 Days to Die game installation

## Note

Always backup your original `items.xml` file before running this utility.