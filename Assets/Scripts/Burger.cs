using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burger : MonoBehaviour
{
    public int shrinkSpeed;
    public Vector3 rotationSpeed;
    public GameObject burger;
    public AudioSource Click;

    private void OnMouseDown()
    {
        Instantiate(burger);
        GameManager.clicks++;
        transform.localScale = Vector3.one * 2f;

        Click.Play();

        Invoke("delete", 3f);
    }
    private void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);

        if (transform.localScale.x > 1.6f)
        {
            transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
        }
    }
}
