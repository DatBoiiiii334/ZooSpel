using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carnivore : GenericAnimal
{
    public string FoodMeatText;

    public void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = FoodMeatText;
    }
}
