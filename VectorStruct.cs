using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct VectorStruct
{
    public float x;
    public float y;
    public float z;

    public VectorStruct(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
    public static VectorStruct operator +(VectorStruct a, VectorStruct b)
    { return new VectorStruct(a.x + b.x, a.y + b.y, a.z + b.z); }
    public static VectorStruct operator -(VectorStruct a, VectorStruct b)
    { return new VectorStruct(a.x - b.x, a.y - b.y, a.z - b.z); }
    public static VectorStruct operator *(VectorStruct a, float b)
    { return new VectorStruct(a.x * b, a.y * b, a.z * b); }
    public static VectorStruct operator *(float b, VectorStruct a)
    { return new VectorStruct(a.x * b, a.y * b, a.z * b); }
    public static VectorStruct operator /(VectorStruct a, float b)
    { return new VectorStruct(a.x / b, a.y / b, a.z / b); }
    public float Magnitude => (float)Math.Sqrt(x * x + y * y + z * z);

    public static VectorStruct Normalize(VectorStruct value)
    {
        float mag = value.Magnitude;
        if (mag > 0f)
            return value / mag;
        return new VectorStruct(0f,0f,0f);
    }

    public static VectorStruct Lerp(VectorStruct a, VectorStruct b, float t)
    {
        float t1 = (1 - t);
        return new VectorStruct(t1 * a.x + t * b.x, t1 * a.y + t * b.y, t1 * a.z + t * b.z);
    }

    public static implicit operator Vector3(VectorStruct v) => new Vector3(v.x, v.y, v.z);

    public override string ToString()
    {
        return "(" + x + "," + y + "," + z + ")";
    }
}