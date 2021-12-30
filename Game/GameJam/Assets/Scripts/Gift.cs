using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
    // Start is called before the first frame update
    private bool pickedUp;
    private GameManager game;
    void Start()
    {
        pickedUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && pickedUp == false)
        {
            pickedUp = true;
            GameObject.Find("GameManager").GetComponent<GameManager>().presentsStolen += 1;
        }
    }
}
