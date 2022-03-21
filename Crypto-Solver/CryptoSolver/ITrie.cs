/* ITrie.cs
 * Julie Thornton
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoSolver
{
    /// <summary>
    /// An interface for a trie.
    /// </summary>
    public interface ITrie
    {
        /// <summary>
        /// Determines whether this trie contains the given string.
        /// </summary>
        /// <param name="s">The string to look for.</param>
        /// <returns>Whether this trie contains s.</returns>
        bool Contains(string s);

        /// <summary>
        /// Adds the given string to this trie. This trie may or may not
        /// be changed by this method, but the resulting trie is always
        /// returned.
        /// </summary>
        /// <param name="s">The string to add.</param>
        /// <returns>The resulting trie.</returns>
        ITrie Add(string s);

        /// <summary>
        /// Checks to see if any combination of chars replacing the wildcard char in string s can form a word
        /// </summary>
        /// <param name="s"> string with wildcard values implemented </param>
        /// <returns> true if a word can be formed, else false</returns>
        bool WildcardSearch(string s);
    }
}
