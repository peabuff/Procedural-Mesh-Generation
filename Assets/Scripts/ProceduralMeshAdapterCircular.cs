using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralCircularMeshGenerator : MonoBehaviour, IProceduralMeshAdapter
{
    [SerializeField] private Vector3 centerPoint = Vector3.zero;
    [SerializeField] private float radius = 2;
    [SerializeField] private int segmentCount = 3;

    private float _angleStep;
    private List<Vector3> _vertices;
    private List<int> _triangles;

    private void Start()
    {
        _angleStep = 360.0f / segmentCount;
        _vertices = new List<Vector3>();
        _triangles = new List<int>();
        SetVerticesAndTriangles();
    }

    private void SetVerticesAndTriangles()
    {
        _vertices.Add(centerPoint);
        Vector3 nextVertex;
        float currentAngle = 0f;

        
        for (int stepIndex = 0; stepIndex < segmentCount; stepIndex++)
        {
            currentAngle = _angleStep * stepIndex * Mathf.Deg2Rad;
            nextVertex = new Vector3(centerPoint.x + Mathf.Cos(currentAngle) * radius,centerPoint.y + Mathf.Sin(currentAngle) * radius,0);
            _vertices.Add(nextVertex);
            Debug.Log(nextVertex);

            var index = stepIndex - 1;
            if (index >= 0)
            {
                _triangles.Add(0);
                _triangles.Add(index+2);
                _triangles.Add(index+1);
            }

        }
        _triangles.Add(0);
        _triangles.Add(1);
        _triangles.Add(segmentCount);


    }

    public Vector3[] GetVertices()
    {
        return _vertices.ToArray();
    }

    public int[] GetTriangles()
    {
        return _triangles.ToArray();
    }
}
