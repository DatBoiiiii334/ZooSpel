using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Herbivore : GenericAnimal
{

    public string FoodPlantText;

public void Start(){
    
}
    public void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = FoodPlantText;
    }
}
