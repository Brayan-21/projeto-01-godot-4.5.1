using Godot;
using System;
using System.Threading.Tasks;

public partial class Menu : Control
{
	
	public override void _Ready()
	{
		GD.Print("Teste Menu Carregado");
		
		var containerButtons = GetNode<VBoxContainer>("ContainerButtons/Buttons");

		foreach (var child in containerButtons.GetChildren())
		{
			if(child is Button btn)
			{
				btn.Pressed += () => OnButtonPressed(btn);
			}
		}	
	}

	private async void OnButtonPressed(Button btn)
	{
		GD.Print($"Botão Clicado: {btn.Name}");
		var timer = GetTree().CreateTimer(0.5);

		await ToSignal(timer, "timeout");

		if(btn.Name == "ButtonPlay")
		{
			GetTree().ChangeSceneToFile("res://Scenes/Levels/level_01.tscn");	
		}
		
		if(btn.Name == "ButtonQuit")
		{
			GetTree().Quit();
		}
	}

}
