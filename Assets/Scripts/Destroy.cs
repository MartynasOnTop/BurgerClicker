using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void delete()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        Invoke("delete", 3f);
    }
}
