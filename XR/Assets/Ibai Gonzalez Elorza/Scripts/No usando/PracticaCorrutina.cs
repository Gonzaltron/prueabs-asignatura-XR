using UnityEngine;
using System.Collections;

public class PracticaCorrutina : MonoBehaviour
{
    GameObject cube;
    Quaternion targetRotation1 = Quaternion.Euler(0f, 90f, 0f);
    Quaternion targetRotation2 = Quaternion.Euler(0f, 0f, 0f);
    Vector3 target1 = new Vector3(0f, 0f, 0f);
    Vector3 target2 = new Vector3(10f, 0f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            StartCoroutine(cubo1());
        }
    }

    IEnumerator cubo1()
    {
        cube.transform.position = Vector3.Lerp(cube.transform.position, target1, 1);
        yield return new WaitForSeconds(1f);
        StartCoroutine(rotar1());
    }

    IEnumerator rotar1()
    {
        cube.transform.rotation = Quaternion.Slerp(cube.transform.rotation, targetRotation1, 1);
        yield return new WaitForSeconds(1f);
        StartCoroutine(cubo2());
    }
    IEnumerator cubo2()
    {
        cube.transform.position = Vector3.Lerp(cube.transform.position, target2, 5);
        yield return new WaitForSeconds(1f);
        StartCoroutine(rotar2());
    }

    IEnumerator rotar2()
    {
        cube.transform.rotation = Quaternion.Slerp(cube.transform.rotation, targetRotation2, 1);
        yield return new WaitForSeconds(0.001f);
    }
}
