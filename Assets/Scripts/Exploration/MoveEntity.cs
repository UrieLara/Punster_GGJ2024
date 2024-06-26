using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEntity : MonoBehaviour
{
    public float movementSpeed = 1f;
    public float rotationSpeed = 1f;

    protected void MoveTowards(Vector3 direction)
    {
        Quaternion towardsTargetRotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, towardsTargetRotation, rotationSpeed);
        transform.position += direction.normalized * movementSpeed * Time.deltaTime;
    }
}
