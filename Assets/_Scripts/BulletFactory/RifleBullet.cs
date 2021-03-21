using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleBullet : Bullet
{

    public RifleBullet()
    {
        this.speed = 23;
        this.lifetime = 3;
    }

    public override void ShootBulletFromSpawnPoint(GameObject bullet, Transform bulletSpawn, Transform playerTransform)
    {
        bullet.transform.position = bulletSpawn.position;

        Vector3 rotation = bullet.transform.rotation.eulerAngles;

        //add angle to 270 for rifle bullet rotation
        bullet.transform.rotation = Quaternion.Euler(rotation.x, playerTransform.eulerAngles.y + 270, rotation.z);

        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * this.speed, ForceMode.Impulse);

    }
}