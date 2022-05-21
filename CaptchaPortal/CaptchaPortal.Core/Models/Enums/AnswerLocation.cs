namespace CaptchaPortal.Core.Models.Enums
{
    [Flags]
    public enum AnswerLocation
    {
        /// <summary>
        /// Answer is not provided.
        /// </summary>
        None,

        /// <summary>
        /// Answer is inside of filename.
        /// </summary>
        /// <remarks>
        /// Variants:
        /// - image.png:answer
        /// - answer.png
        /// </remarks>
        Inline,

        /// <summary>
        /// Answer is located in separate file.
        /// </summary>
        Metafile,        
    }
}
