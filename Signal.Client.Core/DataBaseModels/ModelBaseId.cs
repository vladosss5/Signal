namespace Signal.Client.Core.DataBaseModels;

public class ModelBaseId
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
}