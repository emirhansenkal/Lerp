using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class AllLerpTestClass : MonoBehaviour
{

    [SerializeField] private Transform startTransform = null, endTransform = null;
    
    [SerializeField] [Range(0f, 1f)] private float lerpValue = 0;

    private MeshRenderer _meshRenderer, _startObjectMeshRenderer, _endObjectMeshRenderer;

    private void OnValidate()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _startObjectMeshRenderer = startTransform.GetComponent<MeshRenderer>();
        _endObjectMeshRenderer = endTransform.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(startTransform.position, endTransform.position, lerpValue);
        transform.rotation = Quaternion.Lerp(startTransform.rotation, endTransform.rotation, lerpValue);
        transform.localScale = Vector3.Lerp(startTransform.localScale, endTransform.localScale, lerpValue);
        
        _meshRenderer.material.color = Color.Lerp(_startObjectMeshRenderer.material.color, _endObjectMeshRenderer.material.color, lerpValue);
    }
}
