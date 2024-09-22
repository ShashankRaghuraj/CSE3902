using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using Sprint0;

public class MouseController : IController {

	private Game1 programGame;

	public MouseController(Game1 g) {
		programGame = g;
	}

	void IController.Update() {
		MouseState ms = Mouse.GetState();
		bool mouseDown = ms.LeftButton == ButtonState.Pressed;
		double width = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width / 2.2;
		double height = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height / 2.2;

		if (mouseDown && ms.X < width / 2 && ms.Y < height / 2) {
			programGame.setMode(1);	
		} else if(mouseDown && ms.X < width / 2 && ms.Y >= height / 2) {
			programGame.setMode(3);
		} else if (mouseDown && ms.X >= width / 2 && ms.Y < height / 2) {
			programGame.setMode(2);
		} else if(mouseDown){
			programGame.setMode(4);
		}
	}

	public void Test() {

	}
}
