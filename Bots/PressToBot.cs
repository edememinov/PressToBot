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
           if(turnContext.Activity.Text.ToLower().Contains("press f to get gif") || turnContext.Activity.Text.Contains("F for gif"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(Card.GetHeroCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            } else if (turnContext.Activity.Text.ToLower().Contains("press f to pay respect") || turnContext.Activity.Text.Split()[1].Equals("F"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(SomeCardImage.GetHeroCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }

        }
    }
}
