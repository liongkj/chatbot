﻿using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using HRMain.Services;

namespace HRMain.Dialogs
{
    [LuisModel("8cae2784-c252-40a2-bd50-f7b116bf0b96", "c676993769164384a61525baed128771")]
    [Serializable]
    public class OrganizationDialog : LuisDialog<object>
    {
        [LuisIntent("Organization.DressCode")]
        public async Task DressCode(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(OrganizationService.GetDressCodeReply());
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Organization.Location")]
        public async Task Location(IDialogContext context, LuisResult result)
        {
            //await context.PostAsync(OrganizationService.GetLocationReply());
            context.Wait(this.MessageReceived);
        }
    }
}