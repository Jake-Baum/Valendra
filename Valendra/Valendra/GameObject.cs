using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Valendra
{
    class GameObject : IGameObject
    {
        public World World { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Speed { get; set; }
        public Vector2 MaxSpeed { get; set; }
        public Vector2 Size { get; set; }
        public double Rotation { get; set; }
        public string TextureName { get; set; }
        public IGameObject Parent { get; set; }
        public List<IGameObject> Children { get; set; }
        public bool IsVisible { get; set; }
        public bool IsMovable { get; set; }
        public bool IsCollidable { get; set; }
        public List<ICollisionBox> CollisionBoxes { get; set; }

        protected World world;
        protected Vector2 position;
        protected Vector2 speed;
        protected Vector2 maxSpeed;
        protected Vector2 size;
        protected double rotation;
        protected string textureName;
        protected IGameObject parent;
        protected List<IGameObject> children;
        protected bool isVisible;
        protected bool isMovable;
        protected bool isCollidable;
        protected List<ICollisionBox> collisionBoxes;


        public void Update()
        {
            //check if speed is greater than max speed.
            if (speed.X > maxSpeed.X)
            {
                speed.X = maxSpeed.X;
            }
            else if (speed.X < -maxSpeed.X)
            {
                speed.X = -maxSpeed.X;
            }
            if (speed.Y > maxSpeed.Y)
            {
                speed.Y = maxSpeed.Y;
            }
            else if (speed.Y < -maxSpeed.Y)
            {
                speed.Y = -maxSpeed.Y;
            }

            //Handle movement
            if (isMovable)
            {
                Move();
            }

            //Handle collisions
            if (isCollidable)
            {
                foreach (ICollisionBox collisionBox in collisionBoxes)
                {
                    //TODO: Do something with collisions
                    collisionBox.Collisions();
                }
            }
        }

        public void Draw()
        {
            if (isVisible)
            {
                Vector2 pos = WorldPosition();
                if (AssetManager.textures.ContainsKey(textureName))
                {
                    GraphicsHandler.spriteBatch.Draw(AssetManager.textures[textureName], new Rectangle((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y), Color.White);
                }
                //Draw children
                foreach (IGameObject gameObject in children)
                {
                    gameObject.Draw();
                }
            }
        }

        public void Move()
        {
            position += speed;
        }

        public bool AddToWorld()
        {
            return world.AddGameObject(this);
        }

        public void Destroy()
        {
            world.RemoveGameObject(this);
        }

        public Vector2 Centre()
        {
            return position + size / 2;
        }

        public Vector2 WorldPosition()
        {
            if (parent != null)
            {
                return parent.WorldPosition() + position;
            }
            return position;
        }
    }
}
