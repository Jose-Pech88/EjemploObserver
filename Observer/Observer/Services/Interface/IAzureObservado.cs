namespace Observer.Services.Interface
{
    public interface IAzureObservado 
    {
        string cNombreCambio { set; get; }
        string cComentario { set; get; }

        // Attach an observer to the subject.
        void Attach(IAzureObservador observer);

        // Detach an observer from the subject.
        void Detach(IAzureObservador observer);

        // Notify all observers about an event.
        void Notify();
    }
}
