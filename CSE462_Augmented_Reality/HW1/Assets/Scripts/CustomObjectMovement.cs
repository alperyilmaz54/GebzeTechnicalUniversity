using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomObjectMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    private bool moveUp = false;
    private bool moveDown = false;
    private bool moveLeft = false;
    private bool moveRight = false;

    void Update()
    {
        Vector3 position = Vector3.zero;

        if (moveLeft) { position -= transform.right; }
        if (moveRight) { position += transform.right; }
        if (moveUp) { position += transform.up; }
        if (moveDown) { position -= transform.up; }
            
        transform.Translate(position.normalized * Time.deltaTime * moveSpeed);
    }

    public void OnUpBtnDown() { moveUp = true; }
    public void OnUpBtnUp() { moveUp = false; }
    public void OnDownBtnDown() { moveDown = true; }
    public void OnDownBtnUp() { moveDown = false; }
    public void OnLeftBtnDown() { moveLeft = true; }
    public void OnLeftBtnUp() { moveLeft = false; }
    public void OnRightBtnDown() { moveRight = true; }
    public void OnRightBtnUp() { moveRight = false; }
}