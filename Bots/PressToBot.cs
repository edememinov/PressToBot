using System.Collections.Generic;
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
                reply.Attachments.Add(Card.GetHeroCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            } else if (turnContext.Activity.Text.ToLower().Contains("press f to pay respect") || turnContext.Activity.Text.Split()[1].Equals("F"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(PressFForRespectImage.GetHeroCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("noice") || turnContext.Activity.Text.ToLower().Split()[1].Equals("nice"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(NoiceImage.GetNoiceCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("are you as smart as ai"))
            {
                await turnContext.SendActivityAsync("No, I am dumb AF");
            }
            else if (turnContext.Activity.Text.Split()[1].ToLower().Equals("help"))
            {
                await turnContext.SendActivityAsync("Oh, boy, the things I can do are basically nonexistent. Try typing F or ask me if I'm  as smart as ai.");
            }

        }
    }
}
