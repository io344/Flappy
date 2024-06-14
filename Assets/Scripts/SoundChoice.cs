using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundChoice : MonoBehaviour
{
    bool isPressedOn = false;

    string togglekey = "isToggled";

    public Button yourButton;
    public Sprite newSprite;
    private Sprite originalSprite;
    void Start()
    {
        originalSprite = yourButton.GetComponent<Image>().sprite;
        LoadState(); 
        UpdateButtonSprite(); // Para may kwenta si LoadState
    }
    public void isPressed()
    {
        isPressedOn = !isPressedOn;
        UpdateButtonSprite();
        SaveState();
    }
    private void SaveState()
    {
        PlayerPrefs.SetInt(togglekey, isPressedOn ? 1 : 0);
        PlayerPrefs.Save();
    }

    private void LoadState()
    {
        isPressedOn = PlayerPrefs.GetInt(togglekey, 0) == 1;
    }

    void MuteAllSound()
    {
        AudioListener.volume = 0;
    }

    void UnMuteAllSound()
    {
        AudioListener.volume = 1;
    }

    void ChangeSprite()
    {
        Image buttonImage = yourButton.GetComponent<Image>();
        buttonImage.sprite = newSprite;
    }

    void OriginalSprite()
    {
        Image buttonImage = yourButton.GetComponent<Image>();
        buttonImage.sprite = originalSprite;
    }

    void UpdateButtonSprite()
    {
        if (isPressedOn)
        {
            ChangeSprite();
            MuteAllSound();
        }
        else
        {
            OriginalSprite();
            UnMuteAllSound();
        }
    }

}
