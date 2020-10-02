namespace ToldecaAppCore.Entidades
{
    using System;

    public class TipoCobroTpreng
    {
        public int RengNum { get; set; }
        public string CobNum { get; set; }
        public string CoTar { get; set; }
        public string CoBan { get; set; }
        public string FormaPag { get; set; }
        public string CodCta { get; set; }
        public string CodCaja { get; set; }
        public string CoVale { get; set; }
        public string MovNumC { get; set; }
        public string MovNumB { get; set; }
        public string NumDoc { get; set; }
        public bool Devuelto { get; set; }
        public decimal MontDoc { get; set; }
        public DateTime FechaChe { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoSucuMo { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }

        public virtual EncabCobro CobNumNavigation { get; set; }
    }
}
