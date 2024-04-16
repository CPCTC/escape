using Godot;
using System;

public partial class AnimationPlayer : Godot.AnimationPlayer {
    private void Go() {
        this.Play("open");
    }
}
