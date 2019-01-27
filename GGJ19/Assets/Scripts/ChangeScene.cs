using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public GameObject player;
    public GameObject inv;
    public Camera mainCam;
    public Canvas canv;
    public Canvas UI;
    public Image cooldown;
    public Canvas help;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Player")
        {
            DontDestroyOnLoad(player);
            DontDestroyOnLoad(mainCam);
            DontDestroyOnLoad(canv);
            DontDestroyOnLoad(inv);
            DontDestroyOnLoad(UI);
            DontDestroyOnLoad(cooldown);
            DontDestroyOnLoad(help);
            Scene sceneToLoad = SceneManager.GetSceneByName("Town");
            SceneManager.LoadScene("Town");
            player.transform.position = new Vector2(7.18f, -3.55f);
        }
    }
}
