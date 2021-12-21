using UnityEngine;

public class DeliveryPointScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Pakage"))
        {
            Debug.Log("Delivery accepted");
            other.gameObject.GetComponent<PakageControl>().DeliveryPointReached();
            changeColorTo(Color.green);
        }
    }

    void changeColorTo(Color color)
    {
        this.GetComponent<Renderer>().material.color = Color.green;
    }
}