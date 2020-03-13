using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPressed : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;

    private void Start()
    {
        button1.onClick.AddListener(onButtonClick1);
        button2.onClick.AddListener(onButtonClick2);
        button3.onClick.AddListener(onButtonClick3);
    }

    private void onButtonClick1()
    {
        Debug.Log("Button1 Clicked.");
        loadAnyLevel(0);

    }

    private void onButtonClick2()
    {
        Debug.Log("Button2 Clicked.");
        loadAnyLevel(1);

    }

    private void onButtonClick3()
    {
        Debug.Log("Button3 Clicked.");
        loadAnyLevel(2);

    }

    public void loadAnyLevel(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

}
