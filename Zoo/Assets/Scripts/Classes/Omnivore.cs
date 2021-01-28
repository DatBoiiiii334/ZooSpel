using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omnivore : GenericAnimal
{
    public string FoodMeatText, FoodPlantText;

    public void EatLeaves()
    {
        Balloon.SetActive(true);
        text.text = FoodPlantText;
    }

    public void EatMeat()
    {
        Balloon.SetActive(true);
        text.text = FoodMeatText;
    }
}
