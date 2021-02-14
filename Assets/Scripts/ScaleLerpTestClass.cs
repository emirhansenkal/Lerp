using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ScaleLerpTestClass : MonoBehaviour
{

    [SerializeField] private Transform startTransform = null, endTransform = null;
    
    [SerializeField] [Range(0f, 1f)] private float lerpValue = 0;
    void Update()
    {
        transform.localScale = Vector3.Lerp(startTransform.localScale, endTransform.localScale, lerpValue);
    }
}