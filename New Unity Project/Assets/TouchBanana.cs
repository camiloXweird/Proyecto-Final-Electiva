using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchBanana : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject banana;
    void Start()
    {
        banana = GameObject.Find("Banana");
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
                    Debug.Log("Hola");
                    banana.SetActive(true);
                }
            }
        }
    }
}
