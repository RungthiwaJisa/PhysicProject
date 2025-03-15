using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float speed = 10f;
    private PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        var go = GameObject.Find("Player");

        playerController = go.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerController.isGameOver)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}
