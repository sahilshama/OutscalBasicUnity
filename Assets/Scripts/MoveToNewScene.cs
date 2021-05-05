using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveToNewScene : MonoBehaviour
{
    public Button button;
    public string scene1;


    private void Start()
    {
        button.onClick.AddListener(onButtonclick);
    }

    private void onButtonclick()
    {

        SceneManager.LoadScene(scene1);
    }
}
