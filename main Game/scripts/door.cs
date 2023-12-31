using Godot;

public partial class door : StaticBody2D
{
	private bool CurrentState;
	private Sprite2D door_sprite;
	private TrykPlade TrykPlade;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		door_sprite = GetNode<Sprite2D>("Sprite2D");
		TrykPlade = GetNode<TrykPlade>($"{this.GetParent().GetPath()}/TrykPlade");
	}

	public override void _PhysicsProcess(double delta)
	{
		CurrentState = TrykPlade.CurrentState;
		if (CurrentState == false)
		{
			door_sprite.Texture = (Texture2D)GD.Load("res://art/objects/dør lukket.png");
			GetNode<CollisionShape2D>("CollisionShape2D").Disabled = false;
		}
		else
		{
			GetNode<CollisionShape2D>("CollisionShape2D").Disabled = true;
			door_sprite.Texture = (Texture2D)GD.Load("res://art/objects/dør åben.png");
		}
	}
}
