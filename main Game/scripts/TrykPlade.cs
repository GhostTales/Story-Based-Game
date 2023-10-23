using Godot;
using System;


public partial class TrykPlade : Area2D
{
	public AnimatedSprite2D texture;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		texture = GetNode<AnimatedSprite2D>("CollisionShape2D/AnimatedSprite2D");

		texture.Play("off");
	}

	private void _on_body_entered(Node2D body)
	{
		texture.Play("on");
	}

	private void _on_body_exited(Node2D body)
	{
		texture.Play("off");
	}

}
