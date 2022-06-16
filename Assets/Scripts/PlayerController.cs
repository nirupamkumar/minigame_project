using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;

    [SerializeField] 
    [Range(20f, 40f)] 
    private float moveSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * xMove + transform.forward * zMove;

        controller.Move(movement * moveSpeed * Time.deltaTime);
    }
}
