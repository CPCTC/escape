# ESCAPE!
### By Seth Galasso, Giselle Harb, ThienTran Le, and Dhruvi Jayeshbhai Patel

Solve VR puzzles and escape the room in this singleplayer puzzle game. Your goal: open the box at the end of the room to escape.

Setup instructions:

1. Clone this repo: `git clone https://www.github.com/CPCTC/escape`
2. Clone the submodules: `git submodule update --init`
3. This project contains a symlink, which will not work in windows. On windows, delete the file `addons/godot-xr-tools`, then copy the folder `godot-xr-tools/addons/godot-xr-tools` into the `addons` folder. On Linux and Mac, it is safe to skip this step. Godot needs to be able to find the file `addons/godot-xr-tools/plugin.cfg`.
4. We used Godot version 4.2.1. Make sure you have the version with C# support, and that .NET is installed.
5. Open Godot and click `import`. Use the file manager to select the file `project.godot` in this repository.
6. The project will open in the editor. To play the game, start your OpenXR runtime (such as SteamVR), then click `Run Project` in the top-right of the Godot window. Without OpenXR running, you can still open the game and see a static camera, but you won't be able to interact.

Controls:

Hold left trigger to open the teleport indicator, and release to teleport. Pick things up with the grab buttons. Good luck!
