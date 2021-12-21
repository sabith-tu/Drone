using UnityEngine;

public class PakageControl : MonoBehaviour
{
    bool folowDrone = false;
    private void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Drone"))
            {
                DronePickup();
            }
    }

   void DronePickup()
   {
       folowDrone = true;
        this.GetComponent<DronControl>().enabled = true;
   }

    public void DeliveryPointReached(){
        folowDrone = false;
        this.GetComponent<DronControl>().enabled = false;
    }
}