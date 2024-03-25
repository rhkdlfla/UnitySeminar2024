using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float dashDistance;
        
        void Update()
        {
            Vector2 inputVector = Vector2.zero;

            if (Input.GetKey(KeyCode.W))
            {
                inputVector += Vector2.up;
            }
            if (Input.GetKey(KeyCode.A))
            {
                inputVector += Vector2.left;
            }
            if (Input.GetKey(KeyCode.S))
            {
                inputVector += Vector2.down;
            }
            if (Input.GetKey(KeyCode.D))
            {
                inputVector += Vector2.right;
            }
            
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                transform.Translate(inputVector.normalized * dashDistance);
            }
            
            transform.Translate(Time.deltaTime * speed * inputVector.normalized);
            
            Vector3 position = transform.position;
            position = Vector3.Max(position, new Vector3(-9, -5, 0));
            position = Vector3.Min(position, new Vector3(9, 5, 0));
            transform.position = position;
        }
    }
}

