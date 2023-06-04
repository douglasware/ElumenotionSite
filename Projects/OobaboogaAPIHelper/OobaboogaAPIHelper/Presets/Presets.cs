using static OobaboogaAPIHelper.ApiHelper;

namespace OobaboogaAPIHelper
{
    /// <summary>
    /// The embedded files were directly from the text-generation-webui\presets folder from the Oobabooga text-generation-webui GitHub repo.
    /// I did not create the presets or change them, and many aspects of them remain mysterious to me.
    /// I mostly use Default and LLaMAPrecise.
    /// </summary>
    public class Presets
    {
        public static GenerateRequestBody ContrastiveSearch { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("ContrastiveSearch"); } }
        public static GenerateRequestBody DebugDeterministic { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("DebugDeterministic"); } }
        public static GenerateRequestBody Default { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("Default"); } }
        public static GenerateRequestBody KoboldGodlike { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("KoboldGodlike"); } }
        public static GenerateRequestBody KoboldLiminalDrift { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("KoboldLiminalDrift"); } }
        public static GenerateRequestBody LLaMAPrecise { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("LLaMAPrecise"); } }
        public static GenerateRequestBody Naive { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("Naive"); } }
        public static GenerateRequestBody NovelAIBestGuess { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAIBestGuess"); } }
        public static GenerateRequestBody NovelAIDecadence { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAIDecadence"); } }
        public static GenerateRequestBody NovelAIGenesis { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAIGenesis"); } }
        public static GenerateRequestBody NovelAILycaenidae { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAILycaenidae"); } }
        public static GenerateRequestBody NovelAIOuroboros { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAIOuroboros"); } }
        public static GenerateRequestBody NovelAIPleasingResults { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAIPleasingResults"); } }
        public static GenerateRequestBody NovelAISphinxMoth { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAISphinxMoth"); } }
        public static GenerateRequestBody NovelAIStorywriter { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("NovelAIStorywriter"); } }
        public static GenerateRequestBody VerboseBeamSearch { get { return ModelParameters.FromEmbeddedResource<GenerateRequestBody>("VerboseBeamSearch"); } }
    }
}
