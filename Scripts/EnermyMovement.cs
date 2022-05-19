using UnityEngine;

public class EnermyMovement : MonoBehaviour
{
    public PlayerMovement player;
    public Transform EnermyTransform;
    Rigidbody EnermyRigid;
    Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        EnermyRigid = GetComponent<Rigidbody>();
        EnermyTransform = GetComponent<Transform>();
        originalPosition = EnermyTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        EnermyRigid.AddForce(new Vector3(
            player.transform.position.x - EnermyTransform.position.x,
            0,
            player.transform.position.z - EnermyTransform.position.z) * Time.deltaTime * 100);
    }

    public void reset()
    {
        Debug.Log("Reset");
        EnermyTransform.position = originalPosition;
        EnermyRigid.velocity = Vector3.zero;
    }
}
