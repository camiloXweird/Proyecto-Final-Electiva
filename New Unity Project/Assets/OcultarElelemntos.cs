using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcultarElelemntos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject banana, bread, burguer, cheese, chicken, ice_cream, onion, pizza, meat, wine;
    void Start()
    {
        banana = GameObject.Find("Banana");
        banana.SetActive(false);
        bread = GameObject.Find("Bread");
        bread.SetActive(false);
        burguer = GameObject.Find("Burger");
        burguer.SetActive(false);
        cheese = GameObject.Find("Cheese");
        cheese.SetActive(false);
        chicken = GameObject.Find("Chicken");
        chicken.SetActive(false);
        ice_cream = GameObject.Find("IceCream");
        ice_cream.SetActive(false);
        onion = GameObject.Find("Onion");
        onion.SetActive(false);
        pizza = GameObject.Find("Pizza");
        pizza.SetActive(false);
        meat = GameObject.Find("Meat");
        meat.SetActive(false);
        wine = GameObject.Find("Wine");
        wine.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
