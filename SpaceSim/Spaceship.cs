using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceSim
{
    public class Spaceship
    {
        public Matrix Transform;

        Model model;
        Texture2D texture;

        public Spaceship(Matrix transform, ContentManager content)
        {
            this.Transform = transform;

            model = content.Load<Model>("Spaceship");
            texture = content.Load<Texture2D>("Spaceship_Material_Diffuse");

            foreach (BasicEffect effect in model.Meshes[0].Effects)
            {
                effect.Texture = texture;
                effect.TextureEnabled = true;
                effect.EnableDefaultLighting();
            }
        }

        public void Draw()
        {
            foreach (ModelMesh mesh in model.Meshes)
            {
                foreach (BasicEffect basicEffect in mesh.Effects)
                {
                    basicEffect.World = this.Transform;
                    basicEffect.View = SpaceSim.World.View;
                    basicEffect.Projection = SpaceSim.World.Projection;
                }
                mesh.Draw();
            }
        }
    }
}
