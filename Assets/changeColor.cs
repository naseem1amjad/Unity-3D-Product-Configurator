using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    private Material selectedMaterial;

    public Material[] colourableMaterials;  //put GameObject materials here

    public Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow };  //put colors here
    void Start()
    {

    }

    public void SelectMaterial(int i)
    {
        selectedMaterial = colourableMaterials[i];
    }
    public void SetColor(int i)
    {
        selectedMaterial.color = colors[i];
    }

    public void onRed()
    {
        SelectMaterial(0);
        SetColor(0);
    }

    public void onBlue()
    {
        SelectMaterial(0);
        SetColor(1);
    }

    public void onGreen()
    {
        SelectMaterial(0);
        SetColor(2);
    }

    public void onYellow()
    {
        SelectMaterial(0);
        SetColor(3);
    }

}
