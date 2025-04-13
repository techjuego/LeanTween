using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUiExample : MonoBehaviour
{
    public GameObject panel;
    public float duration = 0.3f;
    private void OnEnable()
    {
        LeanTween.moveLocalX(panel, -Screen.width * 2, 0);
    }
    public void ShowPanel1()
    {
        LeanTween.moveLocalX(panel,0, duration);
    }
    public void ClosePanel1()
    {
        LeanTween.moveLocalX(panel, -Screen.width * 2, duration);

    }
}
