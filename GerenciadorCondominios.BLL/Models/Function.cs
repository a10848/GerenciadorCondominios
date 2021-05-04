using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Function:IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
