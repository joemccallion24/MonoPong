﻿using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace MyProject.Score
{
    public class Score
    {

        public int playerScore;
        public int AIscore; //Maybe Player 2 score in future?

        private SpriteFont _font;

        public Score(SpriteFont font)
        {
            _font = font;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(_font, playerScore.ToString(), new Vector2(300, 70), Color.White);
            spriteBatch.DrawString(_font, AIscore.ToString(), new Vector2(450, 70), Color.White);
        }
            
        
    }
}
