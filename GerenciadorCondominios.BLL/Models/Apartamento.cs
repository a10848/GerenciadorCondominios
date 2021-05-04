﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Apartamento
    {
        public int ApartamentoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 1000, ErrorMessage = "Valor Inválido")]
        [Display(Name ="Número")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, 10, ErrorMessage = "Valor Inválido")]
        public int Andar { get; set; }
        public string Foto { get; set; }
        public int MoradorId { get; set; }
        public virtual User Morador { get; set; }
        public int ProprietarioId { get; set; }
        public virtual User Proprietario { get; set; }
    }
}
