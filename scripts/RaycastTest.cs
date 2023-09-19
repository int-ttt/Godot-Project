using System.Collections.Generic;
using Godot;

public partial class RaycastTest : Node2D
{
    private List<RayCast2D> rays = new List<RayCast2D>();
    private Vector2 dir = new Vector2(0, 512);
    private List<Vector2> hits = new List<Vector2>();
    private List<Vector2> pos = new List<Vector2>();
    private NavigationAgent2D nav;

    public override void _Ready()
    {
        nav = GetChild<NavigationAgent2D>(25);
        rays.Add((RayCast2D) GetChild(0));
        rays.Add((RayCast2D) GetChild(1));
        rays.Add((RayCast2D) GetChild(2));
        rays.Add((RayCast2D) GetChild(3));
        rays.Add((RayCast2D) GetChild(4));
        rays.Add((RayCast2D) GetChild(5));
        rays.Add((RayCast2D) GetChild(6));
        rays.Add((RayCast2D) GetChild(7));
        rays.Add((RayCast2D) GetChild(8));
        rays.Add((RayCast2D) GetChild(9));
        rays.Add((RayCast2D) GetChild(10));
        rays.Add((RayCast2D) GetChild(11));
        rays.Add((RayCast2D) GetChild(12));
        rays.Add((RayCast2D) GetChild(13));
        rays.Add((RayCast2D) GetChild(14));
        rays.Add((RayCast2D) GetChild(15));
        rays.Add((RayCast2D) GetChild(16));
        rays.Add((RayCast2D) GetChild(17));
        rays.Add((RayCast2D) GetChild(18));
        rays.Add((RayCast2D) GetChild(19));
        rays.Add((RayCast2D) GetChild(20));
        rays.Add((RayCast2D) GetChild(21));
        rays.Add((RayCast2D) GetChild(22));
        rays.Add((RayCast2D) GetChild(23));
    }

    public override void _Process(double delta)
    {
        if (rays.Count > 0)
        {
            foreach (var ray in rays)
            {
                RayCast2D childRay = ray.GetChild<RayCast2D>(1);
                if (ray.IsColliding() && ((Node2D)ray.GetCollider()).Name == "TileMap")
                {
                    ((Sprite2D)ray.GetChild(0)).GlobalPosition = ray.GetCollisionPoint();
                    childRay.GlobalPosition = ray.GetCollisionPoint();
                    if (childRay.IsColliding())
                    {
                        ((Sprite2D)childRay.GetChild(0)).GlobalPosition = childRay.GetCollisionPoint();
                        hits.Add(childRay.GetCollisionPoint());
                    }
                }
                else
                {
                    ((Sprite2D)ray.GetChild(0)).Position = dir;
                    ((Node2D)ray.GetChild(1)).GlobalPosition = ray.GlobalPosition;
                    ((Sprite2D)childRay.GetChild(0)).Position = dir;
                }
            }
        }

        foreach (var hit in hits)
        {
            if (pos.Count <= 4)
            {
                break;
            }
        }

        if (Input.IsMouseButtonPressed(MouseButton.Left))
        {
            GlobalPosition = GetGlobalMousePosition();
        }
    }
    
    
}