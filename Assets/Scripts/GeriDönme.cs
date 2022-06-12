using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeriDönme : MonoBehaviour
{
    public void anaSahne()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void secimSahnesi()
    {
        SceneManager.LoadScene("secim");
    }
    public void hafızaOyunuSahnesi()
    {
        SceneManager.LoadScene("hafızaOyunu");
    }
    public void renkOyunuSahnesi()
    {
        SceneManager.LoadScene("renkOyunu");
    }
    public void quitButton()
    {
        Application.Quit();
    }

}
