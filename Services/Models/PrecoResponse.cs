namespace Correios.Demo.Services.Models
{
    public class PrecoResponse
    {

        /// <summary>
        /// Código do produto ou serviço consultado. Exemplo: 45209
        /// </summary>
        public string coProduto { get; set; }

        /// <summary>
        /// Código do produto ou serviço consultado.
        /// </summary>
        public string noProduto { get; set; }

        /// <summary>
        /// Preço base é o valor da proposta de preco, um valor único (não leva em conta outras variaveis como quantidade)
        /// </summary>
        public string pcBase { get; set; }

        /// <summary>
        /// Preço base geral é preço da faixa acrescido do preço dos adicionais.O Adicional representa kilos adicionais, paginas adicionais, etc. (pcBaseGeral = pcFaixa + pcTotalAdicional )
        /// </summary>
        public string pcBaseGeral { get; set; }

        /// <summary>
        /// Percentual da variação do combo do cliente.
        /// </summary>
        public string peVariacao { get; set; }

        /// <summary>
        /// Preço de referência é o preço base geral descontado o valor de desconto da variação(combo). (pcReferencia = pcBaseGeral - vlDescVariacao )
        /// </summary>
        public string pcReferencia { get; set; }

        /// <summary>
        /// Lista de benefícios que serão aplicadas ao preço do produto
        /// </summary>
        public BeneficioResponse[] beneficios { get; set; }

        /// <summary>
        /// Valor da base de cálculo é o preço de referência acrescido do valor total dos serviços adicionais, deduzindo os valores dos benefícios que são incondicionais. (vlBaseCalculo = pcReferencia + pcTotalServicosAdicionais - [somatório dos valores dos benefícios que são incondicionais])
        /// </summary>
        public string vlBaseCalculoImposto { get; set; }

        /// <summary>
        /// Número da requisição.Número informado e controlado pelo requisitante do serviço.Exemplo: Número de etiqueta
        /// </summary>
        public string nuRequisicao { get; set; }

        /// <summary>
        /// Indicador de cobrança pelo peso cúbico.Se S: Indica que foi cobrado pelo pelo cubico.N: Indica que foi cobrado pelo peso real
        /// </summary>
        public string inPesoCubico { get; set; }

        /// <summary>
        /// Peso cobrado/tarifado em gramas.Pode ser superior ao peso real, caso seja cobrado pelo peso cúbico
        /// </summary>
        public string psCobrado { get; set; }

        /// <summary>
        /// Preço dos serviços adicionais.
        /// </summary>
        public PrecoServicoAdicional[] servicoAdicional { get; set; }

        /// <summary>
        /// Percentual de advalorem. Exemplo: 0,1000
        /// </summary>
        public string peAdValorem { get; set; }

        /// <summary>
        /// Valor declarado do seguro automático. Exemplo: 50,00
        /// </summary>
        public string vlSeguroAutomatico { get; set; }

        /// <summary>
        /// Quantidade de adicionais. Exemplo: kilos adicionais
        /// </summary>
        public string qtAdicional { get; set; }

        /// <summary>
        /// Preço da faixa da tabela base é o fator da faixa de peso multiplicado pelo preço base da tabela. (pcFaixa = fator(faixa) * pcBase)

        /// </summary>
        public string pcFaixa { get; set; }

        /// <summary>
        /// Preço de cada adicional é o fator da faixa do adicional multiplicado pelo preço base da tabela. (pcCadaAdicional = fator(adicional) * pcBase)
        /// </summary>
        public string pcCadaAdicional { get; set; }

        /// <summary>
        /// Preço total dos adicionais é o preço de cada adicional multiplicado pela quantidade de adicionais. (pcTotalAdicional = pcCadaAdicional * qtAdicional)
        /// </summary>
        public string pcTotalAdicional { get; set; }

        /// <summary>
        /// Preço da faixa da variação é o preço da faixa da tabela base menos o percentual da variação. (pcFaixaVariacao = pcFaixa - peVariacao(%) )
        /// </summary>
        public string pcFaixaVariacao { get; set; }

        /// <summary>
        /// Preço de cada adicional da variação é o preço de cada adicional menos o percentual da variação. (pcCadaAdicionalVariacao = pcCadaAdicional - peVariacao(%))
        /// </summary>
        public string pcCadaAdicionalVariacao { get; set; }

        /// <summary>
        /// Preço total dos adicionais da variação é o preço de cada adicional da variação multiplicado pela quantidade de adicionais. (pcTotalAdicionalVariacao = pcCadaAdicionalVariacao * qtAdicional)
        /// </summary>
        public string pcTotalAdicionalVariacao { get; set; }

        /// <summary>
        /// Valor total de descontos da variação.Descontos referente ao combo do cliente. Exemplo: 50,00
        /// </summary>
        public string vlTotalDescVariacao { get; set; }

        /// <summary>
        /// Valor total dos benefícios. Exemplo: 50,00
        /// </summary>
        public string vlTotalBeneficios { get; set; }

        /// <summary>
        /// Preço do produto é o preço de referência deduzindo o valor dos benefícios. (pcProduto = pcReferencia - vlTotalBeneficios). Exemplo: 10,00
        /// </summary>
        public string pcProduto { get; set; }

        /// <summary>
        /// Valor total dos serviços adicionais que foi embutido no preço final. Exemplo: 10,00
        /// </summary>
        public string pcTotalServicosAdicionais { get; set; }

        /// <summary>
        /// Preço final é o preço do produto somado com o preço total do serviços adicionais. (pcFinal = pcProduto + pcTotalServicosAdicionais)
        /// </summary>
        public string pcFinal { get; set; }

        /// <summary>
        /// Descricao do erro retornado
        /// </summary>
        public string txErro { get; set; }

        /// <summary>
        /// Lista de informações complementares da formação de preço.
        /// </summary>
        public InfoAdicionalResponse[] infoAdicional { get; set; }

        /// <summary>
        /// Nome do produto.Apresentado apenas para serviço internacional
        /// </summary>
        public string nomeProduto { get; set; }

        /// <summary>
        /// Percentual de isenção de pagamento para serviços com armazenagem.
        /// </summary>
        public string peIsencaoArmazenagem { get; set; }

        /// <summary>
        /// Taxas extras
        /// </summary>
        public TaxaExtraResponse taxaExtra { get; set; }
    }

    public class TaxaExtraResponse
    {
        public string codigo { get; set; }
        public string tipo { get; set; }
        public string vlTaxa { get; set; }
    }

    public class InfoAdicionalResponse
    {
        /// <summary>
        /// Código da informação complementar.Enum: [LOB_ERP, LIMITE_MAX_TARIFACAO_ERP, VALOR_PARAMETRO_KILO_ADICIONAL_ERP, LOB_SGPB, NU_PROPOSTA, CO_MODELO, CO_SIMILARIDADE, IN_EXIGENCIA_CEP_DESTINO, CO_AGRUPADOR, TIPO_AGRUPADOR, NU_CORREDOR_ORIGEM, NU_CORREDOR_DESTINO, NU_TABELA_FATOR, NU_LINHA_FATOR, NU_COLUNA_FATOR, NO_COLUNA_FATOR, CLASSIFICACAO_COLUNA, NU_COMBO, NU_VARIACAO, VL_PRECO_BASE, FATOR_FAIXA, FATOR_CADA_ADICIONAL, QT_EXCESSO, NO_PRODUTO, TP_TARIFACAO_ERP, IN_CORREDOR_FAIXA_CEP_SGPB, IN_PRECIFICACAO_SGPB, VL_TAXA_EXTRA]
        /// </summary>
        public string tipo { get; set; }

        /// <summary>
        /// Conteúdo da informação complementar.
        /// </summary>
        public string valor { get; set; }
    }

    public class PrecoServicoAdicional
    {
        /// <summary>
        /// Código do serviço adicional
        /// </summary>
        public string coServAdicional { get; set; }

        /// <summary>
        /// Tipo do serviço adicional
        /// </summary>
        public string tpServAdicional { get; set; }

        /// <summary>
        /// Preço do serviço adicional
        /// </summary>
        public string pcServicoAdicional { get; set; }
    }

    public class BeneficioResponse
    {
        /// <summary>
        /// Código do tipo de benefício.
        /// </summary>
        public string codigo { get; set; }

        /// <summary>
        /// Enum: [DP, DF, BP, BF, BC]
        /// </summary>
        public string tipoBeneficio { get; set; }

        /// <summary>
        /// Tipo do benefício. Desconto Promocional - Oferta; Desconto Promocional - Negociação; Desconto Funcional - Negociação;
        /// </summary>
        public string tipo { get; set; }

        /// <summary>
        /// Abrangência.O: Oferta; N: Negociação; Enum: [O, N]
        /// </summary>
        public string abrangencia { get; set; }

        /// <summary>
        /// Código do pacote de benefício.
        /// </summary>
        public string coPacote { get; set; }

        /// <summary>
        /// Nome do pacote de benefício.
        /// </summary>
        public string noPacote { get; set; }

        /// <summary>
        /// Incondicional de redução ou não do valor de base de cálculo (S ou N).
        /// </summary>
        public string incondicional { get; set; }

        /// <summary>
        /// Lista de critérios funcionais.
        /// </summary>
        public CriterioAtendidoResponse criterio { get; set; }

        /// <summary>
        /// Valor base para cálculo do imposto.
        /// </summary>
        public string vlBaseCalculo { get; set; }

        /// <summary>
        /// Percentual de benefício concedido.
        /// </summary>
        public string percentual { get; set; }

        /// <summary>
        /// Valor do benefício concedido. (valor = vlBaseCalculo * percentual)
        /// </summary>
        public string valor { get; set; }
    }

    public class CriterioAtendidoResponse
    {
        /// <summary>
        /// Número do critério
        /// </summary>
        public string nuCriterio { get; set; }

        /// <summary>
        /// Nome do critério
        /// </summary>
        public string noCriterio { get; set; }

        /// <summary>
        /// Indica que o critério foi atendido[S ou N]
        /// </summary>
        public string atendido { get; set; }

        /// <summary>
        /// Percentual negociado para o critério
        /// </summary>
        public string peNegociado { get; set; }

        /// <summary>
        /// Percentual concedido para o critério
        /// </summary>
        public string peConcedido { get; set; }
    }
}