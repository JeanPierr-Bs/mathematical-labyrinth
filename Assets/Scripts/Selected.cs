using Unity.VisualScripting;
using UnityEngine;

public class Selected : MonoBehaviour
{
    LayerMask mask;
    public float distance = 1.5f;

   void Start()
   {
        mask = LayerMask.GetMask("Raycast Detect");
   }
    private void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {
            if(hit.collider.tag == "Raycast Detect")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {

                }
            }
        }
    }
}
