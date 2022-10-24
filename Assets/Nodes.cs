using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{

    public Color hoverColor;
    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    void OneMouseExit()
    {
        rend.material.color = startColor;
    }
}
