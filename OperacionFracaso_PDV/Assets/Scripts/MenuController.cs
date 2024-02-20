using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [Header("VolumenSettings")]
    [SerializeField] private Text volumenTextValor = null;
    [SerializeField] private Slider volumenSlider = null;

    [SerializeField] private GameObject confirmationPrompt = null;

    [Header("Levels To Load")]
    public string _newLevel;
    private string toLoadLevel;
    [SerializeField] private GameObject noSavedGameDialog = null;
    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(_newLevel);
    }
    public void loadGameDialogYes()
    {
        if (PlayerPrefs.HasKey("SavedLevel"))
        {
            toLoadLevel = PlayerPrefs.GetString("SavedLevel");
            SceneManager.LoadScene(toLoadLevel);
        }
        else
        {
            noSavedGameDialog.SetActive(true);
        }
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void SetVolumen(float volumen)
    {
        AudioListener.volume = volumen;
        volumenTextValor.text = volumen.ToString("0.0");
    }

    public void VolumenAplicar()
    {
        PlayerPrefs.SetFloat("masterVolumen", AudioListener.volume);
        StartCoroutine(CajaConfirmacion());
    }

    public IEnumerator CajaConfirmacion()
    {
        confirmationPrompt.SetActive(true);
        yield return new WaitForSeconds(2);
        confirmationPrompt.SetActive(false);
    }
}
