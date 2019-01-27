using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonToHub : MonoBehaviour
{
    public Button transition;

    void Start()
    {
        transition.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Scene sceneToLoad = SceneManager.GetSceneByName("Hub");
        SceneManager.LoadScene("Hub");
    }
}
