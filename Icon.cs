using Godot;
using System;

public partial class Icon : Sprite2D
{

	private bool start;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		this.MoveLocalX(1);
		this.MoveLocalY(1);
		if (this.Position.X > 50)
		{
			this.Position = new Vector2(0, 0);
		}
	}
}
