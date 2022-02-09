using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Extension.DrawUtilities;

[ExecuteInEditMode]
public class Sistema : MonoBehaviour
{
    public VectorStruct vectorA, vectorB, vectorOffset;
    private VectorStruct _vectorC;
    public float m;
    public bool offsetEqualC, useLerp;
    [Range(0f,1f)]
    public float scalar;


    [ContextMenu("Multiplicar")]
    public void Multiplicar()
    {
        VectorStruct VectorM = vectorA * m;
        VectorM.Draw(Color.white);
        VectorStruct VectorN = VectorStruct.Normalize(VectorM);
        Debug.Log(VectorN.Magnitude);
    }

    void OnValidate()
    {
        _vectorC = vectorA + vectorB;
        Draw(new VectorStruct(0f, 0f, 0f), vectorA, Color.green);
        Draw(vectorA, _vectorC, Color.cyan);
        if (offsetEqualC)
        {
            vectorOffset = _vectorC;
        }
        VectorStruct vectorD = VectorStruct.Lerp(new VectorStruct(0, 0, 0), _vectorC, scalar);
        _vectorC = _vectorC * scalar;
        if (useLerp)
        {
            vectorD.Draw(Color.yellow);
        }
        else
        {
            _vectorC.Draw(Color.blue);
        }
        Vector3 vec = _vectorC;
        DrawOffset(vectorA, vectorOffset, Color.red);
    }
}

