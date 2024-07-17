using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveExample : MonoBehaviour
{
    public Vector3 MovePosition;
    public GameObject m_ObjectToOperate;
    public float time;
    public LeanTweenType tweenType;
    public float delay;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveObject();
        }
    }

    void MoveObject()
    {
        LeanTween.move(m_ObjectToOperate, MovePosition, time).setEase(tweenType).setDelay(delay);
    }
}
