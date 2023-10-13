using Godot;
using System;

public partial class SignPopup : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Visible = false;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	private void _on_body_entered(CharacterBody2D body)
	{
		this.Visible = true;
	}

	private void _on_body_exited(CharacterBody2D body)
	{
		this.Visible = false;
	}

}
