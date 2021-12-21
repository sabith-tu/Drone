using UnityEngine;

public class RotateTheDronesBlade : MonoBehaviour
{
    [Range(10,100)] public int RotatorSpeed;
    public GameObject[] blades = new GameObject[4];
    private void FixedUpdate() {
        foreach (GameObject blade in blades)
        {
            blade.transform.Rotate(new Vector3(0f,RotatorSpeed,0f));
        }
    }
}