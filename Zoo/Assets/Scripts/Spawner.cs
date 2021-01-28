using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        public List<GameObject> AnimalsInScene;
        public Text NameField;
        private string _namefield;

        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra;
        private void Start()
        {
            _namefield = NameField.text;

            GameObject henk;
            henk = Instantiate(lion,transform);
            AnimalsInScene.Add(henk.gameObject);
            henk.GetComponent<Carnivore>().name = "henk";
            henk.GetComponent<Carnivore>().speach = "roooaoaaaaar";
            henk.GetComponent<Carnivore>().FoodMeatText = "nomnomnom thx mate";

            GameObject elsa;
            elsa = Instantiate(hippo,transform);
            AnimalsInScene.Add(elsa.gameObject);
            elsa.GetComponent<Herbivore>().name = "elsa";
            elsa.GetComponent<Herbivore>().speach = "splash";
            elsa.GetComponent<Herbivore>().FoodPlantText = "munch munch lovely";

            GameObject dora;
            dora = Instantiate(pig,transform);
            AnimalsInScene.Add(dora.gameObject);
            dora.AddComponent<SpecialTrick>();
            dora.GetComponent<Omnivore>().name = "dora";
            dora.GetComponent<Omnivore>().speach = "oink oink";
            dora.GetComponent<Omnivore>().FoodPlantText = "munch munch oink";
            dora.GetComponent<Omnivore>().FoodMeatText = "nomnomnom oink thx";

            GameObject wally;
            wally = Instantiate(tiger,transform);
            AnimalsInScene.Add(wally.gameObject);
            wally.AddComponent<SpecialTrick>();
            wally.GetComponent<Carnivore>().name = "wally";
            wally.GetComponent<Carnivore>().speach = "rraaarww";
            wally.GetComponent<Carnivore>().FoodMeatText = "nomnomnom thx wubalubadubdub";

            GameObject marty;
            marty = Instantiate(zebra,transform);
            AnimalsInScene.Add(marty.gameObject);
            marty.GetComponent<Herbivore>().name = "marty";
            marty.GetComponent<Herbivore>().speach = "zebra zebra";
            marty.GetComponent<Herbivore>().FoodPlantText = "munch munch zank yee bra";

            ///Nieuwe dieren
            GameObject Billy;
            Billy = Instantiate(tiger,transform);
            AnimalsInScene.Add(Billy.gameObject);
            Billy.AddComponent<SpecialTrick>();
            Billy.GetComponent<Carnivore>().name = "Billy";
            Billy.GetComponent<Carnivore>().speach = "Hi dad! :D";
            Billy.GetComponent<Carnivore>().FoodMeatText = "Thanks dad! :)"; 

            GameObject Sara;
            Sara = Instantiate(hippo,transform);
            AnimalsInScene.Add(Sara.gameObject);
            Sara.GetComponent<Herbivore>().name = "Sara";
            Sara.GetComponent<Herbivore>().speach = "Buenos dias";
            Sara.GetComponent<Herbivore>().FoodPlantText = "muchas gracias!";       
        }

        public void SaySpeach(){
            if(!string.IsNullOrWhiteSpace(NameField.text)){
                for(int i=0; i<AnimalsInScene.Count; i++){
                    if(AnimalsInScene[i].GetComponent<GenericAnimal>().name == NameField.text){
                        AnimalsInScene[i].GetComponent<GenericAnimal>().SayHello();
                    }else{
                        Debug.Log(NameField.text + " Is not valid");
                    }
                }
            }else{
                for(int i=0; i<AnimalsInScene.Count; i++){
                    AnimalsInScene[i].GetComponent<GenericAnimal>().SayHello();
                }
            }
        }

        public void FeedCarnivores(){
            for(int i=0; i<AnimalsInScene.Count; i++){
                if(AnimalsInScene[i].GetComponent<Carnivore>() != null){
                    AnimalsInScene[i].GetComponent<Carnivore>().EatMeat();
                }else if(AnimalsInScene[i].GetComponent<Omnivore>() != null){
                    AnimalsInScene[i].GetComponent<Omnivore>().EatMeat();
                }
            }
        }

        public void FeedHerbivores(){
            for(int i=0; i<AnimalsInScene.Count; i++){
                if(AnimalsInScene[i].GetComponent<Herbivore>() != null){
                    AnimalsInScene[i].GetComponent<Herbivore>().EatLeaves();
                }else if(AnimalsInScene[i].GetComponent<Omnivore>() != null){
                    AnimalsInScene[i].GetComponent<Omnivore>().EatLeaves();
                }
            }
        }

        public void DoATrick(){
            for(int i=0; i<AnimalsInScene.Count; i++){
                if(AnimalsInScene[i].GetComponent<SpecialTrick>() != null){
                    AnimalsInScene[i].GetComponent<SpecialTrick>().PerformTrick();
                }
            }
        }
    }
}
