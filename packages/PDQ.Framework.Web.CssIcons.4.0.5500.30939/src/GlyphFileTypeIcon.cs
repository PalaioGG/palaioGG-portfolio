using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDQ.Framework.Web.CssIcons
{
    public class GlyphFileTypeIcon : CssIcon<GlyphFileTypeIcon>
    {
        #region ENUM LIST
        public static GlyphFileTypeIcon Txt = new GlyphFileTypeIcon(GlyphFileTypes.Txt, "Txt", "txt");
        public static GlyphFileTypeIcon Doc = new GlyphFileTypeIcon(GlyphFileTypes.Doc, "Doc", "doc");
        public static GlyphFileTypeIcon Rtf = new GlyphFileTypeIcon(GlyphFileTypes.Rtf, "Rtf", "rtf");
        public static GlyphFileTypeIcon Log = new GlyphFileTypeIcon(GlyphFileTypes.Log, "Log", "log");
        public static GlyphFileTypeIcon Tex = new GlyphFileTypeIcon(GlyphFileTypes.Tex, "Tex", "tex");
        public static GlyphFileTypeIcon Msg = new GlyphFileTypeIcon(GlyphFileTypes.Msg, "Msg", "msg");
        public static GlyphFileTypeIcon Text = new GlyphFileTypeIcon(GlyphFileTypes.Text, "Text", "text");
        public static GlyphFileTypeIcon Wpd = new GlyphFileTypeIcon(GlyphFileTypes.Wpd, "Wpd", "wpd");
        public static GlyphFileTypeIcon Wps = new GlyphFileTypeIcon(GlyphFileTypes.Wps, "Wps", "wps");
        public static GlyphFileTypeIcon Docx = new GlyphFileTypeIcon(GlyphFileTypes.Docx, "Docx", "docx");
        public static GlyphFileTypeIcon Page = new GlyphFileTypeIcon(GlyphFileTypes.Page, "Page", "page");
        public static GlyphFileTypeIcon Csv = new GlyphFileTypeIcon(GlyphFileTypes.Csv, "Csv", "csv");
        public static GlyphFileTypeIcon Dat = new GlyphFileTypeIcon(GlyphFileTypes.Dat, "Dat", "dat");
        public static GlyphFileTypeIcon Tar = new GlyphFileTypeIcon(GlyphFileTypes.Tar, "Tar", "tar");
        public static GlyphFileTypeIcon Xml = new GlyphFileTypeIcon(GlyphFileTypes.Xml, "Xml", "xml");
        public static GlyphFileTypeIcon Vcf = new GlyphFileTypeIcon(GlyphFileTypes.Vcf, "Vcf", "vcf");
        public static GlyphFileTypeIcon Pps = new GlyphFileTypeIcon(GlyphFileTypes.Pps, "Pps", "pps");
        public static GlyphFileTypeIcon Key = new GlyphFileTypeIcon(GlyphFileTypes.Key, "Key", "key");
        public static GlyphFileTypeIcon Ppt = new GlyphFileTypeIcon(GlyphFileTypes.Ppt, "Ppt", "ppt");
        public static GlyphFileTypeIcon Pptx = new GlyphFileTypeIcon(GlyphFileTypes.Pptx, "Pptx", "pptx");
        public static GlyphFileTypeIcon Sdf = new GlyphFileTypeIcon(GlyphFileTypes.Sdf, "Sdf", "sdf");
        public static GlyphFileTypeIcon Gbr = new GlyphFileTypeIcon(GlyphFileTypes.Gbr, "Gbr", "gbr");
        public static GlyphFileTypeIcon Ged = new GlyphFileTypeIcon(GlyphFileTypes.Ged, "Ged", "ged");
        public static GlyphFileTypeIcon Mp3 = new GlyphFileTypeIcon(GlyphFileTypes.Mp3, "Mp3", "mp3");
        public static GlyphFileTypeIcon M4a = new GlyphFileTypeIcon(GlyphFileTypes.M4a, "M4a", "m4a");
        public static GlyphFileTypeIcon Waw = new GlyphFileTypeIcon(GlyphFileTypes.Waw, "Waw", "waw");
        public static GlyphFileTypeIcon Wma = new GlyphFileTypeIcon(GlyphFileTypes.Wma, "Wma", "wma");
        public static GlyphFileTypeIcon Mpa = new GlyphFileTypeIcon(GlyphFileTypes.Mpa, "Mpa", "mpa");
        public static GlyphFileTypeIcon Iff = new GlyphFileTypeIcon(GlyphFileTypes.Iff, "Iff", "iff");
        public static GlyphFileTypeIcon Aif = new GlyphFileTypeIcon(GlyphFileTypes.Aif, "Aif", "aif");
        public static GlyphFileTypeIcon Ra = new GlyphFileTypeIcon(GlyphFileTypes.Ra, "Ra", "ra");
        public static GlyphFileTypeIcon Mid = new GlyphFileTypeIcon(GlyphFileTypes.Mid, "Mid", "mid");
        public static GlyphFileTypeIcon M3v = new GlyphFileTypeIcon(GlyphFileTypes.M3v, "M3v", "m3v");
        public static GlyphFileTypeIcon E3gp = new GlyphFileTypeIcon(GlyphFileTypes.E3gp, "E3gp", "e-3gp");
        public static GlyphFileTypeIcon Shf = new GlyphFileTypeIcon(GlyphFileTypes.Shf, "Shf", "shf");
        public static GlyphFileTypeIcon Avi = new GlyphFileTypeIcon(GlyphFileTypes.Avi, "Avi", "avi");
        public static GlyphFileTypeIcon Asx = new GlyphFileTypeIcon(GlyphFileTypes.Asx, "Asx", "asx");
        public static GlyphFileTypeIcon Mp4 = new GlyphFileTypeIcon(GlyphFileTypes.Mp4, "Mp4", "mp4");
        public static GlyphFileTypeIcon E3g2 = new GlyphFileTypeIcon(GlyphFileTypes.E3g2, "E3g2", "e-3g2");
        public static GlyphFileTypeIcon Mpg = new GlyphFileTypeIcon(GlyphFileTypes.Mpg, "Mpg", "mpg");
        public static GlyphFileTypeIcon Asf = new GlyphFileTypeIcon(GlyphFileTypes.Asf, "Asf", "asf");
        public static GlyphFileTypeIcon Vob = new GlyphFileTypeIcon(GlyphFileTypes.Vob, "Vob", "vob");
        public static GlyphFileTypeIcon Wmv = new GlyphFileTypeIcon(GlyphFileTypes.Wmv, "Wmv", "wmv");
        public static GlyphFileTypeIcon Mov = new GlyphFileTypeIcon(GlyphFileTypes.Mov, "Mov", "mov");
        public static GlyphFileTypeIcon Srt = new GlyphFileTypeIcon(GlyphFileTypes.Srt, "Srt", "srt");
        public static GlyphFileTypeIcon M4v = new GlyphFileTypeIcon(GlyphFileTypes.M4v, "M4v", "m4v");
        public static GlyphFileTypeIcon Flv = new GlyphFileTypeIcon(GlyphFileTypes.Flv, "Flv", "flv");
        public static GlyphFileTypeIcon Rm = new GlyphFileTypeIcon(GlyphFileTypes.Rm, "Rm", "rm");
        public static GlyphFileTypeIcon Png = new GlyphFileTypeIcon(GlyphFileTypes.Png, "Png", "png");
        public static GlyphFileTypeIcon Psd = new GlyphFileTypeIcon(GlyphFileTypes.Psd, "Psd", "psd");
        public static GlyphFileTypeIcon Psp = new GlyphFileTypeIcon(GlyphFileTypes.Psp, "Psp", "psp");
        public static GlyphFileTypeIcon Jpg = new GlyphFileTypeIcon(GlyphFileTypes.Jpg, "Jpg", "jpg");
        public static GlyphFileTypeIcon Tif = new GlyphFileTypeIcon(GlyphFileTypes.Tif, "Tif", "tif");
        public static GlyphFileTypeIcon Tiff = new GlyphFileTypeIcon(GlyphFileTypes.Tiff, "Tiff", "tiff");
        public static GlyphFileTypeIcon Gif = new GlyphFileTypeIcon(GlyphFileTypes.Gif, "Gif", "gif");
        public static GlyphFileTypeIcon Bmp = new GlyphFileTypeIcon(GlyphFileTypes.Bmp, "Bmp", "bmp");
        public static GlyphFileTypeIcon Tga = new GlyphFileTypeIcon(GlyphFileTypes.Tga, "Tga", "tga");
        public static GlyphFileTypeIcon Thm = new GlyphFileTypeIcon(GlyphFileTypes.Thm, "Thm", "thm");
        public static GlyphFileTypeIcon Yuv = new GlyphFileTypeIcon(GlyphFileTypes.Yuv, "Yuv", "yuv");
        public static GlyphFileTypeIcon Dds = new GlyphFileTypeIcon(GlyphFileTypes.Dds, "Dds", "dds");
        public static GlyphFileTypeIcon Ai = new GlyphFileTypeIcon(GlyphFileTypes.Ai, "Ai", "ai");
        public static GlyphFileTypeIcon Eps = new GlyphFileTypeIcon(GlyphFileTypes.Eps, "Eps", "eps");
        public static GlyphFileTypeIcon Ps = new GlyphFileTypeIcon(GlyphFileTypes.Ps, "Ps", "ps");
        public static GlyphFileTypeIcon Svg = new GlyphFileTypeIcon(GlyphFileTypes.Svg, "Svg", "svg");
        public static GlyphFileTypeIcon Pdf = new GlyphFileTypeIcon(GlyphFileTypes.Pdf, "Pdf", "pdf");
        public static GlyphFileTypeIcon Pct = new GlyphFileTypeIcon(GlyphFileTypes.Pct, "Pct", "pct");
        public static GlyphFileTypeIcon Indd = new GlyphFileTypeIcon(GlyphFileTypes.Indd, "Indd", "indd");
        public static GlyphFileTypeIcon Xlr = new GlyphFileTypeIcon(GlyphFileTypes.Xlr, "Xlr", "xlr");
        public static GlyphFileTypeIcon Xls = new GlyphFileTypeIcon(GlyphFileTypes.Xls, "Xls", "xls");
        public static GlyphFileTypeIcon Xlsx = new GlyphFileTypeIcon(GlyphFileTypes.Xlsx, "Xlsx", "xlsx");
        public static GlyphFileTypeIcon Db = new GlyphFileTypeIcon(GlyphFileTypes.Db, "Db", "db");
        public static GlyphFileTypeIcon Dbf = new GlyphFileTypeIcon(GlyphFileTypes.Dbf, "Dbf", "dbf");
        public static GlyphFileTypeIcon Mdb = new GlyphFileTypeIcon(GlyphFileTypes.Mdb, "Mdb", "mdb");
        public static GlyphFileTypeIcon Pdb = new GlyphFileTypeIcon(GlyphFileTypes.Pdb, "Pdb", "pdb");
        public static GlyphFileTypeIcon Sql = new GlyphFileTypeIcon(GlyphFileTypes.Sql, "Sql", "sql");
        public static GlyphFileTypeIcon Aacd = new GlyphFileTypeIcon(GlyphFileTypes.Aacd, "Aacd", "aacd");
        public static GlyphFileTypeIcon App = new GlyphFileTypeIcon(GlyphFileTypes.App, "App", "app");
        public static GlyphFileTypeIcon Exe = new GlyphFileTypeIcon(GlyphFileTypes.Exe, "Exe", "exe");
        public static GlyphFileTypeIcon Com = new GlyphFileTypeIcon(GlyphFileTypes.Com, "Com", "com");
        public static GlyphFileTypeIcon Bat = new GlyphFileTypeIcon(GlyphFileTypes.Bat, "Bat", "bat");
        public static GlyphFileTypeIcon Apk = new GlyphFileTypeIcon(GlyphFileTypes.Apk, "Apk", "apk");
        public static GlyphFileTypeIcon Jar = new GlyphFileTypeIcon(GlyphFileTypes.Jar, "Jar", "jar");
        public static GlyphFileTypeIcon Hsf = new GlyphFileTypeIcon(GlyphFileTypes.Hsf, "Hsf", "hsf");
        public static GlyphFileTypeIcon Pif = new GlyphFileTypeIcon(GlyphFileTypes.Pif, "Pif", "pif");
        public static GlyphFileTypeIcon Vb = new GlyphFileTypeIcon(GlyphFileTypes.Vb, "Vb", "vb");
        public static GlyphFileTypeIcon Cgi = new GlyphFileTypeIcon(GlyphFileTypes.Cgi, "Cgi", "cgi");
        public static GlyphFileTypeIcon Css = new GlyphFileTypeIcon(GlyphFileTypes.Css, "Css", "css");
        public static GlyphFileTypeIcon Js = new GlyphFileTypeIcon(GlyphFileTypes.Js, "Js", "js");
        public static GlyphFileTypeIcon Php = new GlyphFileTypeIcon(GlyphFileTypes.Php, "Php", "php");
        public static GlyphFileTypeIcon Xhtml = new GlyphFileTypeIcon(GlyphFileTypes.Xhtml, "Xhtml", "xhtml");
        public static GlyphFileTypeIcon Htm = new GlyphFileTypeIcon(GlyphFileTypes.Htm, "Htm", "htm");
        public static GlyphFileTypeIcon Html = new GlyphFileTypeIcon(GlyphFileTypes.Html, "Html", "html");
        public static GlyphFileTypeIcon Asp = new GlyphFileTypeIcon(GlyphFileTypes.Asp, "Asp", "asp");
        public static GlyphFileTypeIcon Cer = new GlyphFileTypeIcon(GlyphFileTypes.Cer, "Cer", "cer");
        public static GlyphFileTypeIcon Jsp = new GlyphFileTypeIcon(GlyphFileTypes.Jsp, "Jsp", "jsp");
        public static GlyphFileTypeIcon Cfm = new GlyphFileTypeIcon(GlyphFileTypes.Cfm, "Cfm", "cfm");
        public static GlyphFileTypeIcon Aspx = new GlyphFileTypeIcon(GlyphFileTypes.Aspx, "Aspx", "aspx");
        public static GlyphFileTypeIcon Rss = new GlyphFileTypeIcon(GlyphFileTypes.Rss, "Rss", "rss");
        public static GlyphFileTypeIcon Csr = new GlyphFileTypeIcon(GlyphFileTypes.Csr, "Csr", "csr");
        public static GlyphFileTypeIcon Less = new GlyphFileTypeIcon(GlyphFileTypes.Less, "Less", "less");
        public static GlyphFileTypeIcon Otf = new GlyphFileTypeIcon(GlyphFileTypes.Otf, "Otf", "otf");
        public static GlyphFileTypeIcon Ttf = new GlyphFileTypeIcon(GlyphFileTypes.Ttf, "Ttf", "ttf");
        public static GlyphFileTypeIcon Font = new GlyphFileTypeIcon(GlyphFileTypes.Font, "Font", "font");
        public static GlyphFileTypeIcon Fnt = new GlyphFileTypeIcon(GlyphFileTypes.Fnt, "Fnt", "fnt");
        public static GlyphFileTypeIcon Eot = new GlyphFileTypeIcon(GlyphFileTypes.Eot, "Eot", "eot");
        public static GlyphFileTypeIcon Woff = new GlyphFileTypeIcon(GlyphFileTypes.Woff, "Woff", "woff");
        public static GlyphFileTypeIcon Zip = new GlyphFileTypeIcon(GlyphFileTypes.Zip, "Zip", "zip");
        public static GlyphFileTypeIcon Zipx = new GlyphFileTypeIcon(GlyphFileTypes.Zipx, "Zipx", "zipx");
        public static GlyphFileTypeIcon Rar = new GlyphFileTypeIcon(GlyphFileTypes.Rar, "Rar", "rar");
        public static GlyphFileTypeIcon Targ = new GlyphFileTypeIcon(GlyphFileTypes.Targ, "Targ", "targ");
        public static GlyphFileTypeIcon Sitx = new GlyphFileTypeIcon(GlyphFileTypes.Sitx, "Sitx", "sitx");
        public static GlyphFileTypeIcon Deb = new GlyphFileTypeIcon(GlyphFileTypes.Deb, "Deb", "deb");
        public static GlyphFileTypeIcon E7z = new GlyphFileTypeIcon(GlyphFileTypes.E7z, "E7z", "e-7z");
        public static GlyphFileTypeIcon Pkg = new GlyphFileTypeIcon(GlyphFileTypes.Pkg, "Pkg", "pkg");
        public static GlyphFileTypeIcon Rpm = new GlyphFileTypeIcon(GlyphFileTypes.Rpm, "Rpm", "rpm");
        public static GlyphFileTypeIcon Cbr = new GlyphFileTypeIcon(GlyphFileTypes.Cbr, "Cbr", "cbr");
        public static GlyphFileTypeIcon Gz = new GlyphFileTypeIcon(GlyphFileTypes.Gz, "Gz", "gz");
        public static GlyphFileTypeIcon Dmg = new GlyphFileTypeIcon(GlyphFileTypes.Dmg, "Dmg", "dmg");
        public static GlyphFileTypeIcon Cue = new GlyphFileTypeIcon(GlyphFileTypes.Cue, "Cue", "cue");
        public static GlyphFileTypeIcon Bin = new GlyphFileTypeIcon(GlyphFileTypes.Bin, "Bin", "bin");
        public static GlyphFileTypeIcon Iso = new GlyphFileTypeIcon(GlyphFileTypes.Iso, "Iso", "iso");
        public static GlyphFileTypeIcon Hdf = new GlyphFileTypeIcon(GlyphFileTypes.Hdf, "Hdf", "hdf");
        public static GlyphFileTypeIcon Vcd = new GlyphFileTypeIcon(GlyphFileTypes.Vcd, "Vcd", "vcd");
        public static GlyphFileTypeIcon Bak = new GlyphFileTypeIcon(GlyphFileTypes.Bak, "Bak", "bak");
        public static GlyphFileTypeIcon Tmp = new GlyphFileTypeIcon(GlyphFileTypes.Tmp, "Tmp", "tmp");
        public static GlyphFileTypeIcon Ics = new GlyphFileTypeIcon(GlyphFileTypes.Ics, "Ics", "ics");
        public static GlyphFileTypeIcon Msi = new GlyphFileTypeIcon(GlyphFileTypes.Msi, "Msi", "msi");
        public static GlyphFileTypeIcon Cfg = new GlyphFileTypeIcon(GlyphFileTypes.Cfg, "Cfg", "cfg");
        public static GlyphFileTypeIcon Ini = new GlyphFileTypeIcon(GlyphFileTypes.Ini, "Ini", "ini");
        public static GlyphFileTypeIcon Prf = new GlyphFileTypeIcon(GlyphFileTypes.Prf, "Prf", "prf");
        #endregion

        public GlyphFileTypeIcon(GlyphFileTypes value, string name, string cssName) : base(IconType.GlyphFileType, (int) value, name, cssName)
        {
        }

        public override string ToClass(FontScale scale)
        {
            switch (scale)
            {
                case FontScale.Small:
                    return "filetypes-" + base.CssName + " x05";
                case FontScale.x2:
                    return "filetypes-" + base.CssName + " x2";
                case FontScale.x3:
                    return "filetypes-" + base.CssName + " x3";
                case FontScale.x4:
                    return "filetypes-" + base.CssName + " x4";
                case FontScale.x5:
                    return "filetypes-" + base.CssName + " x5";
                case FontScale.Default:
                default:
                    return "filetypes-" + base.CssName;
            }
        }
    }
}
