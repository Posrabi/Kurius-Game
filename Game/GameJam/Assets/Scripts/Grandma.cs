using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grandma : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveForce;
    private Animator anim;
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        StartCoroutine(Walk(25, 25));

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Walk(float timeX, float timeY)
    {
        while (true)
        {
            float limitX = timeX * 60;
            float countX = 0;
            anim.SetBool("down", false);
            anim.SetBool("right", true);
            while (countX < limitX)
            {
                transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime * moveForce;
                countX += 1;
                yield return new WaitForEndOfFrame();
            }
            float limitY = timeY * 60;
            float countY = 0;
            anim.SetBool("right", false);
            anim.SetBool("up", true);
            while (countY < limitY)
            {
                transform.position += new Vector3(0f, 1f, 0f) * Time.deltaTime * moveForce;
                countY += 1;
                yield return new WaitForEndOfFrame();
            }
            countX = 0;
            anim.SetBool("up", false);
            anim.SetBool("left", true);
            while (countX < limitX)
            {
                transform.position += new Vector3(-1f, 0f, 0f) * Time.deltaTime * moveForce;
                countX += 1;
                yield return new WaitForEndOfFrame();
            }
            countY = 0;
            anim.SetBool("left", false);
            anim.SetBool("down", true);
            while (countY < limitY)
            {
                transform.position += new Vector3(0f, -1f, 0f) * Time.deltaTime * moveForce;
                countY += 1;
                yield return new WaitForEndOfFrame();
            }
        }


    }

}
