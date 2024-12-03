﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordMemori.Component;

namespace WordMemori.GameObject
{
    public class Button : Sprite
    {
        private bool _isHover { get; set; } = false;
        private bool _isPressed = false;
        public bool IsPressed {
            get
            {
                bool value = _isPressed;
                if (_isPressed)
                    _isPressed = false;
                return value;
            }
             }

        // Consructoer
        public Button(string imgName, int x, int y) : base(imgName, x, y)
        {
        }

        // Update
        public override void Update(GameTime gameTime, Input input)
        {
            // Handle mouse state: set isPressed, set color
            if(_destinationRec.Contains(input.GetMousePosition()))
            {
                // Hover
                _isHover = true;
                _color = Color.LightGray;
                
                // Mousedown
                if (input.IsLeftMouseDown())
                    _color = Color.Gray;
                
                // Pressed
                if (input.IsLeftMousePressed()){
                    _isPressed = true;
                }
            }
            else
            {
                _isHover=false;
                _color = Color.White;
                
            }
            base.Update(gameTime, input);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}