using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float _speed = 3.0f;

    private Rigidbody2D _playerBody;
    private bool _playerMoving;
    private Vector2 _lastMove;
    public GameObject UI;
    Animator anim;

    void Start()
    {
        _playerBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "Transition")
        {
            SceneManager.LoadScene("Town");
        }
    }

    void Update()
    {
        _playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") >= 0.5f || Input.GetAxisRaw("Horizontal") <= -0.5f)
        {
            _playerBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _speed, _playerBody.velocity.y);
            _playerMoving = true;
            _lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0.0f);
            anim.SetFloat("horizontalSpeed", 1.0f);
            anim.SetBool("facingVert", false);
        }

        if (Input.GetAxisRaw("Vertical") >= 0.5f || Input.GetAxisRaw("Vertical") <= -0.5f)
        {
            _playerBody.velocity = new Vector2(_playerBody.velocity.x, Input.GetAxisRaw("Vertical") * _speed);
            _playerMoving = true;
            _lastMove = new Vector2(0.0f, Input.GetAxisRaw("Vertical"));
            anim.SetFloat("verticalSpeed", 1.0f);
            anim.SetBool("facingVert", true);
        }

        if (Input.GetAxisRaw("Horizontal") <= 0.5f && Input.GetAxisRaw("Horizontal") >= -0.5f)
        {
            _playerBody.velocity = new Vector2(0.0f, _playerBody.velocity.y);
            anim.SetFloat("horizontalSpeed", -1.0f);
            anim.SetBool("facingVert", false);
        }

        if (Input.GetAxisRaw("Vertical") <= 0.5f && Input.GetAxisRaw("Vertical") >= -0.5f)
        {
            _playerBody.velocity = new Vector2(_playerBody.velocity.x, 0.0f);
            anim.SetFloat("verticalSpeed", -1.0f);
            anim.SetBool("facingVert", true);
        }

        if (Input.GetKeyDown(KeyCode.I) && UI.activeSelf == false)
        {
            UI.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I) && UI.activeSelf == true)
        {
            UI.SetActive(false);
        }

        anim.SetFloat("horizontalSpeed", _playerBody.velocity.x);
        anim.SetFloat("verticalSpeed", _playerBody.velocity.y);
        anim.SetBool("facingVert", Mathf.Abs(_playerBody.velocity.x) < Mathf.Abs(_playerBody.velocity.y));
    }
}