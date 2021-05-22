using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class color : MonoBehaviour
{
    public Text ForObject;
    public string name;
    public Color basicColor = Color.green;
    
    
    
    void Start()
    {
        ForObject = GameObject.Find("ForObject").GetComponent<Text>();
        
        
    }

    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = Color.red;
        ForObject.text = name.ToString();
       
    }


    void OnMouseExit()
    {
       GetComponent<Renderer>().material.color = basicColor;
        ForObject.text = "Наведите курсор на деталь";
        
    }
}
