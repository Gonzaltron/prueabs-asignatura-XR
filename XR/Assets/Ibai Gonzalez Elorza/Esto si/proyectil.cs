using UnityEngine;
using System.Collections;

public class proyectil : MonoBehaviour
{
    [SerializeField] float Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(bullet());
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * 10);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("cosa"))
        {
            Destroy(collision.gameObject);
        }
    }

    IEnumerator bullet()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
