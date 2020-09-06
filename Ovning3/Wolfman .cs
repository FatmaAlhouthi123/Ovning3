using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3 {
    /// <summary>
    /// ///
    /// </summary>
    class Wolfman : Wolf, IPerson {
        public string Talk() {
            return "Hi, this is wolfman!";
        }
    }
}
