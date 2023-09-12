using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneController : MonoBehaviour
{
    [SerializeField] private float speed;

    private FixedJoystick fixedJoystick;
    private Rigidbody rigidbody;

    void Start()
    {
        
    }

    void Update()
    {
        float x = fixedJoystick.Horizontal;
        float y = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(x, 0, y);
        rigidbody.velocity = movement * speed;

        if(x!=0 && y!=0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }

    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }
}
