using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void onRestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
