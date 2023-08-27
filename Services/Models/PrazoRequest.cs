namespace Correios.Demo.Services.Models
{
    public class PrazoRequest
    {
        /// <summary>
        /// Identificador do lote da consulta.
        /// </summary>
        public string idLote { get; set; }

        /// <summary>
        /// Lista dos parâmetros de consulta.
        /// </summary>
        public IList<ParamPrazoNacional> parametrosPrazo { get; set; }
    }

    public class ParamPrazoNacional
    {
        /// <summary>
        /// Código do produto. Exemplo: 04162
        /// </summary>
        public string coProduto { get; set; }

        /// <summary>
        /// Número informado e controlado pelo requisitante.
        /// </summary>
        public string nuRequisicao { get; set; }

        /// <summary>
        /// Data que será usado para o cálculo o prazo.Formato DD/MM/YYYY.Caso não informado, será considerada a data atual.
        /// </summary>
        public string dtEvento { get; set; }

        /// <summary>
        /// CEP de origem da postagem.
        /// </summary>
        public string cepOrigem { get; set; }

        /// <summary>
        /// CEP de destino da postagem.
        /// </summary>
        public string cepDestino { get; set; }

        /// <summary>
        /// Data da postagem
        /// </summary>
        public string dataPostagem { get; set; }
    }
}
