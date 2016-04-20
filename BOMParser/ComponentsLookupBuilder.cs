using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BOMParser
{
    public class ComponentsLookupBuilder:Base
    {
        #region Properties
        //the lookup filename
        public string FileName { set; get; }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the builder with a full path
        /// </summary>
        /// <param name="fileName">Full path to filename.</param>
        public ComponentsLookupBuilder(string fileName)
        {
            this.FileName = fileName;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the lookup table after parsing the lookup file.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetComponentsLookupTable()
        {
            Dictionary<string, string> _lookup = new Dictionary<string, string>();
            if (!File.Exists(this.FileName)) throw new FileNotFoundException("Dictionary file not found");
            FileStream fs = new FileStream(this.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                if (!line.Contains("$")) throw new Exception("File doesn't contian delimiter $");
                string[] keysValues = line.Split('$');
                if (keysValues.Length > 2) throw new Exception("Component details more than excpected");
                if (keysValues.Length < 2) throw new Exception("Component details less than excpected");
                _lookup.Add(keysValues[0], keysValues[1]);
            }
            sr.Close();
            fs.Close();
            return _lookup;
        }
        #endregion
    }
}
