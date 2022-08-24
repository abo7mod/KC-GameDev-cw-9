using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class MainMenu : MonoBehaviour
{
   // [Header("Volume")]
  //  public TextMeshPro volumeTextValue;
    //[SerializeField] private Slider volumeSlid = null;

    //[SerializeField] private GameObject comfirmationPrompt = null;


   // public AudioMixer audioMixer;
 


    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {

        Debug.Log("QUIT!");
        Application.Quit();
    }
   // public void setVolume(float volume)
    //{
        //audioMixer.SetFloat("Volume", volume);
        //AudioListener.volume = volume;
        //volumeTextValue.text = volume.ToString("Volume");
        
        
        
   // }
   // public void VolumeApply()
    //{
        //PlayerPrefs.SetFloat("Volume", AudioListener.volume);
      //  StartCoroutine(ConfirmationBox());
    //}
    //public IEnumerator ConfirmationBox()
   // {
        //comfirmationPrompt.SetActive(true);
        //yield return new WaitForSeconds(2);
        //comfirmationPrompt.SetActive(false);


   // }



}
