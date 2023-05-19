﻿namespace AuctionSystem.Common.EmailSender.Interface
{
    using System.Threading.Tasks;

    public interface IEmailSender
    {
        Task<bool> SendEmailAsync(string sender, string receiver, string subject, string htmlMessage);
    }
}
