using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform drone;
    Vector3 ofset;
    [Range(0,10)] public float distance;
    [Range(0,10)] public float hight;
    [Range(0,30)] public float Rotation;

    private void LateUpdate() {
        ofset = new Vector3(0f,hight,-distance);
        this.transform.position = drone.position + ofset;
        this.transform.rotation = Quaternion.Euler(Rotation , 0f ,0f);
    }
}