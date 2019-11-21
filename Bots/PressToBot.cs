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
            else if (turnContext.Activity.Text.ToLower().Contains("drinky time") || turnContext.Activity.Text.ToLower().Split()[1].Equals("drinky"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(DrinkyTime.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("wow"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(WowImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("pepe") || turnContext.Activity.Text.ToLower().Split()[1].Equals("sad"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(PepeImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("play decpacito") || turnContext.Activity.Text.ToLower().Split()[1].Equals("alexa"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(PepeImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("rip"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(RipImage.GetCard().ToAttachment());
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
                await turnContext.SendActivityAsync("Oh, boy, the things I can do are basically nonexistent. Try typing F or ask me if I'm  as smart as ai." +
                    "\n I can also do drinky time" +
                    "\n Shame" +
                    "\n Mah heart mah soul" +
                    "\n Noice" +
                    "\n I can help you when you're sad" +
                    "\n press b to blow" +
                    "\n Drinky time" +
                    "\n play decpacito" +
                    "\n Wow" +
                    "\n pepe" +
                    "\n rip");
            }

        }
    }
}
