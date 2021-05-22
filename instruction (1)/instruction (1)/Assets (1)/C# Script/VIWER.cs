using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VIWER : MonoBehaviour
{
    public Text ForObject;
    public string name;
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
        GetComponent<Renderer>().material.color = Color.white;
        ForObject.text = "Наведите курсор на деталь";
    }
}
