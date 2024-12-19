using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadFall : MonoBehaviour
{
    public FloatingText floatingText;
    void Update()
    {
        if (transform.position.y < -50.0f)
        {
            transform.position = new Vector3(28.5f, 0.207f, 8.5f);
            floatingText.incrementFallCounter();
        }
    }
}
