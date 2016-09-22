using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDQ.Framework.Web.CssIcons
{
    public class GlyphHalflingIcon : CssIcon<GlyphHalflingIcon>
    {
        #region ENUM LIST
        public static GlyphHalflingIcon HandDown = new GlyphHalflingIcon(GlyphHalflings.HandDown, "HandDown", "hand-down");
        public static GlyphHalflingIcon CircleArrowRight = new GlyphHalflingIcon(GlyphHalflings.CircleArrowRight, "CircleArrowRight", "circle-arrow-right");
        public static GlyphHalflingIcon CircleArrowLeft = new GlyphHalflingIcon(GlyphHalflings.CircleArrowLeft, "CircleArrowLeft", "circle-arrow-left");
        public static GlyphHalflingIcon CircleArrowTop = new GlyphHalflingIcon(GlyphHalflings.CircleArrowTop, "CircleArrowTop", "circle-arrow-top");
        public static GlyphHalflingIcon CircleArrowDown = new GlyphHalflingIcon(GlyphHalflings.CircleArrowDown, "CircleArrowDown", "circle-arrow-down");
        public static GlyphHalflingIcon Globe = new GlyphHalflingIcon(GlyphHalflings.Globe, "Globe", "globe");
        public static GlyphHalflingIcon GlyphWrench = new GlyphHalflingIcon(GlyphHalflings.GlyphWrench, "GlyphWrench", "glyph-wrench");
        public static GlyphHalflingIcon Tasks = new GlyphHalflingIcon(GlyphHalflings.Tasks, "Tasks", "tasks");
        public static GlyphHalflingIcon Filter = new GlyphHalflingIcon(GlyphHalflings.Filter, "Filter", "filter");
        public static GlyphHalflingIcon GlyphBriefcase = new GlyphHalflingIcon(GlyphHalflings.GlyphBriefcase, "GlyphBriefcase", "glyph-briefcase");
        public static GlyphHalflingIcon Fullscreen = new GlyphHalflingIcon(GlyphHalflings.Fullscreen, "Fullscreen", "fullscreen");
        public static GlyphHalflingIcon Dashboard = new GlyphHalflingIcon(GlyphHalflings.Dashboard, "Dashboard", "dashboard");
        public static GlyphHalflingIcon GlyphPaperclip = new GlyphHalflingIcon(GlyphHalflings.GlyphPaperclip, "GlyphPaperclip", "glyph-paperclip");
        public static GlyphHalflingIcon HeartEmpty = new GlyphHalflingIcon(GlyphHalflings.HeartEmpty, "HeartEmpty", "heart-empty");
        public static GlyphHalflingIcon Link = new GlyphHalflingIcon(GlyphHalflings.Link, "Link", "link");
        public static GlyphHalflingIcon Phone = new GlyphHalflingIcon(GlyphHalflings.Phone, "Phone", "phone");
        public static GlyphHalflingIcon GlyphPushpin = new GlyphHalflingIcon(GlyphHalflings.GlyphPushpin, "GlyphPushpin", "glyph-pushpin");
        public static GlyphHalflingIcon Euro = new GlyphHalflingIcon(GlyphHalflings.Euro, "Euro", "euro");
        public static GlyphHalflingIcon Usd = new GlyphHalflingIcon(GlyphHalflings.Usd, "Usd", "usd");
        public static GlyphHalflingIcon Gbp = new GlyphHalflingIcon(GlyphHalflings.Gbp, "Gbp", "gbp");
        public static GlyphHalflingIcon Sort = new GlyphHalflingIcon(GlyphHalflings.Sort, "Sort", "sort");
        public static GlyphHalflingIcon SortByAlphabet = new GlyphHalflingIcon(GlyphHalflings.SortByAlphabet, "SortByAlphabet", "sort-by-alphabet");
        public static GlyphHalflingIcon SortByAlphabetAlt = new GlyphHalflingIcon(GlyphHalflings.SortByAlphabetAlt, "SortByAlphabetAlt", "sort-by-alphabet-alt");
        public static GlyphHalflingIcon SortByOrder = new GlyphHalflingIcon(GlyphHalflings.SortByOrder, "SortByOrder", "sort-by-order");
        public static GlyphHalflingIcon SortByOrderAlt = new GlyphHalflingIcon(GlyphHalflings.SortByOrderAlt, "SortByOrderAlt", "sort-by-order-alt");
        public static GlyphHalflingIcon SortByAttributes = new GlyphHalflingIcon(GlyphHalflings.SortByAttributes, "SortByAttributes", "sort-by-attributes");
        public static GlyphHalflingIcon SortByAttributesAlt = new GlyphHalflingIcon(GlyphHalflings.SortByAttributesAlt, "SortByAttributesAlt", "sort-by-attributes-alt");
        public static GlyphHalflingIcon Unchecked = new GlyphHalflingIcon(GlyphHalflings.Unchecked, "Unchecked", "unchecked");
        public static GlyphHalflingIcon Expand = new GlyphHalflingIcon(GlyphHalflings.Expand, "Expand", "expand");
        public static GlyphHalflingIcon Collapse = new GlyphHalflingIcon(GlyphHalflings.Collapse, "Collapse", "collapse");
        public static GlyphHalflingIcon CollapseTop = new GlyphHalflingIcon(GlyphHalflings.CollapseTop, "CollapseTop", "collapse-top");
        public static GlyphHalflingIcon LogIn = new GlyphHalflingIcon(GlyphHalflings.LogIn, "LogIn", "log-in");
        public static GlyphHalflingIcon Flash = new GlyphHalflingIcon(GlyphHalflings.Flash, "Flash", "flash");
        public static GlyphHalflingIcon LogOut = new GlyphHalflingIcon(GlyphHalflings.LogOut, "LogOut", "log-out");
        public static GlyphHalflingIcon NewWindow = new GlyphHalflingIcon(GlyphHalflings.NewWindow, "NewWindow", "new-window");
        public static GlyphHalflingIcon Record = new GlyphHalflingIcon(GlyphHalflings.Record, "Record", "record");
        public static GlyphHalflingIcon Save = new GlyphHalflingIcon(GlyphHalflings.Save, "Save", "save");
        public static GlyphHalflingIcon Open = new GlyphHalflingIcon(GlyphHalflings.Open, "Open", "open");
        public static GlyphHalflingIcon Saved = new GlyphHalflingIcon(GlyphHalflings.Saved, "Saved", "saved");
        public static GlyphHalflingIcon Import = new GlyphHalflingIcon(GlyphHalflings.Import, "Import", "import");
        public static GlyphHalflingIcon Export = new GlyphHalflingIcon(GlyphHalflings.Export, "Export", "export");
        public static GlyphHalflingIcon Send = new GlyphHalflingIcon(GlyphHalflings.Send, "Send", "send");
        public static GlyphHalflingIcon FloppyDisk = new GlyphHalflingIcon(GlyphHalflings.FloppyDisk, "FloppyDisk", "floppy-disk");
        public static GlyphHalflingIcon FloppySaved = new GlyphHalflingIcon(GlyphHalflings.FloppySaved, "FloppySaved", "floppy-saved");
        public static GlyphHalflingIcon FloppyRemove = new GlyphHalflingIcon(GlyphHalflings.FloppyRemove, "FloppyRemove", "floppy-remove");
        public static GlyphHalflingIcon FloppySave = new GlyphHalflingIcon(GlyphHalflings.FloppySave, "FloppySave", "floppy-save");
        public static GlyphHalflingIcon FloppyOpen = new GlyphHalflingIcon(GlyphHalflings.FloppyOpen, "FloppyOpen", "floppy-open");
        public static GlyphHalflingIcon CreditCard = new GlyphHalflingIcon(GlyphHalflings.CreditCard, "CreditCard", "credit-card");
        public static GlyphHalflingIcon Transfer = new GlyphHalflingIcon(GlyphHalflings.Transfer, "Transfer", "transfer");
        public static GlyphHalflingIcon Cutlery = new GlyphHalflingIcon(GlyphHalflings.Cutlery, "Cutlery", "cutlery");
        public static GlyphHalflingIcon Header = new GlyphHalflingIcon(GlyphHalflings.Header, "Header", "header");
        public static GlyphHalflingIcon Compressed = new GlyphHalflingIcon(GlyphHalflings.Compressed, "Compressed", "compressed");
        public static GlyphHalflingIcon Earphone = new GlyphHalflingIcon(GlyphHalflings.Earphone, "Earphone", "earphone");
        public static GlyphHalflingIcon PhoneAlt = new GlyphHalflingIcon(GlyphHalflings.PhoneAlt, "PhoneAlt", "phone-alt");
        public static GlyphHalflingIcon Tower = new GlyphHalflingIcon(GlyphHalflings.Tower, "Tower", "tower");
        public static GlyphHalflingIcon Stats = new GlyphHalflingIcon(GlyphHalflings.Stats, "Stats", "stats");
        public static GlyphHalflingIcon SdVideo = new GlyphHalflingIcon(GlyphHalflings.SdVideo, "SdVideo", "sd-video");
        public static GlyphHalflingIcon HdVideo = new GlyphHalflingIcon(GlyphHalflings.HdVideo, "HdVideo", "hd-video");
        public static GlyphHalflingIcon Subtitles = new GlyphHalflingIcon(GlyphHalflings.Subtitles, "Subtitles", "subtitles");
        public static GlyphHalflingIcon SoundStereo = new GlyphHalflingIcon(GlyphHalflings.SoundStereo, "SoundStereo", "sound-stereo");
        public static GlyphHalflingIcon SoundDolby = new GlyphHalflingIcon(GlyphHalflings.SoundDolby, "SoundDolby", "sound-dolby");
        public static GlyphHalflingIcon Sound51 = new GlyphHalflingIcon(GlyphHalflings.Sound51, "Sound51", "sound-5-1");
        public static GlyphHalflingIcon Sound61 = new GlyphHalflingIcon(GlyphHalflings.Sound61, "Sound61", "sound-6-1");
        public static GlyphHalflingIcon Sound71 = new GlyphHalflingIcon(GlyphHalflings.Sound71, "Sound71", "sound-7-1");
        public static GlyphHalflingIcon CopyrightMark = new GlyphHalflingIcon(GlyphHalflings.CopyrightMark, "CopyrightMark", "copyright-mark");
        public static GlyphHalflingIcon RegistrationMark = new GlyphHalflingIcon(GlyphHalflings.RegistrationMark, "RegistrationMark", "registration-mark");
        public static GlyphHalflingIcon Cloud = new GlyphHalflingIcon(GlyphHalflings.Cloud, "Cloud", "cloud");
        public static GlyphHalflingIcon CloudDownload = new GlyphHalflingIcon(GlyphHalflings.CloudDownload, "CloudDownload", "cloud-download");
        public static GlyphHalflingIcon CloudUpload = new GlyphHalflingIcon(GlyphHalflings.CloudUpload, "CloudUpload", "cloud-upload");
        public static GlyphHalflingIcon TreeConifer = new GlyphHalflingIcon(GlyphHalflings.TreeConifer, "TreeConifer", "tree-conifer");
        public static GlyphHalflingIcon TreeDeciduous = new GlyphHalflingIcon(GlyphHalflings.TreeDeciduous, "TreeDeciduous", "tree-deciduous");
        public static GlyphHalflingIcon Cd = new GlyphHalflingIcon(GlyphHalflings.Cd, "Cd", "cd");
        public static GlyphHalflingIcon SaveFile = new GlyphHalflingIcon(GlyphHalflings.SaveFile, "SaveFile", "save-file");
        public static GlyphHalflingIcon OpenFile = new GlyphHalflingIcon(GlyphHalflings.OpenFile, "OpenFile", "open-file");
        public static GlyphHalflingIcon LevelUp = new GlyphHalflingIcon(GlyphHalflings.LevelUp, "LevelUp", "level-up");
        public static GlyphHalflingIcon Copy = new GlyphHalflingIcon(GlyphHalflings.Copy, "Copy", "copy");
        public static GlyphHalflingIcon Paste = new GlyphHalflingIcon(GlyphHalflings.Paste, "Paste", "paste");
        public static GlyphHalflingIcon Door = new GlyphHalflingIcon(GlyphHalflings.Door, "Door", "door");
        public static GlyphHalflingIcon Key = new GlyphHalflingIcon(GlyphHalflings.Key, "Key", "key");
        public static GlyphHalflingIcon Alert = new GlyphHalflingIcon(GlyphHalflings.Alert, "Alert", "alert");
        public static GlyphHalflingIcon Equalizer = new GlyphHalflingIcon(GlyphHalflings.Equalizer, "Equalizer", "equalizer");
        public static GlyphHalflingIcon King = new GlyphHalflingIcon(GlyphHalflings.King, "King", "king");
        public static GlyphHalflingIcon Queen = new GlyphHalflingIcon(GlyphHalflings.Queen, "Queen", "queen");
        public static GlyphHalflingIcon Pawn = new GlyphHalflingIcon(GlyphHalflings.Pawn, "Pawn", "pawn");
        public static GlyphHalflingIcon Bishop = new GlyphHalflingIcon(GlyphHalflings.Bishop, "Bishop", "bishop");
        public static GlyphHalflingIcon Knight = new GlyphHalflingIcon(GlyphHalflings.Knight, "Knight", "knight");
        public static GlyphHalflingIcon BabyFormula = new GlyphHalflingIcon(GlyphHalflings.BabyFormula, "BabyFormula", "baby-formula");
        public static GlyphHalflingIcon Tent = new GlyphHalflingIcon(GlyphHalflings.Tent, "Tent", "tent");
        public static GlyphHalflingIcon Blackboard = new GlyphHalflingIcon(GlyphHalflings.Blackboard, "Blackboard", "blackboard");
        public static GlyphHalflingIcon Bed = new GlyphHalflingIcon(GlyphHalflings.Bed, "Bed", "bed");
        public static GlyphHalflingIcon Apple = new GlyphHalflingIcon(GlyphHalflings.Apple, "Apple", "apple");
        public static GlyphHalflingIcon Erase = new GlyphHalflingIcon(GlyphHalflings.Erase, "Erase", "erase");
        public static GlyphHalflingIcon Hourglass = new GlyphHalflingIcon(GlyphHalflings.Hourglass, "Hourglass", "hourglass");
        public static GlyphHalflingIcon Lamp = new GlyphHalflingIcon(GlyphHalflings.Lamp, "Lamp", "lamp");
        public static GlyphHalflingIcon Duplicate = new GlyphHalflingIcon(GlyphHalflings.Duplicate, "Duplicate", "duplicate");
        public static GlyphHalflingIcon PiggyBank = new GlyphHalflingIcon(GlyphHalflings.PiggyBank, "PiggyBank", "piggy-bank");
        public static GlyphHalflingIcon Scissors = new GlyphHalflingIcon(GlyphHalflings.Scissors, "Scissors", "scissors");
        public static GlyphHalflingIcon Bitcoin = new GlyphHalflingIcon(GlyphHalflings.Bitcoin, "Bitcoin", "bitcoin");
        public static GlyphHalflingIcon Yen = new GlyphHalflingIcon(GlyphHalflings.Yen, "Yen", "yen");
        public static GlyphHalflingIcon Ruble = new GlyphHalflingIcon(GlyphHalflings.Ruble, "Ruble", "ruble");
        public static GlyphHalflingIcon Scale = new GlyphHalflingIcon(GlyphHalflings.Scale, "Scale", "scale");
        public static GlyphHalflingIcon IceLolly = new GlyphHalflingIcon(GlyphHalflings.IceLolly, "IceLolly", "ice-lolly");
        public static GlyphHalflingIcon IceLollyTasted = new GlyphHalflingIcon(GlyphHalflings.IceLollyTasted, "IceLollyTasted", "ice-lolly-tasted");
        public static GlyphHalflingIcon Education = new GlyphHalflingIcon(GlyphHalflings.Education, "Education", "education");
        public static GlyphHalflingIcon OptionHorizontal = new GlyphHalflingIcon(GlyphHalflings.OptionHorizontal, "OptionHorizontal", "option-horizontal");
        public static GlyphHalflingIcon OptionVertical = new GlyphHalflingIcon(GlyphHalflings.OptionVertical, "OptionVertical", "option-vertical");
        public static GlyphHalflingIcon MenuHamburger = new GlyphHalflingIcon(GlyphHalflings.MenuHamburger, "MenuHamburger", "menu-hamburger");
        public static GlyphHalflingIcon ModalWindow = new GlyphHalflingIcon(GlyphHalflings.ModalWindow, "ModalWindow", "modal-window");
        public static GlyphHalflingIcon Oil = new GlyphHalflingIcon(GlyphHalflings.Oil, "Oil", "oil");
        public static GlyphHalflingIcon Grain = new GlyphHalflingIcon(GlyphHalflings.Grain, "Grain", "grain");
        public static GlyphHalflingIcon Sunglasses = new GlyphHalflingIcon(GlyphHalflings.Sunglasses, "Sunglasses", "sunglasses");
        public static GlyphHalflingIcon TextSize = new GlyphHalflingIcon(GlyphHalflings.TextSize, "TextSize", "text-size");
        public static GlyphHalflingIcon TextColor = new GlyphHalflingIcon(GlyphHalflings.TextColor, "TextColor", "text-color");
        public static GlyphHalflingIcon TextBackground = new GlyphHalflingIcon(GlyphHalflings.TextBackground, "TextBackground", "text-background");
        public static GlyphHalflingIcon ObjectAlignTop = new GlyphHalflingIcon(GlyphHalflings.ObjectAlignTop, "ObjectAlignTop", "object-align-top");
        public static GlyphHalflingIcon ObjectAlignBottom = new GlyphHalflingIcon(GlyphHalflings.ObjectAlignBottom, "ObjectAlignBottom", "object-align-bottom");
        public static GlyphHalflingIcon ObjectAlignHorizontal = new GlyphHalflingIcon(GlyphHalflings.ObjectAlignHorizontal, "ObjectAlignHorizontal", "object-align-horizontal");
        public static GlyphHalflingIcon ObjectAlignLeft = new GlyphHalflingIcon(GlyphHalflings.ObjectAlignLeft, "ObjectAlignLeft", "object-align-left");
        public static GlyphHalflingIcon ObjectAlignVertical = new GlyphHalflingIcon(GlyphHalflings.ObjectAlignVertical, "ObjectAlignVertical", "object-align-vertical");
        public static GlyphHalflingIcon ObjectAlignRight = new GlyphHalflingIcon(GlyphHalflings.ObjectAlignRight, "ObjectAlignRight", "object-align-right");
        public static GlyphHalflingIcon TriangleRight = new GlyphHalflingIcon(GlyphHalflings.TriangleRight, "TriangleRight", "triangle-right");
        public static GlyphHalflingIcon TriangleLeft = new GlyphHalflingIcon(GlyphHalflings.TriangleLeft, "TriangleLeft", "triangle-left");
        public static GlyphHalflingIcon TriangleBottom = new GlyphHalflingIcon(GlyphHalflings.TriangleBottom, "TriangleBottom", "triangle-bottom");
        public static GlyphHalflingIcon TriangleTop = new GlyphHalflingIcon(GlyphHalflings.TriangleTop, "TriangleTop", "triangle-top");
        public static GlyphHalflingIcon Terminal = new GlyphHalflingIcon(GlyphHalflings.Terminal, "Terminal", "terminal");
        public static GlyphHalflingIcon Superscript = new GlyphHalflingIcon(GlyphHalflings.Superscript, "Superscript", "superscript");
        public static GlyphHalflingIcon Subscript = new GlyphHalflingIcon(GlyphHalflings.Subscript, "Subscript", "subscript");
        public static GlyphHalflingIcon MenuLeft = new GlyphHalflingIcon(GlyphHalflings.MenuLeft, "MenuLeft", "menu-left");
        public static GlyphHalflingIcon MenuRight = new GlyphHalflingIcon(GlyphHalflings.MenuRight, "MenuRight", "menu-right");
        public static GlyphHalflingIcon MenuDown = new GlyphHalflingIcon(GlyphHalflings.MenuDown, "MenuDown", "menu-down");
        public static GlyphHalflingIcon MenuUp = new GlyphHalflingIcon(GlyphHalflings.MenuUp, "MenuUp", "menu-up");
        #endregion

        public GlyphHalflingIcon(GlyphHalflings value, string name, string cssName) : base(IconType.GlyphHalfling, (int)value, name, cssName)
        {
        }

        public override string ToClass(FontScale scale)
        {
            switch (scale)
            {
                case FontScale.Small:
                    return "halflings-" + base.CssName + " x05";
                case FontScale.x2:
                    return "halflings-" + base.CssName + " x2";
                case FontScale.x3:
                    return "halflings-" + base.CssName + " x3";
                case FontScale.x4:
                    return "halflings-" + base.CssName + " x4";
                case FontScale.x5:
                    return "halflings-" + base.CssName + " x5";
                case FontScale.x6:
                    return "halflings-" + base.CssName + " x6";
                case FontScale.x7:
                    return "halflings-" + base.CssName + " x7";
                case FontScale.x8:
                    return "halflings-" + base.CssName + " x8";
                case FontScale.Default:
                default:
                    return "halflings-" + base.CssName;
            }
        }
    }
}
