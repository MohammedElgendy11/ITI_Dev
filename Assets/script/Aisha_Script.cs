using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aisha_Script : MonoBehaviour
{
    public GameObject[] food;
    public Text price;
    float speed = 40.0f;
    public GameObject FrenchFries;

    private void Start()
    {
        openChicken();
        openBurger();
        openFrenchFries();
        openpizza();
        openjapaese();
        Debug.log("Gendy");
    }

    public void openChicken()

    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].gameObject.SetActive(false);
        }
        food[0].gameObject.SetActive(true);
        price.text = "price:50$";
    }

    public void openFrenchFries()

    {
        for (int i = 0; i < food.Length; i++)
        {
            food[i].gameObject.SetActive(false);
        }
        food[1].gameObject.SetActive(true);
        price.text = "price:25$";
    }

        public void openpizza()

        {
            for (int i = 0; i < food.Length; i++)
            {
                food[i].gameObject.SetActive(false);
            }
            food[2].gameObject.SetActive(true);
            price.text = "price:45$";
        }
        public void openBurger()

        {
            for (int i = 0; i < food.Length; i++)
            {
                food[i].gameObject.SetActive(false);
            }
            food[3].gameObject.SetActive(true);
            price.text = "price:40$";
        }
        public void openjapaese()

        {
            for (int i = 0; i < food.Length; i++)
            {
                food[i].gameObject.SetActive(false);
            }
            food[4].gameObject.SetActive(true);
            price.text = "price:60$";
        }
    
    // Update is called once per frame
    void Update()
    {
        FrenchFries.transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
