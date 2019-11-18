using System.Collections.Generic;
using Microsoft.Bot.Schema;

namespace EchoBot
{
    public static class Card
    {
        public static VideoCard GetHeroCard()
        {
            VideoCard card = new VideoCard
            {
                Title = "Press F to Pay Respects",
                Text = "Respect has been paid",
                 Autoloop = true,
                 Autostart = true,
                 Media = new List<MediaUrl>()
            };
            card.Media.Add(new MediaUrl("https://thumbs.gfycat.com/SkeletalDependableAndeancat-mobile.mp4"));

            return card;
        }
    }

    public static class SomeCardImage
    {
        public static HeroCard GetHeroCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Press F to Pay Respects",
                Text = "Respect has been paid",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://media.gq.com/photos/55828d4fe52bc4b477a98493/master/w_1600%2Cc_limit/blogs-the-feed-call-of-duty-pay-f-to-pay-respects.jpg"));

            return card;
        }
    }
}
