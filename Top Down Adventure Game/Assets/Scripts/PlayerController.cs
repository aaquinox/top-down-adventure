using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //importing SceneManagement library

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;
    public bool hasKey = false;
    public GameObject key;

    public static PlayerController instance; //creating an object of the class to be findable 

    // Start is called before the first frame update
    void Start()
    {
        if(instance != null) //check if instance is in the scene 
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        GameObject.DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position; 
        if (Input.GetKey("w"))
        {
            //player moves up
            newPosition.y += speed;
        }

        if (Input.GetKey("s"))
        {
            //player moves down
            newPosition.y -= speed;
        }

        if (Input.GetKey("a"))
        {
            //player moves left
            newPosition.x -= speed;
        }

        if (Input.GetKey("d"))
        {
            //player moves right
            newPosition.x += speed;
        }

        transform.position = newPosition; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Door"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(1); //access SceneManager class for Loadscene function
        }

        if (collision.gameObject.tag.Equals("key1"))
        {
            Debug.Log("obtained key");
            //key.SetActive(false);  //key disappears

            hasKey1 = true;
        }

        if (collision.gameObject.tag.Equals("key2"))

        {
            Debug.Log("obtained key");
            //key.SetActive(false);  //key disappears

            hasKey2 = true;
        }


        if (collision.gameObject.tag.Equals("door2"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(0);
        }

        if (collision.gameObject.tag.Equals("end") && hasKey1 == true)
        {
            Debug.Log("hit");
            SceneManager.LoadScene(2);
        }


        if (collision.gameObject.tag.Equals("end") && hasKey2 == true)
        {
            Debug.Log("hit");
            SceneManager.LoadScene(3);
        }

    }

}
