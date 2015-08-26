/**
 * By Temoto-kun
 */

using System;
using System.Collections.Generic;

namespace PointTracer {
    /// <summary>
    /// Class for wrapping the command-line parameters.
    /// </summary>
    class Arguments {
        #region Constants


        /// <summary>
        /// String constant for separating the key and value of an argument.
        /// </summary>
        public const string PairSeparator = ":";

        /// <summary>
        /// String constant for specifying an argument having this prefix to be a flag.
        /// </summary>
        public const string FlagPrefix = "-";


        #endregion

        #region Properties


        /// <summary>
        /// The flags set in this argument.
        /// </summary>
        public Dictionary<string, List<string>> Flags { get; private set; }

        /// <summary>
        /// The default arguments set.
        /// </summary>
        public Dictionary<string, List<string>> Default { get; private set; }


        #endregion

        #region Private Methods


        private void AddFlags(IEnumerable<string> flags) {
            foreach(var flag in flags) {
                var isPair = flag.IndexOf(PairSeparator, StringComparison.Ordinal) != -1;
                var key = isPair ? flag.Substring(0, flag.IndexOf(PairSeparator, StringComparison.Ordinal)) : flag;
                var value = isPair ? flag.Substring(flag.IndexOf(PairSeparator, StringComparison.Ordinal) + 1) : true.ToString();
                try {
                    this.Flags[key].Add(value);
                } catch(KeyNotFoundException) {
                    this.Flags[key] = new List<string> {value};
                }
            }
        }

        private void AddDefault(IEnumerable<string> defs) {
            foreach(var def in defs) {
                var isPair = def.IndexOf(PairSeparator, StringComparison.Ordinal) != -1;
                var key = isPair ? def.Substring(0, def.IndexOf(PairSeparator, StringComparison.Ordinal)) : def;
                var value = isPair ? def.Substring(def.IndexOf(PairSeparator, StringComparison.Ordinal) + 1) : true.ToString();
                try {
                    this.Default[key].Add(value);
                } catch(KeyNotFoundException) {
                    this.Default[key] = new List<string> {value};
                }
            }
        }


        #endregion
        
        #region Constructors


        /// <summary>
        /// The default constructor.
        /// </summary>
        public Arguments() {
            Flags = new Dictionary<string, List<string>>();
            Default = new Dictionary<string, List<string>>();
        }

        /// <summary>
        /// The constructor, specifying the flags and the default arguments set.
        /// </summary>
        /// <param name="flags">The flags</param>
        /// <param name="defs">The default arguments</param>
        public Arguments(Dictionary<string, List<string>> flags, Dictionary<string, List<string>> defs)
            : this() {
            Flags = flags;
            Default = defs;
        }

        /// <summary>
        /// The constructor, specifying the flags and the default arguments set.
        /// </summary>
        /// <param name="flags">The flags</param>
        /// <param name="defs">The default arguments</param>
        public Arguments(IEnumerable<string> flags, IEnumerable<string> defs)
            : this() {
            this.AddFlags(flags);
            this.AddDefault(defs);
        }

        /// <summary>
        /// The constructor, specifying the flags and the default arguments set.
        /// </summary>
        /// <param name="args">The argument strings.</param>
        public Arguments(IEnumerable<string> args)
            : this() {
            var flags = new List<string>();
            var defs = new List<string>();
            foreach(var arg in args)
                if(arg.StartsWith(string.Format("{0}", FlagPrefix)))
                    flags.Add(arg.Substring(FlagPrefix.Length));
                else
                    defs.Add(arg);
            this.AddFlags(flags);
            this.AddDefault(defs);
        }


        #endregion
    }
}
