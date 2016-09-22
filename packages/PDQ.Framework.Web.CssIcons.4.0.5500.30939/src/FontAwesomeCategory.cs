using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDQ.Framework.Web.CssIcons
{
    [Flags]
    public enum FontAwesomeCategory
    {
        None            = 0,
        WebApplication  = 1 << 0,
        FileType        = 1 << 1,
        Spinner         = 1 << 2,
        FormControl     = 1 << 3,
        Payment         = 1 << 4,
        Chart           = 1 << 5,
        Currency        = 1 << 6,
        TextEditor      = 1 << 7,
        Directional     = 1 << 8,
        VideoPlayer     = 1 << 9,
        Brand           = 1 << 10,
        Medical         = 1 << 10,
    }
}
