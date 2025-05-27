using UnityEditor;
using UnityEngine;

public class CollectioanbleItems : MonoBehaviour
{
    public GameObject handTarget;
    private GameObject pickedObject = null;

    private void Update()
    {
        if (pickedObject != null)
        {
            // Mantener la posición del objeto en la mano
            pickedObject.transform.position = handTarget.transform.position;

            if (Input.GetKey(KeyCode.R))
            {
                // Soltar el objeto
                pickedObject.transform.SetParent(null, true);
                pickedObject.transform.rotation = Quaternion.Euler(90, 0, 0);

                var physics = pickedObject.GetComponent<CustomPhysicsObject>();
                if (physics != null)
                {
                    physics.simulatePhysics = true;
                    physics.velocity = Vector2.zero;
                }

                pickedObject = null;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Collectionable") && pickedObject == null)
        {
            if (Input.GetKey(KeyCode.E))
            {
                pickedObject = other.gameObject;

                var physics = pickedObject.GetComponent<CustomPhysicsObject>();
                if (physics != null)
                {
                    physics.simulatePhysics = false;
                }

                pickedObject.transform.SetParent(handTarget.transform, false);
                pickedObject.transform.localRotation = Quaternion.Euler(0, 90, 0);
                pickedObject.transform.position = handTarget.transform.position;
            }
        }
    }
}
