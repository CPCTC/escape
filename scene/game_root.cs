using Godot;
using System;

public partial class game_root : Node3D {
    [Signal]
    public delegate void SceneExitEventHandler();

    public void OnBottleDropped() {
        EmitSignal(SignalName.SceneExit);
    }
}
