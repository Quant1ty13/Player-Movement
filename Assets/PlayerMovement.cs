using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;

    public PlayerInputs playerInputs;

    private Vector2 movement;

    private void Awake()
    {
        playerInputs = new PlayerInputs();
    }

    private void OnEnable()
    {
        playerInputs.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }
    private void Update()
    {

        /*float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(x, 0, z);

        transform.Translate(move * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("POGI");
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("SIGE NA");
        }*/

        movement = playerInputs.Action.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(movement.x, 0, movement.y) * Time.deltaTime * speed);
    }
}
