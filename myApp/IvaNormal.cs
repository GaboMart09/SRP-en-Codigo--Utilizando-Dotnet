class IvaNormal
{
     private double PORCENTAJE_IVA_NORMAL = 0.12;
     public double PorcentajeIvaNormal
    {
        get
        {
            return PORCENTAJE_IVA_NORMAL;
        }
    }
  
    public double CalcularIVA(double importe)
    {
        return importe * PORCENTAJE_IVA_NORMAL;
    }
}