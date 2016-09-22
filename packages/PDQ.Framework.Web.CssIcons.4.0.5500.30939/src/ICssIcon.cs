using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PDQ.Framework.Web.CssIcons
{
    public interface ICssIcon
    {
        IconType Type { get; }
        string CssName { get; }

        string ToClass();

        string ToClass(FontScale scale);

        string ToString(string format);
    }
}
