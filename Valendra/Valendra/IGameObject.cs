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
        World World { get; set; }
        Vector2 Position { get; set; }
        Vector2 Speed { get; set; }
        Vector2 MaxSpeed { get; set; }
        Vector2 Size { get; set; }
        double Rotation { get; set; }
        string TextureName { get; set; }
        IGameObject Parent { get; set; }
        List<IGameObject> Children { get; set; }
        bool IsVisible { get; set; }
        bool IsMovable { get; set; }
        bool IsCollidable { get; set; }
        List<ICollisionBox> CollisionBoxes { get; set; }

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
