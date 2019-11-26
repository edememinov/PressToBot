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
            else if (turnContext.Activity.Text.ToLower().Split()[1].Equals("noice") || turnContext.Activity.Text.ToLower().Split()[1].Equals("nice"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(NoiceImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("that's a shame") || turnContext.Activity.Text.ToLower().Contains("that is a shame"))
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
            else if (turnContext.Activity.Text.ToLower().Split()[1].Equals("wow"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(WowImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Split()[1].Equals("pepe") || turnContext.Activity.Text.ToLower().Split()[1].Equals("sad"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(PepeImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("play despacito") || turnContext.Activity.Text.ToLower().Split()[1].Equals("alexa"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(AlexaImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("you're stupid") || turnContext.Activity.Text.ToLower().Split()[1].Equals("stupid") || turnContext.Activity.Text.ToLower().Contains("you are stupid"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(StupidImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Split()[1].Equals("rip"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(RipImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Split()[1].Equals("thanks"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(ThankImage.GetCard().ToAttachment());
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }
            else if (turnContext.Activity.Text.ToLower().Contains("is dumb"))
            {
                var attachments = new List<Attachment>();
                var reply = MessageFactory.Attachment(attachments);
                reply.Attachments.Add(DumbImage.GetCard().ToAttachment());
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
                    "\n I can also do drinky time." +
                    "\n That's a shame." +
                    "\n You should be ashamed of yourself" +
                    "\n Mah heart mah soul." +
                    "\n Noice." +
                    "\n I can help you when you're sad." +
                    "\n Press b to blow." +
                    "\n Drinky time." +
                    "\n Play decpacito." +
                    "\n Wow." +
                    "\n Pepe." +
                    "\n Rip." +
                    "\n Thank you.");
            }
            else if (turnContext.Activity.Text.Split().Length > 3)
            {
                if (turnContext.Activity.Text.ToLower().Contains("be ashamed of yourself") || turnContext.Activity.Text.ToLower().Split()[3].Equals("ashamed"))
                {
                    var attachments = new List<Attachment>();
                    var reply = MessageFactory.Attachment(attachments);
                    reply.Attachments.Add(ShameGotImage.GetCard().ToAttachment());
                    await turnContext.SendActivityAsync(reply, cancellationToken);
                }
            }
            

        }
    }
}
