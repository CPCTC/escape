using Godot;
using System;

public partial class counter : Node {
    [Signal]
    public delegate void OpenEventHandler();

    private bool sent = false;
    private int i = 0;
    private void enter(Node3D body) {
            i++;
            if (!sent && (i == 5)) {
                sent = true;
                EmitSignal(SignalName.Open);
            }
    }
    private void leave(Node3D body) {
            i--;
    }
}
