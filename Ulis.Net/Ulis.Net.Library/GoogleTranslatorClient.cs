﻿using Google.Cloud.Translation.V2;
using System.Threading.Tasks;

namespace Ulis.Net.Library
{
    public class GoogleTranslatorClient : ITranslatorClient
    {
        private readonly TranslationClient _translationClient;

        public GoogleTranslatorClient(string subscriptionKey)
        {
            _translationClient = TranslationClient.CreateFromApiKey(subscriptionKey);
        }

        public async Task<string> TranslateAsync(string text)
        {
            var result = await _translationClient.TranslateTextAsync(text, LanguageCodes.English);
            return result.TranslatedText;
        }
    }
}