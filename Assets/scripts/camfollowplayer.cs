using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camfollowplayer : MonoBehaviour
{
    public Transform camTarget;
    public float sspeed = 10f;
    public Vector3 dist;
    public Transform looktarget;

    private void LateUpdate()
    {
        Vector3 dpos = camTarget.position + dist;
        Vector3 spos=Vector3.Lerp(transform.position,dpos,sspeed*Time.deltaTime);
        transform.position = spos;
        transform.LookAt(looktarget.position);


    }
}
