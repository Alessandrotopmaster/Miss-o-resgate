using UnityEngine;

public class ZumbiViciado : MonoBehaviour
{
    public string nomeOriginal;
    public string historia;
    public float vida = 60f;
    public float danoAtaque = 8f;
    public AudioClip somGemido;

    private VozDoAlém voz;

    void Start()
    {
        voz = FindObjectOfType<VozDoAlém>();
        GetComponent<AudioSource>().clip = somGemido;
        GetComponent<AudioSource>().Play();
    }

    public void ReceberDano(float valor)
    {
        vida -= valor;
        if (vida <= 0)
        {
            Derrotado();
        }
    }

    private void Derrotado()
    {
        // Revela quem ele era
        voz.Falar($"Esse era {nomeOriginal}. {historia}. Foi viciado e transformado em escravo da própria doença.");
        
        // Cria a sombra para resgate
        Instantiate(Resources.Load("SombraFraca"), transform.position, Quaternion.identity);
        Alertas.Mostrar($"Sombra de {nomeOriginal} apareceu — resgate em até 5 minutos!");

        Destroy(gameObject);
    }
}
