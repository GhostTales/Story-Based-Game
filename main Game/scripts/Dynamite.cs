using Godot;

public partial class Dynamite : Area2D
{
	private const int StaticState = 1;
	private const int One = 2;
	private const int Three = 3;
	private const int Nine = 4;
	private const int Done = 5;
	
	private int CurrentState = StaticState;
	
	private AnimatedSprite2D anim;

public override void _Ready()
{
	anim =  GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	anim.Play("Static");
}

public override void _PhysicsProcess(double delta)
	{
		if( CurrentState == StaticState && Input.IsKeyPressed(Key.Kp1)) {
			anim.Play("One");
			CurrentState = One;
			}
		if( CurrentState == One && Input.IsKeyPressed(Key.Kp3)) {
			anim.Play("Three");
			CurrentState = Three;
			}
			if( CurrentState == One && Input.IsKeyPressed(Key.Kp2)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == One && Input.IsKeyPressed(Key.Kp4)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == One && Input.IsKeyPressed(Key.Kp5)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == One && Input.IsKeyPressed(Key.Kp6)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == One && Input.IsKeyPressed(Key.Kp7)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == One && Input.IsKeyPressed(Key.Kp8)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == One && Input.IsKeyPressed(Key.Kp9)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
		if( CurrentState == Three && Input.IsKeyPressed(Key.Kp9)) {
			anim.Play("Nine");
			CurrentState = Nine;
			}
			if( CurrentState == Three && Input.IsKeyPressed(Key.Kp1)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Three && Input.IsKeyPressed(Key.Kp2)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Three && Input.IsKeyPressed(Key.Kp4)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Three && Input.IsKeyPressed(Key.Kp5)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Three && Input.IsKeyPressed(Key.Kp6)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Three && Input.IsKeyPressed(Key.Kp7)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Three && Input.IsKeyPressed(Key.Kp8)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
		if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp4)) {
			anim.Play("Explosion");
			CurrentState = Done;
			}
			if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp1)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp2)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp3)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp5)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp6)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp7)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
			if( CurrentState == Nine && Input.IsKeyPressed(Key.Kp8)) {
			anim.Play("Static");
			CurrentState = StaticState;
			}
	}
}
