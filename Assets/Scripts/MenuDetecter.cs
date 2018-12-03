using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDetecter : MonoBehaviour {
    private bool walking = false;
    public GameObject Dummy;
    private bool showMenu;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {

        if (walking) {
            transform.position = transform.position + Camera.main.transform.forward * 4f * Time.deltaTime;
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name.Contains("MenuArea"))
            {
               Instantiate(Dummy, hit.point , Quaternion.identity);
            }
            else
            {
                walking = false;
            }
        }
    }   
}
