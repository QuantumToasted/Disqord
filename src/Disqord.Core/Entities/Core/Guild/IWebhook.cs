﻿using Disqord.Models;
using Disqord.Serialization.Json;

namespace Disqord
{
    /// <summary>
    ///     Represents a webhook.
    /// </summary>
    public interface IWebhook : ISnowflakeEntity, IChannelEntity, IGuildEntity, INamable, IJsonUpdatable<WebhookJsonModel>
    {
        /// <summary>
        ///     Gets the avatar image hash of this webhook.
        /// </summary>
        string AvatarHash { get; }

        /// <summary>
        ///     Gets the creator of this webhook.
        /// </summary>
        IUser Creator { get; }

        /// <summary>
        ///     Gets the token of this webhook.
        /// </summary>
        string Token { get; }

        /// <summary>
        ///     Gets the <see cref="WebhookType"/> of this webhook.
        /// </summary>
        WebhookType Type { get; }
    }
}