using Godot;
using System;

public partial class pit_guard_mid : Node3D {

    private Node child = null;

    private void disable(Node3D _) {
        child = GetNode("pit_guard_mid");
        RemoveChild(child);
    }

    private void enable(Node3D _) {
        AddChild(child);
    }
}
