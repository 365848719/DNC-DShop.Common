﻿using DShop.Messages.Commands;
using DShop.Messages.Events;

namespace DShop.Common.RabbitMq
{
    public interface IBusSubscriber
    {
        IBusSubscriber SubscribeCommand<TCommand>(string exchangeName = null) where TCommand : ICommand;
        IBusSubscriber SubscribeEvent<TEvent>(string exchangeName = null) where TEvent : IEvent;
    }
}
