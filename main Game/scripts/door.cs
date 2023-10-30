using Godot;
using System;

public partial class door : StaticBody2D
{
	private const int Off = 1;
	private const int On = 2;
	private int CurrentState = Off;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	
	}
	
	public override void _PhysicsProcess(double delta)
	{
		if( CurrentState == Off) {
			
		}
	}
}
