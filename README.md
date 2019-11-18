# PressToBot
Just press to bot

# Usage
Edit PressToBot.cs in Bots folder. 


``` C#

else if (turnContext.Activity.Text.ToLower().Contains("CONTAINS SOMETHING") || turnContext.Activity.Text.Split()[1].Equals("SECOND WORD EQUALS TO THIS"))
            {
                //Create Attachement
                var attachments = new List<Attachment>();
                //Create Reply
                var reply = MessageFactory.Attachment(attachments);
                // Add Hero Card (found in Card.cs) to the reply
                reply.Attachments.Add(SomeCardImage.GetHeroCard().ToAttachment());
                //Send reply to user
                await turnContext.SendActivityAsync(reply, cancellationToken);
            }

```
