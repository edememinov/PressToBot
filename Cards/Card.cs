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
            card.Images.Add(new CardImage("https://i.redd.it/aovw63tjz2b31.jpg"));

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
            card.Images.Add(new CardImage("https://i.kym-cdn.com/photos/images/newsfeed/001/252/990/6f4.jpg"));

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
            card.Images.Add(new CardImage ("https://i.imgflip.com/1ldlyk.jpg"));

            return card;
        }
    } 
    
    public static class WowImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Wow!",
                Text = "*Wink*",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://i.imgflip.com/1n6h5z.jpg"));

            return card;
        }
    }    
    
    public static class RipImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Rest In Peace",
                Text = "Good bye cruel world",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://cdn.joke4fun.com/media/posts/00000/2wlp03e0pmkz.jpg"));

            return card;
        }
    } 
    
    public static class PepeImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Pepe",
                Text = "Sad",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://i.guim.co.uk/img/media/327e46c3ab049358fad80575146be9e0e65686e7/0_0_1023_742/master/1023.jpg?width=620&quality=85&auto=format&fit=max&s=9b376e2dc3089eef3e8ea73b776e58ff"));

            return card;
        }
    }
    
    public static class AlexaImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Alexa...",
                Text = "Play Despacito",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://meme.xyz/uploads/posts/t/l-38850-boohoo-let-me-play-you-despacito-on-the-worlds-smallest-alexa.jpg"));

            return card;
        }
    } 
    
    public static class StupidImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Bruh",
                Text = "You stupid",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://media.makeameme.org/created/are-you-stupid-5b7fdf.jpg"));

            return card;
        }
    }
    
    public static class DumbImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Why you so dumb?",
                Text = "That's stupid",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://sayingimages.com/wp-content/uploads/cant-look-dumb-meme.jpg"));

            return card;
        }
    }
    public static class ThankImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Seriously mate",
                Text = "Thanks",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://winkgo.com/wp-content/uploads/2019/10/thank-you-memes-10-720x393.jpg"));

            return card;
        }
    } 
    public static class ShameGotImage
    {
        public static HeroCard GetCard()
        {
            HeroCard card = new HeroCard
            {
                Title = "Shame!",
                Text = "Shame! Shame! Shame!",
                Images = new List<CardImage>()
            };
            card.Images.Add(new CardImage ("https://i.ytimg.com/vi/SrDSqODtEFM/hqdefault.jpg"));

            return card;
        }
    }
}
