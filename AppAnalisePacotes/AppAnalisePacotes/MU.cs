using System;

public class MU
{
    public int Object { get; set; }
    public int Resource { get; set; }
    public int ID { get; set; }
    public double Current { get; set; }
    public double Voltage { get; set; }
    public string Status { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }   // Data/hora de envio do pacote
    public double LatencyMs { get; set; }     // Latência em milissegundos (calculada localmente)

  
}