using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public void playGame()
    {
        audioSource.Play();
        StartCoroutine(LoadGameAfterSound(audioSource.clip.length));
    }
    public void back2_mm()
    {
        audioSource.Play();
        StartCoroutine(LoadMMAfterSound(audioSource.clip.length));
    }

    // for fuckin' sound to work 
    IEnumerator LoadGameAfterSound(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator LoadMMAfterSound(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
