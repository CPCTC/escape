using Godot;
using System;

public partial class game_bottle : Node3D {
    [Signal]
    public delegate void DroppedEventHandler();

    private bool sent = false;

    public override void _Process(double _delta) {
        float thresh = -10;
        float height = GlobalPosition.Y;
        if (sent && height > thresh) {
            sent = false;
        } else if (!sent && height < thresh) {
            sent = true;
            EmitSignal(SignalName.Dropped);
        }
    }
}
