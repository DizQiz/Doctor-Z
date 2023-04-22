using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TryAgain : MonoBehaviour
{
    public void TryAgainScene()
    {
        SceneManager.LoadScene("DoctorZ");
    }

    public void LoadMainMenuScene()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
