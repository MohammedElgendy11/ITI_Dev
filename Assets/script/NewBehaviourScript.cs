using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public GameObject[] food;
    public Text price;
    float speed = 40.0f;
    public GameObject FrenchFries;

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



        void Update()
        {
            FrenchFries.transform.Rotate(Vector3.down * speed * Time.deltaTime);

        }

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
}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class NewBehaviourScript : MonoBehaviour
//{
//    public GameObject model;

//    float speed = 50;
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//          model.transform.Rotate(Vector3.up * speed * Time.deltaTime);

//    }
//}
