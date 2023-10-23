using Godot;
using System;

public partial class moveable_rock : RigidBody2D
{
	Vector2 pos;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		pos = this.Position;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void _on_body_entered(Node2D body)
	{
		GD.Print(body.Name);
		GD.Print("rock moved");
		this.ApplyForce(body.Position);
	}

	public void move(Node2D body)
	{
		GD.Print(body.Name);
		GD.Print("rock moved");
		this.ApplyForce(body.Position);
	}

}
