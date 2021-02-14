using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class PositionLerpTestClass : MonoBehaviour
{

    [SerializeField] private Transform startTransform = null, endTransform = null;
    
    [SerializeField] [Range(0f, 1f)] private float lerpValue = 0;
    void Update()
    {
        transform.position = Vector3.Lerp(startTransform.position, endTransform.position, lerpValue);
    }
}
