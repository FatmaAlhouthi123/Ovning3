using System;

namespace Ovning3 {
    /// <summary>
    /// ///
    /// </summary>
    class Wolfman : Wolf, IPerson {
        public void Talk() {
            Console.WriteLine("Hi, this is wolfman!");
        }
    }
}
