﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EchoBot.Cards;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EchoBot.Dialogs
{
    public class PressToBot : ActivityHandler
    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
           if(turnContext.Activity.Text.ToLower().Contains("press f to get gif") || turnContext.Activity.Text.ToLower().Contains("f for gif"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(Card.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            } else if (turnContext.Activity.Text.ToLower().Contains("press f to pay respect") || turnContext.Activity.Text.Split()[1].Equals("F"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(PressFForRespectImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("noice") || turnContext.Activity.Text.ToLower().Split()[1].Equals("nice"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(NoiceImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("shame") || turnContext.Activity.Text.ToLower().Split()[1].Equals("shame"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(Shame.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("mah heart mah soul"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(MahHeartMahSoul.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("press b to blow") || turnContext.Activity.Text.ToLower().Split()[1].Equals("b"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(BToBlow.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("are you as smart as ai"))
            {
                await turnContext.SendActivityAsync("No, I am dumb AF");
            }
            else if (turnContext.Activity.Text.ToLower().Contains("i am sad"))
            {
                await turnContext.SendActivityAsync("Shut up, no one cares.");
            }
            else if (turnContext.Activity.Text.Split()[1].ToLower().Equals("help"))
            {
                await turnContext.SendActivityAsync("Oh, boy, the things I can do are basically nonexistent. Try typing F or ask me if I'm  as smart as ai.");
            }

        }
    }
}
