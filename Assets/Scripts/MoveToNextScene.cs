using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveToNextScene : MonoBehaviour
{
    public Button button;
    public string newScene;


    private void Start()
    {
        button.onClick.AddListener(onButtonclick);
    }

    private void onButtonclick()
    {
        Debug.Log("Hello");
        SceneManager.LoadScene(newScene);
    }
}
