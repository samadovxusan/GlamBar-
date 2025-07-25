namespace GlamBar.Domain.Common.Commands;

public struct CommandOptions()
{
    public bool SkipSaveChanges { get; set; } = false;

    public CommandOptions(bool skipSaveChanges) : this() => SkipSaveChanges = skipSaveChanges;
}