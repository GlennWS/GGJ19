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

    void Start()
    {
        _playerBody = GetComponent<Rigidbody2D>();
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
        }

        if (Input.GetAxisRaw("Vertical") >= 0.5f || Input.GetAxisRaw("Vertical") <= -0.5f)
        {
            _playerBody.velocity = new Vector2(_playerBody.velocity.x, Input.GetAxisRaw("Vertical") * _speed);
            _playerMoving = true;
            _lastMove = new Vector2(0.0f, Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetAxisRaw("Horizontal") <= 0.5f && Input.GetAxisRaw("Horizontal") >= -0.5f)
        {
            _playerBody.velocity = new Vector2(0.0f, _playerBody.velocity.y);
        }

        if (Input.GetAxisRaw("Vertical") <= 0.5f && Input.GetAxisRaw("Vertical") >= -0.5f)
        {
            _playerBody.velocity = new Vector2(_playerBody.velocity.x, 0.0f);
        }
    }
}