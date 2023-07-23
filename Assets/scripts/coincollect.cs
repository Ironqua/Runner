using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class coincollect : MonoBehaviour

{
    public playercontroller playercontroller;

    public int score=0  ;
    public TextMeshProUGUI cointext;
    public Animator playeranim;
    public GameObject Player;
    public GameObject endpanel;
    private void Start()
    {
       playeranim=Player.GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider cls)
    {
        if (cls.CompareTag("coin"))
        {
            addcoin();
         Destroy(cls.gameObject);

        }
        else if (cls.CompareTag("end"))
        {
            //Debug.Log("bitti");
            playercontroller.speed = 0;
            transform.Rotate(transform.rotation.x,180,transform.rotation.z,Space.Self);
            endpanel.SetActive(true); 
            

            if(score >= 15)
            {
                //Debug.Log("win");
                playeranim.SetBool("win",true);

            }
            else
            {
                //Debug.Log("loose");
                playeranim.SetBool("lose", true);
            }
        }


    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void digersahne()
    {
        SceneManager.LoadScene("OYUN");

    }
    public void cýkýs()
    {
        Application.Quit();
    }


    private void OnCollisionEnter(Collision cls)
    {
        if(cls.gameObject.CompareTag("Wall"))
        {
            Debug.Log("touched");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
    public void addcoin()
    {
        score++;
        cointext.text="Score:"+score.ToString();
    }
}
