using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallReset : MonoBehaviour
{
    Rigidbody2D rigitbody;

    // Start is called before the first frame update
    void Start()
    {
        rigitbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            SetBallPosition(Camera.main.ScreenToWorldPoint(Mouse.current.position.value));
        }
    }
    public void SetBallPosition(Vector2 pos)
    {
        rigitbody.transform.position = pos;
        rigitbody.velocity = Vector2.zero;
    }
}
