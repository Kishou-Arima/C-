using OpenAI_API;
  
var openAi = new OpenAIAPI("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");
var completions=openAi.Completions.CreateCompletionAsync
(
    prompt:"Write a poem on an MKIV Supra in the style of Rabindra Nath Tagore",
    model:"text-davinci-002",
    max_tokens:100
);

    foreach (var completion in completions.Result.Completions)
    {
        Console.Write(completion.Text);
    }


