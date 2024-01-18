using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*    public ControlType controlType;
        public Joystick joystick;
        public static float speed;
        public float SpeedReal = 6f;

        public GameObject joystickSee;

        public enum ControlType {PC, Android};

        private Rigidbody2D rb;
        private Vector2 moveVelocity;
        private Vector2 moveInput;



        void Start()
        {
            speed = SpeedReal;
            rb = GetComponent<Rigidbody2D>();
        }


        public void Update()
        {
            if (controlType == ControlType.PC)
            {
                joystickSee.SetActive(true);
                *//*moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));*//*
                moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
            }
            else if (controlType == ControlType.Android)
            {
                joystickSee.SetActive(true);
                moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
            }

            moveVelocity = moveInput.normalized * speed;
        }

        void FixedUpdate()
        {
            rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
        }
    */


    public ControlType controlType;
    public Joystick joystick;
    public static float speed;
    public float SpeedReal = 6f;

    public GameObject joystickSee;

    public enum ControlType { PC, Android };

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    private Vector2 moveInput;



    void Start()
    {
        speed = SpeedReal;
        rb = GetComponent<Rigidbody2D>();
    }


    public void Update()
    {
        if (controlType == ControlType.PC)
        {
            joystickSee.SetActive(true);
            moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) + new Vector2(joystick.Horizontal, joystick.Vertical);
        }
        else if (controlType == ControlType.Android)
        {
            joystickSee.SetActive(true);
            moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        }

        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

}
