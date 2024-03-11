using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float speed;
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
            
            transform.Translate(Time.deltaTime * speed * inputVector.normalized);
        }
    }
}

