using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeantweenMoveExample1 : MonoBehaviour
{
    public float duration;
    public GameObject objectToPerform;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    //Move To Hit Postition
                    LeanTween.move(objectToPerform, hit.point, duration);
                }
            }
        }
    }
}
