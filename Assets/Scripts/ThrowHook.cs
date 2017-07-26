using UnityEngine;
using System.Collections;

public class ThrowHook : MonoBehaviour
{
    public GameObject hook;
    GameObject curHook;
    public bool ropeActive;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ropeActive == false)
            {
                Vector2 destiny = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                curHook = (GameObject)Instantiate(hook, transform.position, Quaternion.identity);
                curHook.GetComponent<RopeScript>().destiny = destiny;
                ropeActive = true;
            }
            else
            {
                ropeActive = false;
                Destroy(curHook);
            }
        }
    }
}