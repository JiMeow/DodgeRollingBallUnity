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
        Vector3 direction = player.transform.position - EnermyTransform.position;
        if (EnermyRigid.velocity.magnitude > 15)
        {
            EnermyRigid.velocity = direction.normalized * 15;
            EnermyRigid.velocity = new Vector3(EnermyRigid.velocity.x, 0, EnermyRigid.velocity.z);
        }
        direction.y = 0;
        EnermyRigid.AddForce(direction * Time.deltaTime * 100);
    }

    public void reset()
    {
        Debug.Log("Reset");
        EnermyTransform.position = originalPosition;
        EnermyRigid.velocity = Vector3.zero;
    }
}
