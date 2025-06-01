using UnityEngine;

public class ZonaRespuesta : MonoBehaviour
{
    public int opcionIndex; // 0, 1 o 2

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VectoresController controller = FindFirstObjectByType<VectoresController>();
            controller.EscogerOpcion(opcionIndex);
        }
    }
}
