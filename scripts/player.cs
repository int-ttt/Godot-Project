using Godot;
using System;

public partial class player : CharacterBody2D
{
	private const int speed = 100;
	private Vector2 dir;

	public override void _PhysicsProcess(double delta)
	{
		Velocity = dir * speed;

		MoveAndSlide();
		if (Input.IsKeyPressed(Key.W))
		{
			MoveLocalY(-100 * float.Parse(delta.ToString()));
		}
		if (Input.IsKeyPressed(Key.A))
		{
			MoveLocalX(-100 * float.Parse(delta.ToString()));
		}
		if (Input.IsKeyPressed(Key.S))
		{
			MoveLocalY(100 * float.Parse(delta.ToString()));
		}
		if (Input.IsKeyPressed(Key.D))
		{
			MoveLocalX(100 * float.Parse(delta.ToString()));
		}
	}
}
