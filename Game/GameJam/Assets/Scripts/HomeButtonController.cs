using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeButtonController : MonoBehaviour
{
    public void ReturnHome()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
