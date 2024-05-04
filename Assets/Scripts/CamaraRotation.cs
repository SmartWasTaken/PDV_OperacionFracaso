using UnityEngine;

public class LimitedRotator : MonoBehaviour
{
    public float rotationSpeed = 50f; // Velocidad de rotación, editable desde el editor
    private float currentRotation = 0f; // Rastrea la rotación actual
    private int rotationDirection = 1; // Dirección de rotación: 1 para aumentar, -1 para disminuir

    void Update()
    {
        // Calcular la rotación del fotograma actual
        float rotationThisFrame = rotationSpeed * Time.deltaTime * rotationDirection;

        // Actualizar la rotación actual
        currentRotation += rotationThisFrame;

        // Comprobar si se ha alcanzado el límite de 180 grados
        if (currentRotation >= 45f)
        {
            // Cambiar la dirección de rotación a disminuir
            rotationDirection = -1;
        }
        else if (currentRotation <= 0f)
        {
            // Cambiar la dirección de rotación a aumentar
            rotationDirection = 1;
        }

        // Rotar el objeto en el eje Z
        transform.Rotate(Vector3.forward * rotationThisFrame);
    }
}
