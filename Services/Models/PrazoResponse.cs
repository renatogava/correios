namespace Correios.Demo.Services.Models
{
    public class PrazoResponse
    {
        /// <summary>
        /// Código do produto ou serviço
        /// </summary>
        public string coProduto { get; set; }

        /// <summary>
        /// Número da requisição.Número informado e controlado pelo requisitante
        /// </summary>
        public string nuRequisicao { get; set; }

        /// <summary>
        /// Prazo em dias úteis
        /// </summary>
        public int prazoEntrega { get; set; }

        /// <summary>
        /// Data máxima de entrega
        /// </summary>
        public string dataMaxima { get; set; }

        /// <summary>
        /// Descricao do erro retornado
        /// </summary>
        public string txErro { get; set; }

        /// <summary>
        /// Indicador de entrega domiciliar
        /// </summary>
        public string entregaDomiciliar { get; set; }

        /// <summary>
        /// Indicador de entrega aos sábados
        /// </summary>
        public string entregaSabado { get; set; }

        /// <summary>
        /// Mensagem de prazo
        /// </summary>
        public string msgPrazo { get; set; }
    }
}
