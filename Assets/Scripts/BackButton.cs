using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public Button Back1;

    public string scene;

    private void Start()
    {
        Back1.onClick.AddListener(onBackClick);
    }

    private void onBackClick()
    {
        SceneManager.LoadScene("scene");
    }
}
