namespace Correios.Demo.Services.Models
{
    public class PrecoRequest
    {
        /// <summary>
        /// Identificador do lote da consulta.
        /// </summary>
        public string idLote { get; set; }

        public IList<PrecoNacionalParam> parametrosProduto { get; set; }
    }

    public class PrecoNacionalParam
    {
        /// <summary>
        /// Código do produto ou serviço. Exemplo: 04162
        /// </summary>
        public string coProduto { get; set; }

        /// <summary>
        /// Número da requisição.Número informado e controlado pelo requisitante do serviço.
        /// </summary>
        public string nuRequisicao { get; set; }

        /// <summary>
        /// Número do contrato.
        /// </summary>
        public string nuContrato { get; set; }

        /// <summary>
        /// Número da DR do contrato.
        /// </summary>
        public int nuDR { get; set; }

        /// <summary>
        /// CEP de origem da postagem. Exemplo: 70902000
        /// </summary>
        public string cepOrigem { get; set; }

        /// <summary>
        /// Peso do objeto em gramas. Exemplo: 300
        /// </summary>
        public string psObjeto { get; set; }

        /// <summary>
        /// Número de unidades prestadas no atendimento.Número de páginas, palavras, minutos.
        /// </summary>
        public string nuUnidade { get; set; }

        /// <summary>
        /// Tipo do objeto da postagem: 1 - Envelope, 2 - Pacote; 3 - Rolo.
        /// </summary>
        public string tpObjeto { get; set; }

        /// <summary>
        /// Comprimento do objeto, em centímetros.
        /// </summary>
        public string comprimento { get; set; }

        /// <summary>
        /// Largura do objeto, em centímetros.
        /// </summary>
        public string largura { get; set; }

        /// <summary>
        /// Altura do objeto, em centímetros.
        /// </summary>
        public string altura { get; set; }

        /// <summary>
        /// Diâmetro do objeto, em centímetros.
        /// </summary>
        public string diametro { get; set; }

        /// <summary>
        /// Peso cúbico do objeto em gramas.
        /// </summary>
        public string psCubico { get; set; }

        /// <summary>
        /// Lista de serviços adicionais
        /// </summary>
        public string[] servicosAdicionais { get; set; }

        /// <summary>
        /// Lista dos criterios de desconto funcional
        /// </summary>
        public string[] criterios { get; set; }

        /// <summary>
        /// Valor declarado associado ao serviço.
        /// </summary>
        public string vlDeclarado { get; set; }

        /// <summary>
        /// Data que será usado para o cálculo do preço.DD-MM-YYYY
        /// </summary>
        public string dtEvento { get; set; }

        /// <summary>
        /// Código MCMCU da unidade de origem para precificar conforme canal de postagem
        /// </summary>
        public string coUnidadeOrigem { get; set; }

        /// <summary>
        /// Data de armazenagem, para os serviços que ganham isenção de preço, conforme a data de armazenagem.Formato DD-MM-YYYY
        /// </summary>
        public string dtArmazenagem { get; set; }

        /// <summary>
        /// CEP de destino da postagem. Exemplo: 71930000
        /// </summary>
        public string cepDestino { get; set; }
    }
}
