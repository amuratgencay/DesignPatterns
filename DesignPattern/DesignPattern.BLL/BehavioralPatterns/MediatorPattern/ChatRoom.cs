using System;
using System.Collections.Generic;
using DesignPattern.Entity.BehavioralPatterns.MediatorPattern;

namespace DesignPattern.BLL.BehavioralPatterns.MediatorPattern
{
    public class ChatRoom : IChatRoom
    {
        private readonly Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public void Register(Participant participant)
        {
            if (!_participants.ContainsKey(participant.Name))
                _participants.Add(participant.Name, participant);
            participant.ChatRoom = this;
        }

        public void Send(Participant from, Participant to, string message)
        {
            if (_participants.ContainsKey(from) && _participants.ContainsKey(to))
                _participants[to.Name].Receive(from, message);
            else
                throw new ArgumentOutOfRangeException($"{from} not participant!");
        }

        public void Register(params Participant[] participants)
        {
            foreach (var participant in participants) Register(participant);
        }
    }
}