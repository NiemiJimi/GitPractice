using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float jumpForce = 5f;
    void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null) return;

        Vector3 move = Vector3.zero;
        if (keyboard.wKey.isPressed) move.z += 1;
        if (keyboard.sKey.isPressed) move.z -= 1;
        if (keyboard.aKey.isPressed) move.x -= 1;
        if (keyboard.dKey.isPressed) move.x += 1;

        transform.position += move.normalized * speed * Time.deltaTime;
    
}
}
