using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Valendra
{
    static class AssetManager
    {
        public static Dictionary<string, Texture2D> textures;

        public static void Load(ContentManager contentManager)
        {
            textures = new Dictionary<string, Texture2D>();
        }
    }
}
