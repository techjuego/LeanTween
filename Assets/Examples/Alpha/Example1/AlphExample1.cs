using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphExample1 : MonoBehaviour
{
    public float time;
    public float alphaValue;
    private void OnEnable()
    {
        LeanTween.alpha(gameObject, alphaValue, time);
    }


}
