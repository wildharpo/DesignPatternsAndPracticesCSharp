using System.Text.RegularExpressions;

namespace DesignPatterns.Library.Patterns.Creational.Builder
{
    public class RTFReader
    {
        private TextConverter _textConverter;

        public RTFReader(TextConverter textConverter)
        {
            _textConverter = textConverter;
        }

        public void ParseRTF()
        {
            using(var rtfFileReader = new StringReader(Properties.Resources.CSCI_0371_Syllabus))
            {
                // Read contents of the Rich Text File
                var rtfFileContents = rtfFileReader.ReadToEnd();

                // Use regex to get the portions of the RTF file that have actual text.
                // Ideally, we would also grab the various header and other information available in 
                // the Rich Text File for font change and formatting information, but it would take 
                // more time than I have available at the moment.
                var paragraphsRegex = new Regex("(rtlch.*themedata)", RegexOptions.Singleline);
                var paragraphMatches = paragraphsRegex.Matches(rtfFileContents);
                var paragraphsSection = paragraphMatches
                    .First()
                    .Value
                    .Replace("}{\\*\\themedata", "");
                // The paragraph match result has come back from regex as one giant blob of text, so 
                // split up the results into individual "sentences"
                var paragraphs = paragraphsSection
                    .Substring(1)
                    .Split("}{")
                    .Where(s => s.Substring(0,6) == "\\rtlch")
                    .ToList();

                // Loop through the paragraphs for conversion
                foreach (var paragraph in paragraphs)
                {
                    // Not all paragraphs are perfectly formatted, so split any additional paragraphs that are
                    // unintentionally joined together
                    var paragraphSplits = paragraph.Split("}");
                    foreach(var paragraphSplit in paragraphSplits)
                    {
                        // Rich Text Files have tags with the format of insrsid<randomNumberHere> <actualTextHere>, so 
                        // find where the actual text begins
                        var tagPrecedingTextLocation = paragraphSplit.LastIndexOf("insrsid");
                        if (tagPrecedingTextLocation == -1)
                            continue;
                        var lastSpaceBeforeText = paragraphSplit.Substring(tagPrecedingTextLocation).IndexOf(" ");
                        var textValue = paragraphSplit.Substring(tagPrecedingTextLocation + lastSpaceBeforeText + 1)
                            .Replace("\\par",""); // Remove the trailing "par" tag that sometimes appears in RTF format
                        foreach (var character in textValue)
                            _textConverter.ConvertCharacter(character);
                        //// Add a carriage return new line after each "line" of text
                        //_textConverter.ConvertCharacter('\r');
                        //_textConverter.ConvertCharacter('\n');
                    }
                }
            }
        }
    }
}
