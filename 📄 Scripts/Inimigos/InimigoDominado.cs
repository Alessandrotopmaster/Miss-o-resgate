using UnityEngine;

public class InimigoDominado : MonoBehaviour
{
    public string nome;
    public string historia;

    void OnDestroy()
    {
        // Quando derrotado, aparece a sombra
        Alertas.MostrarAlerta($"Essa é a alma de {nome} — {historia}. Tempo para resgate: 5 minutos!");
        Instantiate(Resources.Load("SombraObjeto"), transform.position, Quaternion.identity);
    }
}
