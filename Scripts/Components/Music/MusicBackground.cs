using Godot;
using System;

public partial class MusicBackground : AudioStreamPlayer
{
	public override void _Ready()
	{
		GD.Print("Entrando no MusicBackground!");
		Play();
	}
	
}
