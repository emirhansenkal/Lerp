using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class IntLerpTestClass : MonoBehaviour
{

    [SerializeField] private int startValue = 0, endValue = 100;
    [SerializeField] private int currentValue = 0;
    
    [SerializeField] [Range(-1f,2f)] private float lerpValue = 0;
    
    [SerializeField] private bool isUnclamped = false;
    void Update()
    {
        if (isUnclamped)
        {
            currentValue = (int)Mathf.LerpUnclamped(startValue, endValue, lerpValue);
        }
        else
        {
            currentValue = (int) Mathf.Lerp(startValue, endValue, lerpValue);
        }

    }
}
