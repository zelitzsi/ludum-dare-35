﻿using Microsoft.Xna.Framework;

namespace Shapeshift
{
    class Villager : GameObject
    {
        Sprite sprite;
        Point delta;
        int acceleration = 1;
        int maxXSpeed = 4;
        int maxYSpeed = 4;
        CollisionData lastCollisions;

        public Villager(Point pos) : base()
        {
            this.sprite = new Sprite("Janet", 32, 64);
            this.aabb = new Rectangle(pos.X, pos.Y, 32, 32);
        }

        public override void LoadContent()
        {
            sprite.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
        }

        public override void Draw()
        {
            sprite.Draw(new Vector2(aabb.Left, aabb.Top - 32));
        }
    }
}
