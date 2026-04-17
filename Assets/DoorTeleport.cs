using UnityEngine;
public class DoorTeleport : MonoBehaviour
{
    public Transform teleportTarget;
    private float cooldown = 3f;
    private static float lastTeleportTime = -10f;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Time.time - lastTeleportTime < cooldown) return;
            lastTeleportTime = Time.time;

            CharacterController cc = other.GetComponent<CharacterController>();
            cc.enabled = false;
            other.transform.position = teleportTarget.position;
            cc.enabled = true;
        }
    }
}