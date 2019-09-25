using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Valendra
{
    interface IGameObject
    {
        //---------------Attributes---------------
        Vector2 position { get; set; }
        Vector2 speed { get; set; }
        Vector2 maxSpeed { get; set; }
        Vector2 size { get; set; }
        double rotation { get; set; }
        string textureName { get; set; }
        IGameObject parent { get; set; }
        List<IGameObject> children { get; set; }
        bool isVisible { get; set; }
        bool isMovable { get; set; }
        bool isCollidable { get; set; }
        List<ICollisionBox> collisionBoxes { get; set; }

        //---------------Methods---------------
        void Update();
        void Draw();
        void Move();
        bool AddToWorld();//Returns true if added to world successfully
        void Destroy();
        Vector2 Centre();//Returns coords of centre of object
        Vector2 WorldPosition();//Returns world coords of object


    }
}
