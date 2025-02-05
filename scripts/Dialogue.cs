using Godot;

namespace WinterGame.scripts;

public partial class Dialogue : Node2D
{

	[Export]
	private Texture2D LeftCharacterSprite2D { get; set; }
	
	[Export]
	private Texture2D RightCharacterSprite2D { get; set; }	
	
	//ADICIONAR RESOURCE DE DIÁLOGO
	//ainda não criei a classe
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//AQUI VOU TER QUE PROGRAMAR AS ANIMAÇÕES DAS PERSONAGENS PROVAVELMENTE
		var leftCharacter = this.GetNode<Sprite2D>("LeftCharacter");
		var rightCharacter = this.GetNode<Sprite2D>("RightCharacter");
		leftCharacter.Texture = LeftCharacterSprite2D;
		rightCharacter.Texture = RightCharacterSprite2D;
		//ADICIONAR AQUI A CONFIGURAÇÃO DE DIÁLOGOS MAIS TARDE
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		//var leftCharacter = this.GetNode<Sprite2D>("LeftCharacter");
	}
}