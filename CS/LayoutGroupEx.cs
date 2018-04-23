using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Docking;

namespace CustomLayoutGroup.Common {
    public class LayoutGroupEx : LayoutGroup {
        protected override GroupBorderStyle CoerceGroupBorderStyle(GroupBorderStyle value) {
            return value;
        }
    }
}
