namespace ToldecaAppCore.Entidades
{
    using System;
    using System.Collections.Generic;

    public class EncabCobro
    {
        public string CobNum { get; set; }
        public string Recibo { get; set; }
        public string Descrip { get; set; }
        public string CoCli { get; set; }
        public string CoVen { get; set; }
        public string CoMone { get; set; }
        public decimal Tasa { get; set; }
        public DateTime Fecha { get; set; }
        public bool Anulado { get; set; }
        public decimal Monto { get; set; }
        public string DisCen { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }
        public string Maquina { get; set; }
        public virtual ICollection<DetaCobroDocReng> DetaCobroDocReng { get; set; }
        public virtual ICollection<TipoCobroTpreng> TipoCobroTpreng { get; set; }

    }
}
