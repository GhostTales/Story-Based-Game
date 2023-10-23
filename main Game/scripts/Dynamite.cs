using Godot;

public partial class Dynamite : Area2D
{
	private const int StaticState = 1;
	private const int Exploding = 2;
	private const int Done = 3;
	
	private int CurrentState = StaticState;
	
	private AnimatedSprite2D anim;

public override void _Ready()
{
	anim =  GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	anim.Play("Static");
}

public override void _PhysicsProcess(double delta)
	{
		if( CurrentState == StaticState && Input.IsKeyPressed(Key.Kp8)) {
			anim.Play("Explosion");
			CurrentState = Done;
			
		}
	}
}
