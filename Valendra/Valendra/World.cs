using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Valendra
{
    class World
    {
        public Camera camera;
        public List<IGameObject> gameObjects;

        public void Update()
        {
            foreach (IGameObject gameObject in gameObjects)
            {
                gameObject.Update();
            }
        }

        public void Draw()
        {
            foreach (IGameObject gameObject in gameObjects)
            {
                gameObject.Draw();
            }
        }

        public List<GameObject> GetObjectsAtPosition(Vector2 position)
        {
            List<GameObject> objects = new List<GameObject>();

            foreach (GameObject gameObject in gameObjects)
            {
                if (position.X > gameObject.position.X && position.X < gameObject.position.X + gameObject.size.X && position.Y > gameObject.position.Y && position.Y < gameObject.position.Y + gameObject.size.Y)
                {
                    //position inside object
                    objects.Add(gameObject);
                }
            }
            return objects;
        }
    }
}
