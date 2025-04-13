using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LT_DrawBezierpath : MonoBehaviour
{
    public Vector3 a;
    public Vector3 b;
    public Vector3 c;
    public Vector3 d;
    private void OnDrawGizmos()
    {
        LeanTween.drawBezierPath(a, b, c, d);
    }
}
