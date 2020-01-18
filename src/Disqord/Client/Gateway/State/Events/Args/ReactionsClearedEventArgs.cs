﻿using System.Collections.Generic;

namespace Disqord.Events
{
    public sealed class ReactionsClearedEventArgs : DiscordEventArgs
    {
        public CachedTextChannel Channel { get; }

        public OptionalSnowflakeEntity<CachedMessage> Message { get; }

        /// <summary>
        ///     Gets the cleared reactions.
        ///     If the message wasn't cached, was cached at a later point this will return incomplete or no entries.
        /// </summary>
        public IReadOnlyDictionary<IEmoji, ReactionData> Reactions { get; }

        internal ReactionsClearedEventArgs(
            CachedTextChannel channel,
            OptionalSnowflakeEntity<CachedMessage> message,
            IReadOnlyDictionary<IEmoji, ReactionData> reactions) : base(channel.Client)
        {
            Channel = channel;
            Message = message;
            Reactions = reactions;
        }
    }
}
