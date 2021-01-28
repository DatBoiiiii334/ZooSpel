using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenericAnimal : MonoBehaviour
{
    public string name;
       
    public GameObject Balloon;

    [SerializeField]
    public Text text;
    public string speach;

    public void SayHello()
    {
        Balloon.SetActive(true);
        text.text = speach;
    }
}
