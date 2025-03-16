using UnityEngine;

public class Buff : MonoBehaviour
{
    int buff = 3;

    PlayerController playerCon;

    private void Awake()
    {
        var search = GameObject.Find("Player");

        playerCon = search.GetComponent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerCon.speed += buff;
            Destroy(this.gameObject);
        }
    }
}
