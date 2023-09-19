using Godot;
using System;

public partial class enermy : CharacterBody2D
{
	public const float speed = 1f;
	private NavigationAgent2D nav;
	public Node2D player;
	
	public override void _Ready()
	{
		nav = this.GetChild<NavigationAgent2D>(2);
		player = (Node2D) this.GetParent().GetChild(1);
		MakePath();
	}

	public override void _PhysicsProcess(double delta)
	{
		var dir = ToLocal(nav.GetNextPathPosition());
		Velocity = dir * speed;
		((Sprite2D)GetChild(0)).LookAt(nav.GetNextPathPosition());
		MoveAndSlide();
	}

	public void MakePath()
	{
		nav.TargetPosition = GetGlobalMousePosition();
	}

	public void _on_timer_timeout()
	{
		MakePath();
	}
}
