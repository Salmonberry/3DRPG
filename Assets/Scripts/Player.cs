using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    
    public void Report(Vector3 value)
    {
        Debug.Log(value);
    }

    void OnDrawGizmos()
    {
        GUIStyle style = new GUIStyle();
        style.normal.textColor = RandomColor();
        Handles.Label(transform.position, gameObject.name, style);
    }


    private Color RandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color color = new Color(r, g, b);
        return color;
    }
}