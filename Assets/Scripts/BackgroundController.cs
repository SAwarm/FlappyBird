using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.4f;
    MeshRenderer mr;
    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        mr.material.mainTextureOffset += Vector2.right * speed * Time.deltaTime;
    }
}
