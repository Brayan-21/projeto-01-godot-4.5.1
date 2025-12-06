using Godot;
using System;

public partial class LevelCena01 : Node2D
{
	[Export]
	public PackedScene PlayerScene {get; set;}
		
	public override void _Ready()
	{
	
		var player = PlayerScene.Instantiate<CharacterBody2D>();
		AddChild(player);

	}

	public override void _UnhandledInput(InputEvent @event)
	{
		if(@event.IsActionPressed("ui_cancel"))
		{
			GetTree().Quit();
		}
	}

}
