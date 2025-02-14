/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// This is used to describe the foundational models used within POS.  Note: LATEST models could be used as the latests of these and then could use a system to either(check a file) or       we could add and endpoint to click out to the cloud to get the latest models and update these locally so that our users       can always have the latest without having to update the application.(not used for now)
    /// </summary>
    /// <value>This is used to describe the foundational models used within POS.  Note: LATEST models could be used as the latests of these and then could use a system to either(check a file) or       we could add and endpoint to click out to the cloud to get the latest models and update these locally so that our users       can always have the latest without having to update the application.(not used for now)</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ModelFoundationEnum
    {
        /// <summary>
        /// Enum GPT35 for value: GPT_3.5
        /// </summary>
        [EnumMember(Value = "GPT_3.5")]
        GPT35 = 1,

        /// <summary>
        /// Enum GPT4 for value: GPT_4
        /// </summary>
        [EnumMember(Value = "GPT_4")]
        GPT4 = 2,

        /// <summary>
        /// Enum T5 for value: T5
        /// </summary>
        [EnumMember(Value = "T5")]
        T5 = 3,

        /// <summary>
        /// Enum LLAMA27B for value: LLAMA_2_7B
        /// </summary>
        [EnumMember(Value = "LLAMA_2_7B")]
        LLAMA27B = 4,

        /// <summary>
        /// Enum LLAMA213B for value: LLAMA_2_13B
        /// </summary>
        [EnumMember(Value = "LLAMA_2_13B")]
        LLAMA213B = 5,

        /// <summary>
        /// Enum LLAMA270B for value: LLAMA_2_70B
        /// </summary>
        [EnumMember(Value = "LLAMA_2_70B")]
        LLAMA270B = 6,

        /// <summary>
        /// Enum LLAMA32B for value: LLAMA_3_2B
        /// </summary>
        [EnumMember(Value = "LLAMA_3_2B")]
        LLAMA32B = 7,

        /// <summary>
        /// Enum LLAMA313B for value: LLAMA_3_13B
        /// </summary>
        [EnumMember(Value = "LLAMA_3_13B")]
        LLAMA313B = 8,

        /// <summary>
        /// Enum LLAMA370B for value: LLAMA_3_70B
        /// </summary>
        [EnumMember(Value = "LLAMA_3_70B")]
        LLAMA370B = 9,

        /// <summary>
        /// Enum CODELLAMA27B for value: CODE_LLAMA_2_7B
        /// </summary>
        [EnumMember(Value = "CODE_LLAMA_2_7B")]
        CODELLAMA27B = 10,

        /// <summary>
        /// Enum CODELLAMA213B for value: CODE_LLAMA_2_13B
        /// </summary>
        [EnumMember(Value = "CODE_LLAMA_2_13B")]
        CODELLAMA213B = 11,

        /// <summary>
        /// Enum CODELLAMA270B for value: CODE_LLAMA_2_70B
        /// </summary>
        [EnumMember(Value = "CODE_LLAMA_2_70B")]
        CODELLAMA270B = 12,

        /// <summary>
        /// Enum BARD for value: BARD
        /// </summary>
        [EnumMember(Value = "BARD")]
        BARD = 13,

        /// <summary>
        /// Enum ALPACA7B for value: ALPACA_7B
        /// </summary>
        [EnumMember(Value = "ALPACA_7B")]
        ALPACA7B = 14,

        /// <summary>
        /// Enum ALPACA13B for value: ALPACA_13B
        /// </summary>
        [EnumMember(Value = "ALPACA_13B")]
        ALPACA13B = 15,

        /// <summary>
        /// Enum ALPACA33B for value: ALPACA_33B
        /// </summary>
        [EnumMember(Value = "ALPACA_33B")]
        ALPACA33B = 16,

        /// <summary>
        /// Enum ALPACA65B for value: ALPACA_65B
        /// </summary>
        [EnumMember(Value = "ALPACA_65B")]
        ALPACA65B = 17,

        /// <summary>
        /// Enum VICUNA7B for value: VICUNA_7B
        /// </summary>
        [EnumMember(Value = "VICUNA_7B")]
        VICUNA7B = 18,

        /// <summary>
        /// Enum VICUNA13B for value: VICUNA_13B
        /// </summary>
        [EnumMember(Value = "VICUNA_13B")]
        VICUNA13B = 19,

        /// <summary>
        /// Enum VICUNA33B for value: VICUNA_33B
        /// </summary>
        [EnumMember(Value = "VICUNA_33B")]
        VICUNA33B = 20,

        /// <summary>
        /// Enum VICUNA65B for value: VICUNA_65B
        /// </summary>
        [EnumMember(Value = "VICUNA_65B")]
        VICUNA65B = 21,

        /// <summary>
        /// Enum GUANACO7B for value: GUANACO_7B
        /// </summary>
        [EnumMember(Value = "GUANACO_7B")]
        GUANACO7B = 22,

        /// <summary>
        /// Enum GUANACO13B for value: GUANACO_13B
        /// </summary>
        [EnumMember(Value = "GUANACO_13B")]
        GUANACO13B = 23,

        /// <summary>
        /// Enum GUANACO33B for value: GUANACO_33B
        /// </summary>
        [EnumMember(Value = "GUANACO_33B")]
        GUANACO33B = 24,

        /// <summary>
        /// Enum GUANACO65B for value: GUANACO_65B
        /// </summary>
        [EnumMember(Value = "GUANACO_65B")]
        GUANACO65B = 25,

        /// <summary>
        /// Enum OPENLLAMA7B for value: OPENLLAMA_7B
        /// </summary>
        [EnumMember(Value = "OPENLLAMA_7B")]
        OPENLLAMA7B = 26,

        /// <summary>
        /// Enum OPENLLAMA13B for value: OPENLLAMA_13B
        /// </summary>
        [EnumMember(Value = "OPENLLAMA_13B")]
        OPENLLAMA13B = 27,

        /// <summary>
        /// Enum GORILLA7B for value: GORILLA_7B
        /// </summary>
        [EnumMember(Value = "GORILLA_7B")]
        GORILLA7B = 28,

        /// <summary>
        /// Enum GORILLA13B for value: GORILLA_13B
        /// </summary>
        [EnumMember(Value = "GORILLA_13B")]
        GORILLA13B = 29,

        /// <summary>
        /// Enum GORILLA33B for value: GORILLA_33B
        /// </summary>
        [EnumMember(Value = "GORILLA_33B")]
        GORILLA33B = 30,

        /// <summary>
        /// Enum GORILLA65B for value: GORILLA_65B
        /// </summary>
        [EnumMember(Value = "GORILLA_65B")]
        GORILLA65B = 31,

        /// <summary>
        /// Enum WIZARDLM7B for value: WIZARDLM_7B
        /// </summary>
        [EnumMember(Value = "WIZARDLM_7B")]
        WIZARDLM7B = 32,

        /// <summary>
        /// Enum WIZARDLM13B for value: WIZARDLM_13B
        /// </summary>
        [EnumMember(Value = "WIZARDLM_13B")]
        WIZARDLM13B = 33,

        /// <summary>
        /// Enum WIZARDLM30B for value: WIZARDLM_30B
        /// </summary>
        [EnumMember(Value = "WIZARDLM_30B")]
        WIZARDLM30B = 34,

        /// <summary>
        /// Enum YULANCHAT13B for value: YULANCHAT_13B
        /// </summary>
        [EnumMember(Value = "YULANCHAT_13B")]
        YULANCHAT13B = 35,

        /// <summary>
        /// Enum YULANCHAT65B for value: YULANCHAT_65B
        /// </summary>
        [EnumMember(Value = "YULANCHAT_65B")]
        YULANCHAT65B = 36,

        /// <summary>
        /// Enum REDPAJAMA3B for value: REDPAJAMA_3B
        /// </summary>
        [EnumMember(Value = "REDPAJAMA_3B")]
        REDPAJAMA3B = 37,

        /// <summary>
        /// Enum REDPAJAMA7B for value: REDPAJAMA_7B
        /// </summary>
        [EnumMember(Value = "REDPAJAMA_7B")]
        REDPAJAMA7B = 38,

        /// <summary>
        /// Enum REDPAJAMA13B for value: REDPAJAMA_13B
        /// </summary>
        [EnumMember(Value = "REDPAJAMA_13B")]
        REDPAJAMA13B = 39,

        /// <summary>
        /// Enum REDPAJAMA33B for value: REDPAJAMA_33B
        /// </summary>
        [EnumMember(Value = "REDPAJAMA_33B")]
        REDPAJAMA33B = 40,

        /// <summary>
        /// Enum REDPAJAMA65B for value: REDPAJAMA_65B
        /// </summary>
        [EnumMember(Value = "REDPAJAMA_65B")]
        REDPAJAMA65B = 41,

        /// <summary>
        /// Enum DOLLY70M for value: DOLLY_70M
        /// </summary>
        [EnumMember(Value = "DOLLY_70M")]
        DOLLY70M = 42,

        /// <summary>
        /// Enum DOLLY160M for value: DOLLY_160M
        /// </summary>
        [EnumMember(Value = "DOLLY_160M")]
        DOLLY160M = 43,

        /// <summary>
        /// Enum DOLLY410M for value: DOLLY_410M
        /// </summary>
        [EnumMember(Value = "DOLLY_410M")]
        DOLLY410M = 44,

        /// <summary>
        /// Enum DOLLY1B for value: DOLLY_1B
        /// </summary>
        [EnumMember(Value = "DOLLY_1B")]
        DOLLY1B = 45,

        /// <summary>
        /// Enum DOLLY14B for value: DOLLY_1.4B
        /// </summary>
        [EnumMember(Value = "DOLLY_1.4B")]
        DOLLY14B = 46,

        /// <summary>
        /// Enum DOLLY28B for value: DOLLY_2.8B
        /// </summary>
        [EnumMember(Value = "DOLLY_2.8B")]
        DOLLY28B = 47,

        /// <summary>
        /// Enum DOLLY69B for value: DOLLY_6.9B
        /// </summary>
        [EnumMember(Value = "DOLLY_6.9B")]
        DOLLY69B = 48,

        /// <summary>
        /// Enum DOLLY12B for value: DOLLY_12B
        /// </summary>
        [EnumMember(Value = "DOLLY_12B")]
        DOLLY12B = 49,

        /// <summary>
        /// Enum PYTHIA70M for value: PYTHIA_70M
        /// </summary>
        [EnumMember(Value = "PYTHIA_70M")]
        PYTHIA70M = 50,

        /// <summary>
        /// Enum PYTHIA160M for value: PYTHIA_160M
        /// </summary>
        [EnumMember(Value = "PYTHIA_160M")]
        PYTHIA160M = 51,

        /// <summary>
        /// Enum PYTHIA410M for value: PYTHIA_410M
        /// </summary>
        [EnumMember(Value = "PYTHIA_410M")]
        PYTHIA410M = 52,

        /// <summary>
        /// Enum PYTHIA1B for value: PYTHIA_1B
        /// </summary>
        [EnumMember(Value = "PYTHIA_1B")]
        PYTHIA1B = 53,

        /// <summary>
        /// Enum PYTHIA14B for value: PYTHIA_1.4B
        /// </summary>
        [EnumMember(Value = "PYTHIA_1.4B")]
        PYTHIA14B = 54,

        /// <summary>
        /// Enum PYTHIA28B for value: PYTHIA_2.8B
        /// </summary>
        [EnumMember(Value = "PYTHIA_2.8B")]
        PYTHIA28B = 55,

        /// <summary>
        /// Enum PYTHIA69B for value: PYTHIA_6.9B
        /// </summary>
        [EnumMember(Value = "PYTHIA_6.9B")]
        PYTHIA69B = 56,

        /// <summary>
        /// Enum PYTHIA12B for value: PYTHIA_12B
        /// </summary>
        [EnumMember(Value = "PYTHIA_12B")]
        PYTHIA12B = 57,

        /// <summary>
        /// Enum MOSS7B for value: MOSS_7B
        /// </summary>
        [EnumMember(Value = "MOSS_7B")]
        MOSS7B = 58,

        /// <summary>
        /// Enum MOSS13B for value: MOSS_13B
        /// </summary>
        [EnumMember(Value = "MOSS_13B")]
        MOSS13B = 59,

        /// <summary>
        /// Enum RMKVLM100M for value: RMKV_LM_100M
        /// </summary>
        [EnumMember(Value = "RMKV_LM_100M")]
        RMKVLM100M = 60,

        /// <summary>
        /// Enum RMKVLM400M for value: RMKV_LM_400M
        /// </summary>
        [EnumMember(Value = "RMKV_LM_400M")]
        RMKVLM400M = 61,

        /// <summary>
        /// Enum RMKVLM15B for value: RMKV_LM_1.5B
        /// </summary>
        [EnumMember(Value = "RMKV_LM_1.5B")]
        RMKVLM15B = 62,

        /// <summary>
        /// Enum RMKVLM3B for value: RMKV_LM_3B
        /// </summary>
        [EnumMember(Value = "RMKV_LM_3B")]
        RMKVLM3B = 63,

        /// <summary>
        /// Enum RMKVLM7B for value: RMKV_LM_7B
        /// </summary>
        [EnumMember(Value = "RMKV_LM_7B")]
        RMKVLM7B = 64,

        /// <summary>
        /// Enum RMKVLM14B for value: RMKV_LM_14B
        /// </summary>
        [EnumMember(Value = "RMKV_LM_14B")]
        RMKVLM14B = 65,

        /// <summary>
        /// Enum STARCODER155B for value: STARCODER_15.5B
        /// </summary>
        [EnumMember(Value = "STARCODER_15.5B")]
        STARCODER155B = 66,

        /// <summary>
        /// Enum WIZARDCODER15B for value: WIZARDCODER_15B
        /// </summary>
        [EnumMember(Value = "WIZARDCODER_15B")]
        WIZARDCODER15B = 67,

        /// <summary>
        /// Enum SANTACODER11B for value: SANTACODER_1.1B
        /// </summary>
        [EnumMember(Value = "SANTACODER_1.1B")]
        SANTACODER11B = 68,

        /// <summary>
        /// Enum TEXTBISON for value: TEXT_BISON
        /// </summary>
        [EnumMember(Value = "TEXT_BISON")]
        TEXTBISON = 69,

        /// <summary>
        /// Enum TEXTEMBEDDINGGECKO for value: TEXTEMBEDDING_GECKO
        /// </summary>
        [EnumMember(Value = "TEXTEMBEDDING_GECKO")]
        TEXTEMBEDDINGGECKO = 70,

        /// <summary>
        /// Enum CHATBISON for value: CHAT_BISON
        /// </summary>
        [EnumMember(Value = "CHAT_BISON")]
        CHATBISON = 71,

        /// <summary>
        /// Enum CODEBISON for value: CODE_BISON
        /// </summary>
        [EnumMember(Value = "CODE_BISON")]
        CODEBISON = 72,

        /// <summary>
        /// Enum CODECHATBISON for value: CODECHAT_BISON
        /// </summary>
        [EnumMember(Value = "CODECHAT_BISON")]
        CODECHATBISON = 73,

        /// <summary>
        /// Enum CODEGECKO for value: CODE_GECKO
        /// </summary>
        [EnumMember(Value = "CODE_GECKO")]
        CODEGECKO = 74,

        /// <summary>
        /// Enum DISTILROBERTA for value: DISTILROBERTA
        /// </summary>
        [EnumMember(Value = "DISTILROBERTA")]
        DISTILROBERTA = 75,

        /// <summary>
        /// Enum MISTRAL7B for value: MISTRAL_7B
        /// </summary>
        [EnumMember(Value = "MISTRAL_7B")]
        MISTRAL7B = 76,

        /// <summary>
        /// Enum GEMINI for value: GEMINI
        /// </summary>
        [EnumMember(Value = "GEMINI")]
        GEMINI = 77,

        /// <summary>
        /// Enum GEMINI15 for value: GEMINI_1.5
        /// </summary>
        [EnumMember(Value = "GEMINI_1.5")]
        GEMINI15 = 78,

        /// <summary>
        /// Enum GEMINI2 for value: GEMINI_2
        /// </summary>
        [EnumMember(Value = "GEMINI_2")]
        GEMINI2 = 79,

        /// <summary>
        /// Enum FASTTEXT for value: FAST_TEXT
        /// </summary>
        [EnumMember(Value = "FAST_TEXT")]
        FASTTEXT = 80,

        /// <summary>
        /// Enum UNIXCODER for value: UNIXCODER
        /// </summary>
        [EnumMember(Value = "UNIXCODER")]
        UNIXCODER = 81,

        /// <summary>
        /// Enum PHI15 for value: PHI_1.5
        /// </summary>
        [EnumMember(Value = "PHI_1.5")]
        PHI15 = 82,

        /// <summary>
        /// Enum PHI2 for value: PHI_2
        /// </summary>
        [EnumMember(Value = "PHI_2")]
        PHI2 = 83,

        /// <summary>
        /// Enum MIXTRAL8X7B for value: MIXTRAL_8_x_7B
        /// </summary>
        [EnumMember(Value = "MIXTRAL_8_x_7B")]
        MIXTRAL8X7B = 84,

        /// <summary>
        /// Enum MIXTRAL8X22B for value: MIXTRAL_8_x_22B
        /// </summary>
        [EnumMember(Value = "MIXTRAL_8_x_22B")]
        MIXTRAL8X22B = 85,

        /// <summary>
        /// Enum GEMMA7B for value: GEMMA_7B
        /// </summary>
        [EnumMember(Value = "GEMMA_7B")]
        GEMMA7B = 86,

        /// <summary>
        /// Enum GEMMA2B for value: GEMMA_2B
        /// </summary>
        [EnumMember(Value = "GEMMA_2B")]
        GEMMA2B = 87,

        /// <summary>
        /// Enum CODEGEMMA7B for value: CODE_GEMMA_7B
        /// </summary>
        [EnumMember(Value = "CODE_GEMMA_7B")]
        CODEGEMMA7B = 88,

        /// <summary>
        /// Enum CODEGEMMA2B for value: CODE_GEMMA_2B
        /// </summary>
        [EnumMember(Value = "CODE_GEMMA_2B")]
        CODEGEMMA2B = 89,

        /// <summary>
        /// Enum RECURRENTGEMMA2B for value: RECURRENT_GEMMA_2B
        /// </summary>
        [EnumMember(Value = "RECURRENT_GEMMA_2B")]
        RECURRENTGEMMA2B = 90,

        /// <summary>
        /// Enum GROK1 for value: GROK_1
        /// </summary>
        [EnumMember(Value = "GROK_1")]
        GROK1 = 91,

        /// <summary>
        /// Enum GROK15 for value: GROK_1.5
        /// </summary>
        [EnumMember(Value = "GROK_1.5")]
        GROK15 = 92,

        /// <summary>
        /// Enum CLAUDE2 for value: CLAUDE_2
        /// </summary>
        [EnumMember(Value = "CLAUDE_2")]
        CLAUDE2 = 93,

        /// <summary>
        /// Enum CLAUDE3 for value: CLAUDE_3
        /// </summary>
        [EnumMember(Value = "CLAUDE_3")]
        CLAUDE3 = 94,

        /// <summary>
        /// Enum STARLING7B for value: STARLING_7B
        /// </summary>
        [EnumMember(Value = "STARLING_7B")]
        STARLING7B = 95,

        /// <summary>
        /// Enum DBRX for value: DBRX
        /// </summary>
        [EnumMember(Value = "DBRX")]
        DBRX = 96,

        /// <summary>
        /// Enum COMMANDR for value: COMMAND_R+
        /// </summary>
        [EnumMember(Value = "COMMAND_R+")]
        COMMANDR = 97,

        /// <summary>
        /// Enum GEMMA112B for value: GEMMA_1.1_2B
        /// </summary>
        [EnumMember(Value = "GEMMA_1.1_2B")]
        GEMMA112B = 98,

        /// <summary>
        /// Enum GEMMA117B for value: GEMMA_1.1_7B
        /// </summary>
        [EnumMember(Value = "GEMMA_1.1_7B")]
        GEMMA117B = 99,

        /// <summary>
        /// Enum GEMMA29B for value: GEMMA_2_9B
        /// </summary>
        [EnumMember(Value = "GEMMA_2_9B")]
        GEMMA29B = 100,

        /// <summary>
        /// Enum PHI3MINI for value: PHI_3_MINI
        /// </summary>
        [EnumMember(Value = "PHI_3_MINI")]
        PHI3MINI = 101,

        /// <summary>
        /// Enum PHI3SMALL for value: PHI_3_SMALL
        /// </summary>
        [EnumMember(Value = "PHI_3_SMALL")]
        PHI3SMALL = 102,

        /// <summary>
        /// Enum GRANITE3B for value: GRANITE_3B
        /// </summary>
        [EnumMember(Value = "GRANITE_3B")]
        GRANITE3B = 103,

        /// <summary>
        /// Enum GRANITE8B for value: GRANITE_8B
        /// </summary>
        [EnumMember(Value = "GRANITE_8B")]
        GRANITE8B = 104,

        /// <summary>
        /// Enum LLAMA38B for value: LLAMA_3_8B
        /// </summary>
        [EnumMember(Value = "LLAMA_3_8B")]
        LLAMA38B = 105,

        /// <summary>
        /// Enum CLAUDE35 for value: CLAUDE_3.5
        /// </summary>
        [EnumMember(Value = "CLAUDE_3.5")]
        CLAUDE35 = 106,

        /// <summary>
        /// Enum CLAUDELATEST for value: CLAUDE_LATEST
        /// </summary>
        [EnumMember(Value = "CLAUDE_LATEST")]
        CLAUDELATEST = 107,

        /// <summary>
        /// Enum GRANITELATEST for value: GRANITE_LATEST
        /// </summary>
        [EnumMember(Value = "GRANITE_LATEST")]
        GRANITELATEST = 108,

        /// <summary>
        /// Enum LLAMALATEST for value: LLAMA_LATEST
        /// </summary>
        [EnumMember(Value = "LLAMA_LATEST")]
        LLAMALATEST = 109,

        /// <summary>
        /// Enum PHILATEST for value: PHI_LATEST
        /// </summary>
        [EnumMember(Value = "PHI_LATEST")]
        PHILATEST = 110,

        /// <summary>
        /// Enum GEMMALATEST for value: GEMMA_LATEST
        /// </summary>
        [EnumMember(Value = "GEMMA_LATEST")]
        GEMMALATEST = 111,

        /// <summary>
        /// Enum GEMINILATEST for value: GEMINI_LATEST
        /// </summary>
        [EnumMember(Value = "GEMINI_LATEST")]
        GEMINILATEST = 112,

        /// <summary>
        /// Enum GPTLATEST for value: GPT_LATEST
        /// </summary>
        [EnumMember(Value = "GPT_LATEST")]
        GPTLATEST = 113,

        /// <summary>
        /// Enum AZURELATEST for value: AZURE_LATEST
        /// </summary>
        [EnumMember(Value = "AZURE_LATEST")]
        AZURELATEST = 114,

        /// <summary>
        /// Enum AZUREFAST for value: AZURE_FAST
        /// </summary>
        [EnumMember(Value = "AZURE_FAST")]
        AZUREFAST = 115,

        /// <summary>
        /// Enum AZUREBEST for value: AZURE_BEST
        /// </summary>
        [EnumMember(Value = "AZURE_BEST")]
        AZUREBEST = 116,

        /// <summary>
        /// Enum AZUREDEFAULT for value: AZURE_DEFAULT
        /// </summary>
        [EnumMember(Value = "AZURE_DEFAULT")]
        AZUREDEFAULT = 117,

        /// <summary>
        /// Enum AZURECUSTOM for value: AZURE_CUSTOM
        /// </summary>
        [EnumMember(Value = "AZURE_CUSTOM")]
        AZURECUSTOM = 118,

        /// <summary>
        /// Enum PERPLEXITYLATEST for value: PERPLEXITY_LATEST
        /// </summary>
        [EnumMember(Value = "PERPLEXITY_LATEST")]
        PERPLEXITYLATEST = 119,

        /// <summary>
        /// Enum PERPLEXITYFAST for value: PERPLEXITY_FAST
        /// </summary>
        [EnumMember(Value = "PERPLEXITY_FAST")]
        PERPLEXITYFAST = 120,

        /// <summary>
        /// Enum PERPLEXITYBEST for value: PERPLEXITY_BEST
        /// </summary>
        [EnumMember(Value = "PERPLEXITY_BEST")]
        PERPLEXITYBEST = 121,

        /// <summary>
        /// Enum PERPLEXITYDEFAULT for value: PERPLEXITY_DEFAULT
        /// </summary>
        [EnumMember(Value = "PERPLEXITY_DEFAULT")]
        PERPLEXITYDEFAULT = 122,

        /// <summary>
        /// Enum PERPLEXITYCUSTOM for value: PERPLEXITY_CUSTOM
        /// </summary>
        [EnumMember(Value = "PERPLEXITY_CUSTOM")]
        PERPLEXITYCUSTOM = 123,

        /// <summary>
        /// Enum CODESTRALLATEST for value: CODESTRAL_LATEST
        /// </summary>
        [EnumMember(Value = "CODESTRAL_LATEST")]
        CODESTRALLATEST = 124,

        /// <summary>
        /// Enum DEEPSEEKLATEST for value: DEEPSEEK_LATEST
        /// </summary>
        [EnumMember(Value = "DEEPSEEK_LATEST")]
        DEEPSEEKLATEST = 125,

        /// <summary>
        /// Enum LLAVALATEST for value: LLAVA_LATEST
        /// </summary>
        [EnumMember(Value = "LLAVA_LATEST")]
        LLAVALATEST = 126,

        /// <summary>
        /// Enum MIXTRALLATEST for value: MIXTRAL_LATEST
        /// </summary>
        [EnumMember(Value = "MIXTRAL_LATEST")]
        MIXTRALLATEST = 127,

        /// <summary>
        /// Enum MISTRALLATEST for value: MISTRAL_LATEST
        /// </summary>
        [EnumMember(Value = "MISTRAL_LATEST")]
        MISTRALLATEST = 128,

        /// <summary>
        /// Enum ORCALATEST for value: ORCA_LATEST
        /// </summary>
        [EnumMember(Value = "ORCA_LATEST")]
        ORCALATEST = 129,

        /// <summary>
        /// Enum QWENCODERLATEST for value: QWEN_CODER_LATEST
        /// </summary>
        [EnumMember(Value = "QWEN_CODER_LATEST")]
        QWENCODERLATEST = 130,

        /// <summary>
        /// Enum QWENLATEST for value: QWEN_LATEST
        /// </summary>
        [EnumMember(Value = "QWEN_LATEST")]
        QWENLATEST = 131,

        /// <summary>
        /// Enum QWQLATEST for value: QWQ_LATEST
        /// </summary>
        [EnumMember(Value = "QWQ_LATEST")]
        QWQLATEST = 132,

        /// <summary>
        /// Enum STARCODERLATEST for value: STARCODER_LATEST
        /// </summary>
        [EnumMember(Value = "STARCODER_LATEST")]
        STARCODERLATEST = 133,

        /// <summary>
        /// Enum TINYLLAMALATEST for value: TINYLLAMA_LATEST
        /// </summary>
        [EnumMember(Value = "TINYLLAMA_LATEST")]
        TINYLLAMALATEST = 134,

        /// <summary>
        /// Enum VICUNALATEST for value: VICUNA_LATEST
        /// </summary>
        [EnumMember(Value = "VICUNA_LATEST")]
        VICUNALATEST = 135,

        /// <summary>
        /// Enum WIZARDLATEST for value: WIZARD_LATEST
        /// </summary>
        [EnumMember(Value = "WIZARD_LATEST")]
        WIZARDLATEST = 136,

        /// <summary>
        /// Enum ZEPHYRLATEST for value: ZEPHYR_LATEST
        /// </summary>
        [EnumMember(Value = "ZEPHYR_LATEST")]
        ZEPHYRLATEST = 137,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 138
    }

}
