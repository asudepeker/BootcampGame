using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform ornek;

    private void LateUpdate()
    {
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);
    }

}
