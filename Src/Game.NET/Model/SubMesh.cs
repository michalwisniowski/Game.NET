using System.Collections.Generic;
using System.Numerics;

namespace Game.NET
{
    public class SubMesh
    {
        public SubMesh()
        {
            Vertices = new List<Vector3>();
            Textures = new List<Vector3>();
            Normals = new List<Vector3>();
            Faces = new List<Face>();
        }

        public List<Vector3> Vertices { get; set; }
        public List<Vector3> Textures { get; set; }
        public List<Vector3> Normals  {get ;set;}
        public List<Face> Faces { get; set; }
    }
}