using Godot;
using System;
using System.Collections.Generic;

public partial class MorseGenerator : Godot.Node2D
{
	private Label[] signs;
	private string[] morse = { "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." };
	private int[] codes;
	private int temp;
	private bool generated = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Generate();
	}


	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public void Generate()
	{
		codes = new int[this.GetChildCount()];
		signs = new Label[this.GetChildCount()];

		while (generated == false)
		{
			for (int i = 0; i < this.GetChildCount(); i++)
			{
				signs[i] = (GetNode<Label>($"{this.GetChild(i).GetPath()}/CollisionShape2D/Label"));

				var random = new RandomNumberGenerator();
				temp = random.RandiRange(0, 9);

				signs[i].Text = morse[temp];
				codes[i] = temp;

				generated = true;
			}
		}

	}

}
