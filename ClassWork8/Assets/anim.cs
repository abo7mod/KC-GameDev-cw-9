using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    SpriteRenderer Sprite;
    bool FaceRight = true;
    public GameObject Shot;
    GameObject ShotClone;
    public float speed;

    public AudioSource src;

    public Transform leftSpown;

    void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerFlip();
        Fire();
    }
    void PlayerFlip()
    {
        if (Input.GetKeyDown(KeyCode.D) && FaceRight == false)
        {
            Sprite.flipX = false;
            FaceRight = true;



        }
        else if (Input.GetKeyDown(KeyCode.A) && FaceRight == true)
        {
            Sprite.flipX = true;
            FaceRight = false;



        }


    }
    void Fire()
    {
        if (Input.GetMouseButtonDown(0) && FaceRight)
        {
            ShotClone = Instantiate(Shot, transform.position, transform.rotation);
            ShotClone.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
            Destroy(ShotClone, 1.5f);
        }
        else if (Input.GetMouseButtonDown(0) && !FaceRight)
        {
            ShotClone = Instantiate(Shot, leftSpown.position, leftSpown.rotation);
            ShotClone.GetComponent<Rigidbody2D>().velocity = transform.right * -speed;
            Destroy(ShotClone, 1.5f);
        }

        src.Play();
    }
}