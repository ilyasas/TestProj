using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveModule : BaseMoveModule
{
    private Rigidbody rig;
    public float speed;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }
    public override void Move(Vector2 dir)
    {
        rig.AddForce((dir.y * transform.forward + dir.x * transform.right).normalized * speed * rig.mass);
    }
}
