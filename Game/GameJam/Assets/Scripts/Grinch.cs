using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinch : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveForce = 5f;

    private SpriteRenderer sr;
    private float movementX;
    private float movementY;

    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveX();
        AnimateX();
        MoveY();
        AnimateY();

    }
    void MoveX()
    {
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
    }
    void MoveY()
    {
        movementY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(0f, movementY, 0f) * Time.deltaTime * moveForce;
    }
    void AnimateX()
    {
        if (movementX > 0)
        {
            anim.SetBool("walkLeft", false);
            anim.SetBool("walkRight", true);
            sr.flipX = true;
        }
        else if (movementX < 0)
        {
            anim.SetBool("walkLeft", true);
            anim.SetBool("walkRight", false);
            sr.flipX = false;
        }
        else
        {
            anim.SetBool("walkLeft", false);
            anim.SetBool("walkRight", false);

        }
    }
    void AnimateY()
    {
        if (movementY > 0)
        {
            anim.SetBool("walkDown", false);
            anim.SetBool("walkUp", true);

        }
        else if (movementY < 0)
        {
            anim.SetBool("walkDown", true);
            anim.SetBool("walkUp", false);
        }
        else
        {
            anim.SetBool("walkDown", false);
            anim.SetBool("walkUp", false);

        }
    }
}
