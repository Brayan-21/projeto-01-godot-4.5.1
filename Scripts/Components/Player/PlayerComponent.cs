using Godot;
using System;

public partial class PlayerComponent : CharacterBody2D
{

	private PlayerMovementSystem _playerMovementSystem;
	private float speed;
	
	public override void _Ready()
	{
		GD.Print("Player Carregado!");
		speed = 600f;
		_playerMovementSystem = new PlayerMovementSystem(this, speed);
	}

	public override void _PhysicsProcess(double delta)
	{
		_playerMovementSystem.Update(delta);
	}

}
