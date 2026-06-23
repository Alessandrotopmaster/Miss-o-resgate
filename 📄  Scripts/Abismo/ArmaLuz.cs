using UnityEngine;

public class ArmaLuz : MonoBehaviour
{
    public float dano = 5f;
    public float alcance = 15f;
    public bool ativa = false;

    public void ReceberArmaInicial()
    {
        ativa = true;
        dano = 5f;
        alcance = 15f;
        Alertas.Mostrar("Feixe de Luz ativado — armas comuns não funcionam aqui!");
    }

    public void Melhorar()
    {
        dano *= 1.4f;
        alcance *= 1.25f;
        Alertas.Mostrar("Arma de Luz aprimorada!");
    }

    public void Disparar()
    {
        if (!ativa) return;
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, alcance))
        {
            GuardiaoAbismo alvo = hit.collider.GetComponent<GuardiaoAbismo>();
            if (alvo != null) alvo.ReceberDano(dano);
        }
    }
}
