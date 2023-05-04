using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOpen : MonoBehaviour
{
    [SerializeField] DoorOpen DoorOpen;

    [SerializeField] bool isDoorOpenSwitch;
    [SerializeField] bool isDoorClosedSwitch;

    bool isPressingSwitch = false;
    



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isPressingSwitch = !isPressingSwitch;

            if(isDoorOpenSwitch && !DoorOpen.isDoorOpen)
            {
                DoorOpen.isDoorOpen = !DoorOpen.isDoorOpen;
            }
            else if(isDoorClosedSwitch && DoorOpen.isDoorOpen)
            {
                DoorOpen.isDoorOpen = !DoorOpen.isDoorOpen;

            }
        }
    }
}
