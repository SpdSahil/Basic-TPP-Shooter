using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitCube : MonoBehaviour
{
    [SerializeField] private float seconds = 0.2f;

    private Renderer render;

    private void Awake()
    {
        render = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            render.material.color = Color.green;
            StartCoroutine(RevertColor());
        }
    }

    IEnumerator RevertColor()
    {
        yield return new WaitForSeconds(seconds);
        render.material.color = Color.red;
    }
}
