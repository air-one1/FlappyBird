using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float max = 1;
    private float t = 0;
    public float height;
    public GameObject Tuyau;

    // Start is called before the first frame update
    void Start()   {

        GameObject newTuyau = Instantiate(Tuyau);
        newTuyau.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

    }

    // Update is called once per frame
    void Update() {
        if(t > max)
        {
            GameObject newTuyau = Instantiate(Tuyau);
            newTuyau.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newTuyau, 10);
            t = 0;
        }
        t += Time.deltaTime;
    }
}
