﻿namespace AuctionSystem.Web.SignalRHubs
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.SignalR;
    using Services.Interfaces;
    using Services.Models.Bid;
    using Services.Models.Item;

    public class BidHub : Hub
    {
        private readonly IBidService bidService;
        private readonly IItemsService itemsService;

        public BidHub(IBidService bidService, IItemsService itemsService)
        {
            this.bidService = bidService;
            this.itemsService = itemsService;
        }

        public async Task Setup(string consoleId)
        {
            if (consoleId == null)
            {
                return;
            }

            await this.Groups.AddToGroupAsync(this.Context.ConnectionId, consoleId);
        }

        [Authorize]
        public async Task CreateBidAsync(decimal bidAmount, string consoleId)
        {
            if (consoleId == null)
            {
                return;
            }

            var item = await this.itemsService.GetByIdAsync<ItemDetailsServiceModel>(consoleId);

            if (item == null)
            {
                return;
            }

            var canBid = this.bidService.CanBid(item);

            if (!canBid || item.StartingPrice > bidAmount)
            {
                return;
            }

            var userId = this.Context.UserIdentifier;
            var serviceModel = new BidCreateServiceModel
            {
                Amount = bidAmount,
                MadeOn = DateTime.UtcNow,
                ItemId = item.Id,
                UserId = userId
            };

            var isSucceeded = await this.bidService.CreateBidAsync(serviceModel);

            if (!isSucceeded)
            {
                return;
            }

            await this.Clients.Groups(consoleId).SendAsync("ReceivedMessage", bidAmount, userId);
        }
    }
}