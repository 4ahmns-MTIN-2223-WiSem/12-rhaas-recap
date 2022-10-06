using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonChangeRed : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;
    public Image Image1;
    public Image Image2;
    public Image Image3;
    public Color32 Colors1;
    public Color32 Colors2;
    public Color32 Colors3;

    private void Start()
    {
        Image1.color = Color.red;
        Image2.color = Color.blue;
        Image3.color = Color.green;
    }

    public void Changebutton1()
    {
        Image1.color = Colors1;
        Colors1 = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
    }

    public void Changebutton2()
    {
        Image2.color = Colors2;
        Colors2 = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
    }

    public void Changebutton3()
    {
        Image3.color = Colors3;
        Colors3 = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F));
    }

    public void SwitchScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

