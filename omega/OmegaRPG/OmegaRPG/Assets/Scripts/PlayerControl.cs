using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CharacterController Player;
    public float Speed = 10.0f;
    public float Turn = 200.0f;
    private Vector3 MoveVector = Vector3.zero;
    private Vector3 TurnVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveVector.x = Input.GetAxis("Horizontal");
        MoveVector.z = Input.GetAxis("Vertical");
        TurnVector.y = Input.GetAxis("Mouse X");

        MoveVector = transform.TransformDirection(MoveVector);

        Player.Move(MoveVector * Time.deltaTime * Speed);
        transform.Rotate(TurnVector * Time.deltaTime * Turn);


    }
}
