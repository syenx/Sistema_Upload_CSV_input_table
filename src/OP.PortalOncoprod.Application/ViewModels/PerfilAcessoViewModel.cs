using System.ComponentModel.DataAnnotations;

namespace OP.PortalOncoprod.Application.ViewModels
{
    public class PerfilAcessoViewModel
    {
        [Key]
        public string perfilAcessoId { get; set; }
        public string perfilAcessoDescricao { get; set; }
        public bool perfilAcessoWFCadastro { get; set; }
        public bool perfilAcessoWFApoio { get; set; }
        public bool perfilAcessoWFFinanceiro { get; set; }
        public bool perfilAcessoWFFiscal { get; set; }
    }
}
