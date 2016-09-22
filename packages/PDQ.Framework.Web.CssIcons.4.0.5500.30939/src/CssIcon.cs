using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PDQ.Framework.Web.CssIcons
{
    [KnownType(typeof(FontAwesomeIcon))]
    [KnownType(typeof(GlyphSocialIcon))]
    [KnownType(typeof(GlyphFileTypeIcon))]
    [KnownType(typeof(GlyphHalflingIcon))]
    [KnownType(typeof(GlyphSocialIcon))]
    public abstract class CssIcon<T> : Enumeration<T, int>, ICssIcon where T : CssIcon<T>
    {
        public CssIcon(IconType type, int value, string name, string cssName)
            : base(value, name)
        {
            _IconType = type;
            _CssName = cssName;
        }

        [DataMember(Order = 2)]
        readonly IconType _IconType;

        [DataMember(Order = 3)]
        readonly string _CssName;

        public IconType Type { get { return _IconType; } }
        public string CssName { get { return _CssName; } }

        public string ToClass()
        {
            return ToClass(FontScale.Default);
        }

        public abstract string ToClass(FontScale scale);

        public override string ToString()
        {
            return ToClass(FontScale.Default);
        }

        public virtual string ToString(string format)
        {
            return string.Format(format, CssName);
        }
    }
}
