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
    public class TaskDialog : LuisDialog<object>
    {
        [LuisIntent("Task.Current")]
        public async Task Current(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(TaskService.GetCurrentReply());
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Task.Finish")]
        public async Task Finish(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(TaskService.GetFinishReply());
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Task.Next")]
        public async Task Next(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(TaskService.GetNextReply());
            context.Wait(this.MessageReceived);
        }
    }
}