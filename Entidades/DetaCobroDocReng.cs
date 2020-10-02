﻿namespace ToldecaAppCore.Entidades
{
    using System;
    public class DetaCobroDocReng
    {
        public int RengNum { get; set; }
        public string CobNum { get; set; }
        public string CoTipoDoc { get; set; }
        public string NroDoc { get; set; }
        public decimal MontCob { get; set; }
        public decimal DpcobroPorcDesc { get; set; }
        public decimal DpcobroMonto { get; set; }
        public decimal MontoRetencionIva { get; set; }
        public decimal MontoRetencion { get; set; }
        public Guid? RetenTerceroRowguidOri { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public Guid? RowguidRengOri { get; set; }
        public int? TipoOrigen { get; set; }
        public string GenOrigen { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoSucuMo { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual EncabCobro CobNumNavigation { get; set; }
    }
}
