using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void nextscene()
    {
        SceneManager.LoadScene("level 1");

    }
    public void quýt()
    {
        Application.Quit();
    }
}
