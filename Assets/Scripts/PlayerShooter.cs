
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private SimplePool bulletPool;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float fireCooldown = 0.2f;

    private float nextFireTime;

    public void OnFire(InputValue value)
    {
        if (!value.isPressed)
            return;

        if (Time.timeScale == 0f)
            return;

        if (GameManager.Instance.IsGameOver)
            return;

        if (Time.time < nextFireTime)
            return;

        nextFireTime = Time.time + fireCooldown;

        GameObject bullet =
            bulletPool.GetFromPool(firePoint.position);

        if (bullet != null)
        {
            bullet.GetComponent<Bullet>().Fire();
        }
    }
}
