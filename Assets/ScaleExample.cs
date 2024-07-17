using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleExample : MonoBehaviour
{
    public Vector3 scale;
    public GameObject m_ObjectToOperate;
    public float time;
    public LeanTweenType tweenType;
    public float delay;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ScaleObject();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            ScaleXObject();
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            ScaleYObject();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            ScaleZObject();
        }
    }
    void ScaleObject()
    {
        LeanTween.scale(m_ObjectToOperate, scale, time).setEase(tweenType).setDelay(delay);
    }

    void ScaleXObject()
    {
        LeanTween.scaleX(m_ObjectToOperate, scale.x, time).setEase(tweenType).setDelay(delay);
    }
    void ScaleYObject()
    {
        LeanTween.scaleY(m_ObjectToOperate, scale.y, time).setEase(tweenType).setDelay(delay);
    }
    void ScaleZObject()
    {
        LeanTween.scaleZ(m_ObjectToOperate, scale.z, time).setEase(tweenType).setDelay(delay);
    }
}
