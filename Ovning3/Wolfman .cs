using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning3 {
    //
    class Wolfman : Wolf, IPerson {
        public string Talk() {
            return "Hi, this is wolfman!";
        }
    }
}
