using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2PlayerMultiShoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private bool _canShoot = true;

    private const float Timer = 2f;
    private float _currentTime = 2f;
    private int _bulletCount = 0;
    private void Update()
    {
        TimerMethod();
        Shoot();
    }

    private void TimerMethod()
    {
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;

            if (_currentTime < 0)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1) && _canShoot)
        {
            GameObject bullet = Instantiate(prefab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _bulletCount++;

            if (_bulletCount > 10)
            {
                _canShoot = false;
            }
        }
    }
}
