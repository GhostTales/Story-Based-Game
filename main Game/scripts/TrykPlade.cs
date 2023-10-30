using Godot;
using System;
using System.Collections.Generic;


public partial class TrykPlade : Area2D
{

	public bool CurrentState { get; private set; }
	public AnimatedSprite2D texture;
	public List<Node2D> _overlapping = new List<Node2D>();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		texture = GetNode<AnimatedSprite2D>("CollisionShape2D/AnimatedSprite2D");
		CurrentState = false;
		texture.Play("off");
	}

	private void _on_body_entered(Node2D body)
	{
		texture.Play("on");
		CurrentState = true;
		_overlapping.Add(body);
	}

	private void _on_body_exited(Node2D body)
	{
		if (_overlapping.Count == 1)
		{
			texture.Play("off");
			CurrentState = false;
		}

		_overlapping.Remove(body);
	}

}
