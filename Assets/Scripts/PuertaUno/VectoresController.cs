using UnityEngine;

public class VectoresController : MonoBehaviour
{
    /*Posicion Vector Respuesta Por Defecto*/
    Vector3 vPositionRtaDF = new Vector3(-58.4059982f, 2.93000007f, 7.91499996f);
    Vector3 vRotationRtaDF = new Vector3(1.53329313f, 1.46375883f, 270.407745f);
    Vector3 vScaleRtaDF = new Vector3(0.0522578843f, 1.34651029f, 0.068155244f);

    /*Posicion Vector Respuesta Correcta*/
    Vector3 vPositionRtaOK = new Vector3(-59.2439995f, 1.47300005f, 7.84100008f);
    Vector3 vRotationRtaOK = new Vector3(1.53329241f, 1.46375322f, 295.782928f);
    Vector3 vScaleRtaOK = new Vector3(0.0522578843f, 1.34651029f, 0.068155244f);

    /*Posicion Vector Respuesta UNO*/
    Vector3 vPositionRtaUNO = new Vector3(-58.401001f, 2.11299992f, 7.89300013f);
    Vector3 vRotationRtaUNO = new Vector3(1.53329313f, 1.46375883f, 270.407745f);
    Vector3 vScaleRtaUNO = new Vector3(0.0522578843f, 1.34651029f, 0.068155244f);

    /*Posicion Vector Respuesta DOS*/
    Vector3 vPositionRtaDOS = new Vector3(-57.5849991f, 1.56099999f, 7.87699986f);
    Vector3 vRotationRtaDOS = new Vector3(1.46894526f, 357.912994f, 290.840149f);
    Vector3 vScaleRtaDOS = new Vector3(0.0522578843f, 1.34651029f, 0.068155244f);

    public Transform vectorC; // La flecha de respuesta que moverás
    public Transform puerta; // La puerta que se abrirá

    public Vector3[] posicionesRespuesta; // Las 3 posiciones para el vector C
    private int indiceCorrecto = 0; // Index de la opción correcta (0,1 o 2)

    public void EscogerOpcion(int index)
    {
        vectorC.position = posicionesRespuesta[index];

        if (index == indiceCorrecto)
        {
            AbrirPuerta();
        }
    }

    private void AbrirPuerta()
    {
        puerta.Translate(Vector3.right * 2f); // Mueve la puerta a la derecha
        puerta.GetComponent<Collider>().enabled = false; // Desactiva colisión
        Debug.Log("¡Respuesta correcta! Puerta abierta.");
    }
}
