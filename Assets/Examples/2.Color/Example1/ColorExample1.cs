using UnityEngine;
public class ColorExample1 : MonoBehaviour
{
    public GameObject objectToPerform;
    public float time;
    public Color changeColor;
    private void OnEnable()
    {
        LeanTween.color(objectToPerform, changeColor, time);
    }
}
