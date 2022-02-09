using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Extension
{
    public static class DrawUtilities
    {
        public static void Draw(this VectorStruct v, Color color)
        {
            Debug.DrawLine(Vector3.zero, new Vector3(v.x, v.y, v.z), color, 1f);
        }

        public static void Draw(VectorStruct a, VectorStruct b, Color color)
        {
            Debug.DrawLine(new Vector3(a.x, a.y, a.z), new Vector3(b.x, b.y, b.z), color, 1f);
        }
        public static void DrawOffset(VectorStruct a, VectorStruct offset, Color color)
        {
            VectorStruct b = a + offset;
            Debug.DrawLine(new Vector3(offset.x, offset.y, offset.z), new Vector3(b.x, b.y, b.z), color, 1f);
        }
    }
}