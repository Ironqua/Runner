using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class playercontroller : MonoBehaviour
{
    public float speed;
    float touchXDelta = 0;
    float newX = 0;
    public float xspeed;
    public float xlimit;
   // public Text scoretext;
    //public float score;
    //public GameObject coin;
    void Start()
    {

    }


    void Update()
    {

        SwipeCheck();

    }

    private void SwipeCheck ()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            //Debug.Log(Input.GetTouch(0).deltaPosition.x/Screen.width);
            touchXDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;

        }
        else if (Input.GetMouseButton(0))
        {

            touchXDelta = Input.GetAxis("Mouse X");

        }
        else
        {
            touchXDelta= 0;
        }
            newX = transform.position.x + xspeed * touchXDelta * Time.deltaTime;
        
        newX = Mathf.Clamp(newX, -xlimit, xlimit);

        Vector3 newPos = new Vector3(newX, transform.position.y, transform.position.z + speed * Time.deltaTime);
        transform.position = newPos;
    }
    //private void OnTriggerEnter(Collider cls)
    //{
    //    if (cls.CompareTag("coin"))
    //    {

    //        score++;
    //        scoretext.text = score.ToString();
    //        Destroy(coin);

    //    }



    //}

}


