using CaptchaPortal.Core.Models.Enums;

namespace CaptchaPortal.Core.Models
{
    /// <summary>
    /// Represents a dataset for machine learning.
    /// </summary>
    public class UserDataSet
    {
        public string Name { get; set; }
        public string ZipPath { get; set; }
        public DateTime DateCreated { get; set; }
        public Features Features { get; set; }        
        public AnswerLocation AnswerLocation { get; set; }
    }
}
