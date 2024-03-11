using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundAnimator : MonoBehaviour
{
    [SerializeField] private Transform image1;
    [SerializeField] private Transform image2;
    [SerializeField] private float scrollSpeed;
    void FixedUpdate()
    {
        
        image1.position -= Vector3.up * scrollSpeed;
        if (image1.position.y < -10)
        {
            image1.position += Vector3.up * 20;
        }
        image2.position -= Vector3.up * scrollSpeed;
        if (image2.position.y < -10)
        {
            image2.position += Vector3.up * 20;
        }
    }
}
