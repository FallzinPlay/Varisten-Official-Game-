﻿using Microsoft.Xna.Framework.Graphics;
using EngineFP;
using Varisten.Objects.Atributes;
using Effect = Varisten.Objects.Atributes.Effect;

namespace Varisten.Objects.Items
{
    public abstract class Item : Instance
    {
        // Geral
        public string Name { get; set; }
        public double Weight { get; protected set; }
        public double Price { get; protected set; }
        public Sprite Sprites { get; protected set; }
        public Texture2D CurrentSprite { get; set; }
        // Effects
        public Effect Effect { get; protected set; }

        public Item(Texture2D hitboxSprite) : base(hitboxSprite) { }
    }
}
