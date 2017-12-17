class FacturaFactorizada
{
    public string Codigo { get; set; }
    public string FechaEmision { get; set; }
    public double Factura { get; set; }
    public double IVA { get; set; }
    public double Deduccion { get; set; }
    public double Total { get; set; }
    public double PorcentajeDeduccion { get; set; }
        
    // Método que calcula el total de la Factura
    public double CalcularTotal()
    {
    
        // Calculamos el IVA
        IvaNormal iva = new IvaNormal();
        IVA = iva.CalcularIVA(Factura);
        // Calculamos el total
        Total = (Factura - Deduccion) + IVA;

        return Total;
    }
}