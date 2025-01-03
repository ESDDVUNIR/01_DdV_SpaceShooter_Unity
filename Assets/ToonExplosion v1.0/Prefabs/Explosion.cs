using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyThisObject());
    }

    IEnumerator DestroyThisObject()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
