using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class ProceduralMesh : MonoBehaviour
{
    
    private Mesh _mesh;
    private MeshFilter _meshFilter;

    private void Start()
    {
        _mesh = new Mesh();
        _meshFilter = GetComponent<MeshFilter>();
        _meshFilter.mesh = _mesh;
        
        DrawMesh();
    }
    

    private void DrawMesh()
    {
        _mesh.Clear();
        var adapter = GetComponent<IProceduralMeshAdapter>();
        _mesh.vertices = adapter.GetVertices();
        _mesh.triangles = adapter.GetTriangles();

        _mesh.RecalculateNormals();
    }
}
