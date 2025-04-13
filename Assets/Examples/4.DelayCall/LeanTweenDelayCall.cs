using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeanTweenDelayCall : MonoBehaviour
{
    public float timeDelay;
    private void OnEnable()
    {
        LeanTween.delayedCall(timeDelay, () =>
         {
             gameObject.SetActive(false);
         });
    }
}
