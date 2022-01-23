using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeInstanceController : MonoBehaviour
{
    [SerializeField]

    Transform pipe;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("PipeInstantiate", 0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PipeInstantiate()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-3, 3), 0), Quaternion.identity);
    }
}
