using Godot;
using System;
public class PlayerMovementSystem
{
	private readonly PlayerComponent _player;
	private readonly float _speed;

	public PlayerMovementSystem(PlayerComponent player, float speed)
	{
		_player = player;
		_speed = speed;
	}

	public void Update(double delta)
	{
		var input = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		_player.Velocity = input * _speed;

		_player.MoveAndSlide();
	}
}
