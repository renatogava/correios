namespace Correios.Demo.Services.Models
{
    public class TokenResponse
    {
        /// <summary>
        /// Ambiente. Enum: [PRODUCAO, HOMOLOGACAO, DESENVOLVIMENTO, LOCAL]
        /// </summary>
        public string ambiente { get; set; }

        /// <summary>
        /// Identificador do usuário
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// IP do requisitante
        /// </summary>
        public string ip { get; set; }

        /// <summary>
        /// Perfil: PF: Pessoa Física, PJ: Pessoa Jurídica. Enum: [S, A, PJ, PF]
        /// </summary>
        public string perfil { get; set; }

        /// <summary>
        /// CNPJ do usuário
        /// </summary>
        public string cnpj { get; set; }

        /// <summary>
        /// Código internacional do usuário
        /// </summary>
        public int? pjInternacional { get; set; }

        /// <summary>
        /// CPF do usuário
        /// </summary>
        public string cpf { get; set; }

        /// <summary>
        /// CIE do usuário
        /// </summary>
        public string cie { get; set; }

        public CartaoPostagem cartaoPostagem { get; set; }

        public Contrato contrato { get; set; }

        /// <summary>
        /// Data e hora de emissão do token
        /// </summary>
        public DateTime emissao { get; set; }

        /// <summary>
        /// Data e hora de expiração do token
        /// </summary>
        public DateTime expiraEm { get; set; }

        /// <summary>
        /// Deslocamento do GMT/UTC
        /// </summary>
        public string zoneOffset { get; set; }

        /// <summary>
        /// É o token que será usado na requisição, adicionar no header 'Authorization: Bearer <seu_token>'
        /// </summary>
        public string token { get; set; }
    }

    public class CartaoPostagem
    {
        /// <summary>
        /// Número do Cartão de Postagem
        /// </summary>
        public string numero { get; set; }

        /// <summary>
        /// Número do contrato
        /// </summary>
        public string contrato { get; set; }

        /// <summary>
        /// DR/SE do contrato
        /// </summary>
        public int dr { get; set; }

        /// <summary>
        /// Lista de APIs restritas com autorização de acesso
        /// </summary>
        public int[] api { get; set; }
    }

    public class Contrato
    {
        /// <summary>
        /// Número do contrato
        /// </summary>
        public string numero { get; set; }

        /// <summary>
        /// DR/SE do contrato
        /// </summary>
        public int dr { get; set; }

        /// <summary>
        /// Lista de APIs restritas com autorização de acesso
        /// </summary>
        public int[] api { get; set; }
    }
}
