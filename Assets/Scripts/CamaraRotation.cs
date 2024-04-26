using UnityEngine;

public class LimitedRotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Velocidad de rotaci�n, editable desde el editor
    private float currentRotation = 0f; // Rastrea la rotaci�n actual
    private int rotationDirection = 1; // Direcci�n de rotaci�n: 1 para aumentar, -1 para disminuir

    void Update()
    {
        // Calcular la rotaci�n del fotograma actual
        float rotationThisFrame = rotationSpeed * Time.deltaTime * rotationDirection;

        // Actualizar la rotaci�n actual
        currentRotation += rotationThisFrame;

        // Comprobar si se ha alcanzado el l�mite de 180 grados
        if (currentRotation >= 45f)
        {
            // Cambiar la direcci�n de rotaci�n a disminuir
            rotationDirection = -1;
        }
        else if (currentRotation <= 0f)
        {
            // Cambiar la direcci�n de rotaci�n a aumentar
            rotationDirection = 1;
        }

        // Rotar el objeto en el eje Z
        transform.Rotate(Vector3.forward * rotationThisFrame);
    }
}
