using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public AudioSource audioSource;
    public void onRestartButtonClick()
    {
        audioSource.Play();
        StartCoroutine(RestartDelay(audioSource.clip.length));
    }

    IEnumerator RestartDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
