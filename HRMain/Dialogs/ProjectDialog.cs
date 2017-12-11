using System;
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
    public class ProjectDialog : LuisDialog<object>
    {
        [LuisIntent("Project.Description")]
        public async Task Description(IDialogContext context, LuisResult result)
        {
            //await context.PostAsync(ProjectService.GetDescriptionReply(string projectName));
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Project.Duration")]
        public async Task Duration(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(ProjectService.GetDurationReply());
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Project.JobScope")]
        public async Task JobScope(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(ProjectService.GetJobScopeReply());
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Project.PersonInCharge")]
        public async Task PersonInCharge(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(ProjectService.GetPersonInChargeReply());
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Project.Phase")]
        public async Task Phase(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(ProjectService.GetPhaseReply());
            context.Wait(this.MessageReceived);
        }
    }
}