using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenuController : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 1f);
    }

    public void OnVolumeSliderValueChanged()
    {
        float volumeValue = volumeSlider.value;
        AudioListener.volume = volumeValue;
        PlayerPrefs.SetFloat("Volume", volumeValue);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
