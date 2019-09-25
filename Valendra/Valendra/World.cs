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

        public bool AddGameObject(IGameObject gameObject)
        {
            gameObjects.Add(gameObject);
            return true;
        }

        public bool RemoveGameObject(IGameObject gameObject)
        {
            gameObjects.Remove(gameObject);
            return true;
        }

        public List<GameObject> GetObjectsAtPosition(Vector2 position)
        {
            List<GameObject> objects = new List<GameObject>();

            foreach (GameObject gameObject in gameObjects)
            {
                if (position.X > gameObject.Position.X && position.X < gameObject.Position.X + gameObject.Size.X && position.Y > gameObject.Position.Y && position.Y < gameObject.Position.Y + gameObject.Size.Y)
                {
                    //position inside object
                    objects.Add(gameObject);
                }
            }
            return objects;
        }
    }
}
