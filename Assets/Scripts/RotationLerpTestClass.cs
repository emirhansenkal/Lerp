using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class RotationLerpTestClass : MonoBehaviour
{
    [SerializeField] private Transform startTransform = null, endTransform = null;
    
    [SerializeField] [Range(0f, 1f)] private float lerpValue = 0;
    void Update()
    {
        transform.rotation = Quaternion.Lerp(startTransform.rotation, endTransform.rotation, lerpValue);
    }
}
