using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Nlp.RNNlp
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNlpModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNlpModule"/>.
        /// </summary>
        internal RNNlpModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNlp";
            }
        }
    }
}
