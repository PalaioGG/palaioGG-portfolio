using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDQ.Framework.Web.CssIcons
{
    public class GlyphSocialIcon : CssIcon<GlyphSocialIcon>
    {
        #region ENUM LIST
        public static GlyphSocialIcon Pinterest = new GlyphSocialIcon(GlyphSocial.Pinterest, "Pinterest", "pinterest");
        public static GlyphSocialIcon Dropbox = new GlyphSocialIcon(GlyphSocial.Dropbox, "Dropbox", "dropbox");
        public static GlyphSocialIcon GooglePlus = new GlyphSocialIcon(GlyphSocial.GooglePlus, "GooglePlus", "google-plus");
        public static GlyphSocialIcon Jolicloud = new GlyphSocialIcon(GlyphSocial.Jolicloud, "Jolicloud", "jolicloud");
        public static GlyphSocialIcon Yahoo = new GlyphSocialIcon(GlyphSocial.Yahoo, "Yahoo", "yahoo");
        public static GlyphSocialIcon Blogger = new GlyphSocialIcon(GlyphSocial.Blogger, "Blogger", "blogger");
        public static GlyphSocialIcon Picasa = new GlyphSocialIcon(GlyphSocial.Picasa, "Picasa", "picasa");
        public static GlyphSocialIcon Amazon = new GlyphSocialIcon(GlyphSocial.Amazon, "Amazon", "amazon");
        public static GlyphSocialIcon Tumblr = new GlyphSocialIcon(GlyphSocial.Tumblr, "Tumblr", "tumblr");
        public static GlyphSocialIcon Wordpress = new GlyphSocialIcon(GlyphSocial.Wordpress, "Wordpress", "wordpress");
        public static GlyphSocialIcon Instapaper = new GlyphSocialIcon(GlyphSocial.Instapaper, "Instapaper", "instapaper");
        public static GlyphSocialIcon Evernote = new GlyphSocialIcon(GlyphSocial.Evernote, "Evernote", "evernote");
        public static GlyphSocialIcon Xing = new GlyphSocialIcon(GlyphSocial.Xing, "Xing", "xing");
        public static GlyphSocialIcon Zootool = new GlyphSocialIcon(GlyphSocial.Zootool, "Zootool", "zootool");
        public static GlyphSocialIcon Dribbble = new GlyphSocialIcon(GlyphSocial.Dribbble, "Dribbble", "dribbble");
        public static GlyphSocialIcon Deviantart = new GlyphSocialIcon(GlyphSocial.Deviantart, "Deviantart", "deviantart");
        public static GlyphSocialIcon ReadItLater = new GlyphSocialIcon(GlyphSocial.ReadItLater, "ReadItLater", "read-it-later");
        public static GlyphSocialIcon LinkedIn = new GlyphSocialIcon(GlyphSocial.LinkedIn, "LinkedIn", "linked-in");
        public static GlyphSocialIcon Forrst = new GlyphSocialIcon(GlyphSocial.Forrst, "Forrst", "forrst");
        public static GlyphSocialIcon Pinboard = new GlyphSocialIcon(GlyphSocial.Pinboard, "Pinboard", "pinboard");
        public static GlyphSocialIcon Behance = new GlyphSocialIcon(GlyphSocial.Behance, "Behance", "behance");
        public static GlyphSocialIcon Github = new GlyphSocialIcon(GlyphSocial.Github, "Github", "github");
        public static GlyphSocialIcon Youtube = new GlyphSocialIcon(GlyphSocial.Youtube, "Youtube", "youtube");
        public static GlyphSocialIcon Skitch = new GlyphSocialIcon(GlyphSocial.Skitch, "Skitch", "skitch");
        public static GlyphSocialIcon Foursquare = new GlyphSocialIcon(GlyphSocial.Foursquare, "Foursquare", "foursquare");
        public static GlyphSocialIcon Quora = new GlyphSocialIcon(GlyphSocial.Quora, "Quora", "quora");
        public static GlyphSocialIcon Badoo = new GlyphSocialIcon(GlyphSocial.Badoo, "Badoo", "badoo");
        public static GlyphSocialIcon Spotify = new GlyphSocialIcon(GlyphSocial.Spotify, "Spotify", "spotify");
        public static GlyphSocialIcon Stumbleupon = new GlyphSocialIcon(GlyphSocial.Stumbleupon, "Stumbleupon", "stumbleupon");
        public static GlyphSocialIcon Readability = new GlyphSocialIcon(GlyphSocial.Readability, "Readability", "readability");
        public static GlyphSocialIcon Facebook = new GlyphSocialIcon(GlyphSocial.Facebook, "Facebook", "facebook");
        public static GlyphSocialIcon Twitter = new GlyphSocialIcon(GlyphSocial.Twitter, "Twitter", "twitter");
        public static GlyphSocialIcon Instagram = new GlyphSocialIcon(GlyphSocial.Instagram, "Instagram", "instagram");
        public static GlyphSocialIcon PosterousSpaces = new GlyphSocialIcon(GlyphSocial.PosterousSpaces, "PosterousSpaces", "posterous-spaces");
        public static GlyphSocialIcon Vimeo = new GlyphSocialIcon(GlyphSocial.Vimeo, "Vimeo", "vimeo");
        public static GlyphSocialIcon Flickr = new GlyphSocialIcon(GlyphSocial.Flickr, "Flickr", "flickr");
        public static GlyphSocialIcon LastFm = new GlyphSocialIcon(GlyphSocial.LastFm, "LastFm", "last-fm");
        public static GlyphSocialIcon Rss = new GlyphSocialIcon(GlyphSocial.Rss, "Rss", "rss");
        public static GlyphSocialIcon Skype = new GlyphSocialIcon(GlyphSocial.Skype, "Skype", "skype");
        public static GlyphSocialIcon Email = new GlyphSocialIcon(GlyphSocial.Email, "Email", "e-mail");
        public static GlyphSocialIcon Vine = new GlyphSocialIcon(GlyphSocial.Vine, "Vine", "vine");
        public static GlyphSocialIcon Myspace = new GlyphSocialIcon(GlyphSocial.Myspace, "Myspace", "myspace");
        public static GlyphSocialIcon Goodreads = new GlyphSocialIcon(GlyphSocial.Goodreads, "Goodreads", "goodreads");
        public static GlyphSocialIcon Apple = new GlyphSocialIcon(GlyphSocial.Apple, "Apple", "apple");
        public static GlyphSocialIcon Windows = new GlyphSocialIcon(GlyphSocial.Windows, "Windows", "windows");
        public static GlyphSocialIcon Yelp = new GlyphSocialIcon(GlyphSocial.Yelp, "Yelp", "yelp");
        public static GlyphSocialIcon Playstation = new GlyphSocialIcon(GlyphSocial.Playstation, "Playstation", "playstation");
        public static GlyphSocialIcon Xbox = new GlyphSocialIcon(GlyphSocial.Xbox, "Xbox", "xbox");
        public static GlyphSocialIcon Android = new GlyphSocialIcon(GlyphSocial.Android, "Android", "android");
        public static GlyphSocialIcon Ios = new GlyphSocialIcon(GlyphSocial.Ios, "Ios", "ios");
        public static GlyphSocialIcon Wikipedia = new GlyphSocialIcon(GlyphSocial.Wikipedia, "Wikipedia", "wikipedia");
        public static GlyphSocialIcon Pocket = new GlyphSocialIcon(GlyphSocial.Pocket, "Pocket", "pocket");
        public static GlyphSocialIcon Steam = new GlyphSocialIcon(GlyphSocial.Steam, "Steam", "steam");
        public static GlyphSocialIcon Souncloud = new GlyphSocialIcon(GlyphSocial.Souncloud, "Souncloud", "souncloud");
        public static GlyphSocialIcon Slideshare = new GlyphSocialIcon(GlyphSocial.Slideshare, "Slideshare", "slideshare");
        public static GlyphSocialIcon Netflix = new GlyphSocialIcon(GlyphSocial.Netflix, "Netflix", "netflix");
        public static GlyphSocialIcon Paypal = new GlyphSocialIcon(GlyphSocial.Paypal, "Paypal", "paypal");
        public static GlyphSocialIcon GoogleDrive = new GlyphSocialIcon(GlyphSocial.GoogleDrive, "GoogleDrive", "google-drive");
        public static GlyphSocialIcon LinuxFoundation = new GlyphSocialIcon(GlyphSocial.LinuxFoundation, "LinuxFoundation", "linux-foundation");
        public static GlyphSocialIcon Ebay = new GlyphSocialIcon(GlyphSocial.Ebay, "Ebay", "ebay");
        #endregion

        public GlyphSocialIcon(GlyphSocial value, string name, string cssName) : base(IconType.GlyphSocial, (int)value, name, cssName)
        {
        }

       
        public override string ToClass(FontScale scale)
        {
            switch (scale)
            {
                case FontScale.Small:
                    return "social-" + base.CssName + " x05";
                case FontScale.x2:
                    return "social-" + base.CssName + " x2";
                case FontScale.x3:
                    return "social-" + base.CssName + " x3";
                case FontScale.x4:
                    return "social-" + base.CssName + " x4";
                case FontScale.x5:
                    return "social-" + base.CssName + " x5";
                case FontScale.Default:
                default:
                    return "social-" + base.CssName;
            }
        }
    }
}
