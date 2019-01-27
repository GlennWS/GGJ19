using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class ChangeScene : MonoBehaviour
{
    public GameObject player;
    public GameObject inv;
    public Camera mainCam;
    public Canvas canv;
    public Canvas UI;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            DontDestroyOnLoad(player);
            DontDestroyOnLoad(mainCam);
            DontDestroyOnLoad(canv);
            DontDestroyOnLoad(inv);
            DontDestroyOnLoad(UI);
            Scene sceneToLoad = SceneManager.GetSceneByName("Town");
            SceneManager.LoadScene("Town");
            player.transform.position = new Vector2(7.18f, -3.55f);
        }
    }
}
