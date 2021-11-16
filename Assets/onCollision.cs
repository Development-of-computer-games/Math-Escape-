using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour
{
    private int ans = 10;
    private int count;
    [SerializeField] string tag;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && tag == "QuestionBlock" )
        {
            Debug.Log("Player touched the question block");
            gameObject.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.transform.GetChild(1).transform.GetComponent<SpriteRenderer>().enabled = true;
        }
       else if (other.tag == "Player" && tag == "Box")
        {
            Debug.Log("Player touched the box");
            count += 1;
            if (ans == count)
            {
                Debug.Log("CORRRRRECT");
                gameObject.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().enabled = true;
            }
        }
    }
}
