using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Valendra
{
    interface ICollisionBox
    {
        //---------------Attributes---------------
        Vector2 position { get; set; }
        Vector2 size { get; set; }
        IGameObject gameObject { get; set; }

        //---------------Methods---------------
        List<IGameObject> Collisions();
        Vector2 WorldCoords();
    }
}
