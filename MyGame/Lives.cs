﻿using GameEngine;
using SFML.System;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Lives : GameObject
    {
        private readonly Text _text = new Text();
        public Lives(Vector2f pos)
        {
            _text.Font = Game.GetFont("Resources/Courneuf-Regular.ttf");
            _text.Position = pos;
            _text.CharacterSize = 24;
            _text.FillColor = Color.White;
            AssignTag("lives");
        }
        public override void Draw()
        {
            Game.RenderWindow.Draw(_text);
        }
        public override void Update(Time elapsed)
        {
            GameScene scene = (GameScene)Game.CurrentScene;
            _text.DisplayedString = "Lives: " + scene.GetLives();
        }
    }
}