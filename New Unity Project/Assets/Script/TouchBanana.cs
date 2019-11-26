using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBanana : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject banana, bread, burguer, cheese, chicken, ice_cream, onion, pizza, meat, wine,banana2, bread2, burguer2, cheese2, chicken2, ice_cream2, onion2, pizza2, meat2, wine2;
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
        banana2 = GameObject.Find("Banana2");
        banana2.SetActive(false);
        bread2 = GameObject.Find("Bread2");
        bread2.SetActive(false);
        burguer2 = GameObject.Find("Burger2");
        burguer2.SetActive(false);
        cheese2 = GameObject.Find("Cheese2");
        cheese2.SetActive(false);
        chicken2 = GameObject.Find("Chicken2");
        chicken2.SetActive(false);
        ice_cream2 = GameObject.Find("IceCream2");
        ice_cream2.SetActive(false);
        onion2 = GameObject.Find("Onion2");
        onion2.SetActive(false);
        pizza2 = GameObject.Find("Pizza2");
        pizza2.SetActive(false);
        meat2 = GameObject.Find("Meat2");
        meat2.SetActive(false);
        wine2 = GameObject.Find("Wine2");
        wine2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.transform.gameObject.CompareTag("CuboBanana"))
                {
                    banana.SetActive(true);
                    // if(banana2.activeSelf){
                    //     banana.SetActive(false);
                    //     banana2.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBanana2"))
                {
                    banana2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBread"))
                {
                    bread.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBread2"))
                {
                    bread2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboCheese"))
                {
                    cheese.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboCheese2"))
                {
                    cheese2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboChicken"))
                {
                    chicken.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboChicken2"))
                {
                    chicken2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboIceCream"))
                {
                    ice_cream.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboIceCream2"))
                {
                    ice_cream2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBurger"))
                {
                    burguer.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBurger2"))
                {
                    burguer2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboMeat"))
                {
                    meat.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboMeat2"))
                {
                    meat2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboOnion"))
                {
                    onion.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboOnion2"))
                {
                    onion2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboPizza"))
                {
                    pizza.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboPizza2"))
                {
                    pizza2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboWine"))
                {
                    wine.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboWine2"))
                {
                    wine2.SetActive(true);
                    // if(banana.activeSelf){
                    //     banana2.SetActive(false);
                    //     banana.SetActive(false);
                    //     raycastHit.transform.gameObject.SetActive(false);
                    // }
                }
            }
        }
    }
}
