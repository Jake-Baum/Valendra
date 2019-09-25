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
        public World world { get; set; }
        public Vector2 position { get; set; }
        public Vector2 speed { get; set; }
        public Vector2 maxSpeed { get; set; }
        public Vector2 size { get; set; }
        public double rotation { get; set; }
        public string textureName { get; set; }
        public IGameObject parent { get; set; }
        public List<IGameObject> children { get; set; }
        public bool isVisible { get; set; }
        public bool isMovable { get; set; }
        public bool isCollidable { get; set; }
        public List<ICollisionBox> collisionBoxes { get; set; }

        public void Update()
        {

        }

        public void Draw()
        {

        }

        public void Move()
        {

        }

        public bool AddToWorld()
        {
            return false;
        }

        public void Destroy()
        {

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
