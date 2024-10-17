using Pieces.Os.Core.SdkModel;

namespace Pieces.OS.Client.Copilot;

public enum Role
{
    System,
    User,
    Assistant
}

public static class RoleExtensions
{
    public static QGPTConversationMessageRoleEnum ToQGPTRole(this Role role) => role switch
    {
        Role.System => QGPTConversationMessageRoleEnum.SYSTEM,
        Role.User => QGPTConversationMessageRoleEnum.USER,
        Role.Assistant => QGPTConversationMessageRoleEnum.ASSISTANT,
        _ => throw new ArgumentException(nameof(role)),
    };
}