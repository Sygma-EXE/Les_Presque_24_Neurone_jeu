namespace Interface_communication;

/// <summary>
/// Réponse à un message envoyé par un serveur
/// </summary>
public class ReponseServeur : MessageServeur
{
    private Message messageIA;
    
    internal ReponseServeur(Message messageIa, string reponseBrute) : base(reponseBrute)
    {
        this.messageIA = messageIa;
    }

    /// <summary>
    /// Message original
    /// </summary>
    public Message MessageIa => messageIA;
}