using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ColorLerpTestClass : MonoBehaviour
{
    [SerializeField] private Color startColor = Color.white, endColor = Color.black;
    
    [SerializeField] [Range(0f, 1f)] private float lerpValue = 0;
    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        _meshRenderer.material.color = Color.Lerp(startColor, endColor, lerpValue);
    }
}
