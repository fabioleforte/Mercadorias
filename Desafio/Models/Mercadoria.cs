﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Desafio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class MERCADORIA
    {
        public int CodigoMerc { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o Tipo da Mercadoria")]
        [Display(Name ="Tipo de Mercadoria")]
        public string TipoMercadoria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome da Mercadoria")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Quantidade da Mercadoria")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Preço da Mercadoria")]
        [Display(Name ="Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Tipo Compra = C ou Venda = V")]
        [Display(Name = "Tipo Mercadoria Compra = C / Venda = V")]
        public string Tipo { get; set; }
    }
}
