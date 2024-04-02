using Godot;
using System;

public partial class main_root : Node3D {
    public override void _Ready() {
        xr_init();
    }

    private void xr_init() {
        var xr = XRServer.FindInterface("OpenXR");
        if (xr != null && xr.IsInitialized()) {
            DisplayServer.WindowSetVsyncMode(DisplayServer.VSyncMode.Disabled);
            GetViewport().UseXR = true;
        } else {
            GD.Print("I can't find a VR headset. Plug one in and restart the game.");
        }
    }

    // Must only be called during idle time.
    // See the signal connection menu -> `Advanced` -> `Deferred`
    private void GameOver() {
        GetNode("game").Free();
        GetNode("xr/xr_cam").AddChild(
            ResourceLoader.Load<PackedScene>("res://scene/gameover.tscn")
                .Instantiate()
        );
    }
}
