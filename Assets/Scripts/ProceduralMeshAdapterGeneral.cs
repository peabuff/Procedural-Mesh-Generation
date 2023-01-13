using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralMeshAdapterGeneral : MonoBehaviour, IProceduralMeshAdapter
{
    [SerializeField] 
    private Vector3[] vertices;
    [SerializeField] 
    private int[] triangles;

    public Vector3[] GetVertices()
    {
        return vertices;
    }

    public int[] GetTriangles()
    {
        return triangles;
    }
}
