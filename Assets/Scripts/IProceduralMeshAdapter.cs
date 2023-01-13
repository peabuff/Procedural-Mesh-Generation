using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IProceduralMeshAdapter
{
    Vector3[] GetVertices();
    int[] GetTriangles();
}
