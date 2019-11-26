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
                    StartCoroutine("validadIgualdad",banana);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBanana2"))
                {
                    banana2.SetActive(true);
                    StartCoroutine("validadIgualdad",banana2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBread"))
                {
                    bread.SetActive(true);
                    StartCoroutine("validadIgualdad",bread);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBread2"))
                {
                    bread2.SetActive(true);
                    StartCoroutine("validadIgualdad",bread2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboCheese"))
                {
                    cheese.SetActive(true);
                    StartCoroutine("validadIgualdad",cheese);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboCheese2"))
                {
                    cheese2.SetActive(true);
                    StartCoroutine("validadIgualdad",cheese2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboChicken"))
                {
                    chicken.SetActive(true);
                    StartCoroutine("validadIgualdad",chicken);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboChicken2"))
                {
                    chicken2.SetActive(true);
                    StartCoroutine("validadIgualdad",chicken2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboIceCream"))
                {
                    ice_cream.SetActive(true);
                    StartCoroutine("validadIgualdad",ice_cream);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboIceCream2"))
                {
                    ice_cream2.SetActive(true);
                    StartCoroutine("validadIgualdad",ice_cream2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBurger"))
                {
                    burguer.SetActive(true);
                    StartCoroutine("validadIgualdad",burguer);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboBurger2"))
                {
                    burguer2.SetActive(true);
                    StartCoroutine("validadIgualdad",burguer2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboMeat"))
                {
                    meat.SetActive(true);
                    StartCoroutine("validadIgualdad",meat);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboMeat2"))
                {
                    meat2.SetActive(true);
                    StartCoroutine("validadIgualdad",meat2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboOnion"))
                {
                    onion.SetActive(true);
                    StartCoroutine("validadIgualdad",onion);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboOnion2"))
                {
                    onion2.SetActive(true);
                    StartCoroutine("validadIgualdad",onion2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboPizza"))
                {
                    pizza.SetActive(true);
                    StartCoroutine("validadIgualdad",pizza);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboPizza2"))
                {
                    pizza2.SetActive(true);
                    StartCoroutine("validadIgualdad",pizza2);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboWine"))
                {
                    wine.SetActive(true);
                    StartCoroutine("validadIgualdad",wine);
                }
                if (raycastHit.transform.gameObject.CompareTag("CuboWine2"))
                {
                    wine2.SetActive(true);
                    StartCoroutine("validadIgualdad",wine2);
                }
            }
        }
    }

    private IEnumerator validadIgualdad(GameObject objeto){
     if((objeto.name == "Banana" && banana2.activeSelf) || objeto.name == "Banana2" && banana.activeSelf){
              yield return new WaitForSeconds(4.0f);
        banana.SetActive(false);
        banana2.SetActive(false);
        GameObject.Find("CuboBanana").transform.gameObject.SetActive(false);
        GameObject.Find("CuboBanana2").transform.gameObject.SetActive(false);
       } 
       if((objeto.name == "Bread" && bread2.activeSelf) || objeto.name == "Bread2" && bread.activeSelf){
                yield return new WaitForSeconds(4.0f);
        bread.SetActive(false);
        bread2.SetActive(false);
        GameObject.Find("CuboBread").transform.gameObject.SetActive(false);
        GameObject.Find("CuboBread2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "Cheese" && cheese2.activeSelf) || objeto.name == "Cheese2" && cheese.activeSelf){
                yield return new WaitForSeconds(4.0f);
        cheese.SetActive(false);
        cheese2.SetActive(false);
        GameObject.Find("CuboCheese").transform.gameObject.SetActive(false);
        GameObject.Find("CuboCheese2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "Onion" && onion2.activeSelf) || objeto.name == "Onion2" && onion.activeSelf){
                yield return new WaitForSeconds(4.0f);
        onion.SetActive(false);
        onion2.SetActive(false);
        GameObject.Find("CuboOnion").transform.gameObject.SetActive(false);
        GameObject.Find("CuboOnion2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "Meat" && meat2.activeSelf) || objeto.name == "Meat2" && meat.activeSelf){
                yield return new WaitForSeconds(4.0f);
        meat.SetActive(false);
        meat2.SetActive(false);
        GameObject.Find("CuboMeat").transform.gameObject.SetActive(false);
        GameObject.Find("CuboMeat2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "Wine" && wine2.activeSelf) || objeto.name == "Wine2" && wine.activeSelf){
                yield return new WaitForSeconds(4.0f);
        wine.SetActive(false);
        wine2.SetActive(false);
        GameObject.Find("CuboWine").transform.gameObject.SetActive(false);
        GameObject.Find("CuboWine2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "Pizza" && pizza2.activeSelf) || objeto.name == "Pizza2" && pizza.activeSelf){
                yield return new WaitForSeconds(4.0f);
        pizza.SetActive(false);
        pizza2.SetActive(false);
        GameObject.Find("CuboPizza").transform.gameObject.SetActive(false);
        GameObject.Find("CuboPizza2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "Burger" && burguer2.activeSelf) || objeto.name == "Burger2" && burguer.activeSelf){
             yield return new WaitForSeconds(4.0f);
        burguer.SetActive(false);
        burguer2.SetActive(false);
        GameObject.Find("CuboBurger").transform.gameObject.SetActive(false);
        GameObject.Find("CuboBurger2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "Chicken" && chicken2.activeSelf) || objeto.name == "Chicken2" && chicken.activeSelf){
             yield return new WaitForSeconds(4.0f);
        chicken.SetActive(false);
        chicken2.SetActive(false);
        GameObject.Find("CuboChicken").transform.gameObject.SetActive(false);
        GameObject.Find("CuboChicken2").transform.gameObject.SetActive(false);
       }
       if((objeto.name == "IceCream" && ice_cream2.activeSelf) || objeto.name == "IceCream2" && ice_cream.activeSelf){
             yield return new WaitForSeconds(4.0f);
        ice_cream.SetActive(false);
        ice_cream2.SetActive(false);
        GameObject.Find("CuboIceCream").transform.gameObject.SetActive(false);
        GameObject.Find("CuboIceCream2").transform.gameObject.SetActive(false);
       }
    }
}
