using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using HRMain.Services;
using static HRMain.Services.RootService;

namespace HRMain.Dialogs
{
    [LuisModel("8cae2784-c252-40a2-bd50-f7b116bf0b96", "c676993769164384a61525baed128771")]
    [Serializable]
    public class RootDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        [LuisIntent("")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(RootService.GetReply(RootReply.None));
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Root.Greeting")]
        public async Task Greeting(IDialogContext context, LuisResult result)
        {
            await context.PostAsync(RootService.GetReply(RootReply.Greeting));
            context.Wait(this.MessageReceived);
        }

        [LuisIntent("Project.Description")]
        [LuisIntent("Project.Duration")]
        [LuisIntent("Project.JobScope")]
        [LuisIntent("Project.PersonInCharge")]
        [LuisIntent("Project.Phase")]
        public async Task Project(IDialogContext context, LuisResult result)
        {
            context.Call(new ProjectDialog(), Others);
        }

        [LuisIntent("Task.Current")]
        [LuisIntent("Task.Finish")]
        [LuisIntent("Task.Next")]
        public async Task Task(IDialogContext context, LuisResult result)
        {
            context.Call(new TaskDialog(), Others);
        }

        [LuisIntent("Organization.DressCode")]
        [LuisIntent("Organization.Location")]
        public async Task Organization(IDialogContext context, LuisResult result)
        {
            context.Call(new OrganizationDialog(), Others);
        }

        [LuisIntent("Holiday.Next")]
        [LuisIntent("Holiday.Remaining")]
        public async Task Holiday(IDialogContext context, LuisResult result)
        {
            context.Call(new HolidayDialog(), Others);
        }

        [LuisIntent("People.Position")]
        public async Task People(IDialogContext context, LuisResult result)
        {
            context.Call(new PeopleDialog(), Others);
        }
        
        public virtual async Task Others(IDialogContext context, IAwaitable<object> response)
        {
            //To do something
            context.Done(this);
        }



    }
}