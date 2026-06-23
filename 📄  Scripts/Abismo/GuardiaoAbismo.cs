using UnityEngine;

public class GuardiaoAbismo : MonoBehaviour
{
    public float vida = 100f;

    public void ReceberDano(float valor)
    {
        vida -= valor;
        if (vida <= 0)
        {
            DestruirGuardiao();
        }
    }

    private void DestruirGuardiao()
    {
        Alertas.Mostrar("Guardião derrotado!");
        Destroy(gameObject);
    }
}
