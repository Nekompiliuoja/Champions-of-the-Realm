using Godot;
using System;

public partial class MainMenu : Godot.CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	private void _on_button_start_new_pressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Maps/Main/Main.tscn");
	}
	
	private void _on_button_load_pressed()
	{
		// Replace with function body.
	}

	private void _on_button_settings_pressed()
	{
		GetTree().ChangeSceneToFile("res://Scenes/Menus/Settings/Settings.tscn");
	}

	private void _on_button_quit_pressed()
	{
		GetTree().Quit();
	}
}