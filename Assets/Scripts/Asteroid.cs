
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] private float speed = 2.5f;
    [SerializeField] private float bottomLimit = -4.5f;

    private void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

        if (transform.position.y < bottomLimit)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.TakeDamage(1);
            gameObject.SetActive(false);
        }
    }
}
