using System.IO;

namespace PreventEXE
{
    public class PreventEXE
    {
        void DissableExtentions(Peramiters perams)
        {
            // Error prevention

            if (perams.DislikedExtentions == null || perams.DislikedExtentions.Length == 0)
            {
                perams.DislikedExtentions = new string[] { ".exe" };
            }

            if (perams.Suffix == null || perams.Suffix == "")
            {
                perams.Suffix = ".dissabled";
            }

            TemporaryHoldings[] temporaryHoldings = new TemporaryHoldings[perams.DislikedExtentions.Length];

            for (int i = 0; i < perams.DislikedExtentions.Length; i++)
            {
                temporaryHoldings[i].List = Directory.GetFiles(perams.Path, "*" + perams.DislikedExtentions[i], SearchOption.AllDirectories);
            }

            for (int i = 0; i < temporaryHoldings.Length; i++)
            {
                for (int i1 = 0; i1 < temporaryHoldings[i].List.Length; i1++)
                {
                    try
                    {
                        File.Move(temporaryHoldings[i].List[i1], temporaryHoldings[i].List[i1] + perams.Suffix);
                    }
                    catch
                    {
                        System.Console.WriteLine("Error: Could not rename " + temporaryHoldings[i].List[i1] + ". This was most likely a privalage issue.");
                    }
                }
            }
        }
    }
}
