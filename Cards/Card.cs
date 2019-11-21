using System.Collections.Generic;
using Microsoft.Bot.Schema;

namespace EchoBot.Cards
{
    public static class Card
    {
        public static VideoCard GetCard()
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

    

    public static class PressFForRespectImage
    {
        public static HeroCard GetCard()
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

     public static class BToBlow
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Press B",
                Text = "You're blowing now",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://2eu.funnyjunk.com/comments/+_7e680de09f204a5d958816e973a9113f.jpg"));

            return card;
        }
    }



    public static class DrinkyTime
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Guess what time it is?",
                Text = "It's Drinky time!",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage("https://cdn.someecards.com/someecards/usercards/1333511646523_694452.png"));

            return card;
        }
    }



    public static class Shame
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Shame",
                Text = "Shame",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage("https://i.kym-cdn.com/photos/images/newsfeed/000/956/638/5bc.gif"));

            return card;
        }
    }

    public static class MahHeartMahSoul
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Mah Heart",
                Text = "Mah Soul",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage("https://discordemoji.com/assets/emoji/3142_noice.png"));

            return card;
        }
    }

    public static class NoiceImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Click",
                Text = "Noice",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://discordemoji.com/assets/emoji/3142_noice.png"));

            return card;
        }
    }
}
