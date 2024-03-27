using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletTime;
    [SerializeField] private float fireRate;
    
    private bool _onFire;
    private float fireTimer;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _onFire = true;
            fireTimer = 0;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            _onFire = false;
        }

        if (_onFire)
        {
            fireTimer -= Time.deltaTime;
        
            if (fireTimer <= 0) {
                var bullet1 = Instantiate(bulletPrefab);
                var bullet2 = Instantiate(bulletPrefab);
                bullet1.transform.position = transform.position - new Vector3(-1, 0, 0);
                bullet2.transform.position = transform.position - new Vector3(+1, 0, 0);
                bullet1.GetComponent<Bullet>().SetBullet(bulletSpeed, bulletTime);
                bullet2.GetComponent<Bullet>().SetBullet(bulletSpeed, bulletTime);
                fireTimer = fireRate;
            }
        }
    }
}
