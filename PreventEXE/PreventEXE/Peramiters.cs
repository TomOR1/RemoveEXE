namespace PreventEXE
{
    class Peramiters
    {
        /// <summary>
        /// The origin
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// (should start with a '.') What extentions to augment
        /// </summary>
        public string[] DislikedExtentions { get; set; }
        /// <summary>
        /// What to add to the end of the dissliked extentions
        /// </summary>
        public string Suffix { get; set; }
    }

    class TemporaryHoldings
    {
        public string[] List { get; set; }
    }
}
