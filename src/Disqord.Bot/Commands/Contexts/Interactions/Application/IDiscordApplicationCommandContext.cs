﻿namespace Disqord.Bot.Commands.Application;

/// <summary>
///     Represents an application command execution context.
/// </summary>
public interface IDiscordApplicationCommandContext : IDiscordInteractionCommandContext
{
    /// <summary>
    ///     Gets the interaction that triggered the command execution.
    /// </summary>
    new IApplicationCommandInteraction Interaction { get; }

    IInteraction IDiscordInteractionCommandContext.Interaction => Interaction;
}
