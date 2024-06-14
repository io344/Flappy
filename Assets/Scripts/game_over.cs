using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class game_over : MonoBehaviour
{
    public AudioSource audioSource;
    public void onRestartButtonClick()
    {
        audioSource.Play();
        StartCoroutine(RestartDelay(audioSource.clip.length));
    }

    public void backToMM()
    {
        audioSource.Play();
        StartCoroutine(back2MMSound(audioSource.clip.length));
    }

    IEnumerator RestartDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator back2MMSound(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
