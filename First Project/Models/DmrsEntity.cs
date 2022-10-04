using System;
using System.Collections.Generic;

#nullable disable

namespace First_Project.Models
{
    public partial class DmrsEntity
    {
        public string EntityName { get; set; }
        public string ObjectId { get; set; }
        public string Ovid { get; set; }
        public string ImportId { get; set; }
        public string ModelId { get; set; }
        public string ModelOvid { get; set; }
        public string StructuredTypeId { get; set; }
        public string StructuredTypeOvid { get; set; }
        public string StructuredTypeName { get; set; }
        public decimal? NumberDataElements { get; set; }
        public string ClassificationTypeId { get; set; }
        public string ClassificationTypeOvid { get; set; }
        public string ClassificationTypeName { get; set; }
        public string AllowTypeSubstitution { get; set; }
        public string CreateSurrogateKey { get; set; }
        public decimal? MinVolume { get; set; }
        public decimal? ExpectedVolume { get; set; }
        public decimal? MaxVolume { get; set; }
        public decimal? GrowthRatePercents { get; set; }
        public string GrowthRateInterval { get; set; }
        public string NormalForm { get; set; }
        public string TemporaryObjectScope { get; set; }
        public string AdequatelyNormalized { get; set; }
        public string SubstitutionParent { get; set; }
        public string SubstitutionParentOvid { get; set; }
        public string Synonyms { get; set; }
        public string SynonymToDisplay { get; set; }
        public string PreferredAbbreviation { get; set; }
        public string SupertypeentityId { get; set; }
        public string SupertypeentityOvid { get; set; }
        public string EngineeringStrategy { get; set; }
        public string Owner { get; set; }
        public string EntitySource { get; set; }
        public string ModelName { get; set; }
        public string SubstitutionParentName { get; set; }
        public string SupertypeentityName { get; set; }
        public string SubtSubtreeGeneration { get; set; }
        public string SubtApplyToModelOvid { get; set; }
        public string SubtReferences { get; set; }
        public string SubtAttributesInheritance { get; set; }
        public string SubtGenerateDiscriminator { get; set; }
        public string SubtUseAttributeId { get; set; }
        public string SubtDiscriminatorColumnName { get; set; }
        public string SubtDiscriminatorValue { get; set; }
        public string SubtCompleteSubtypes { get; set; }
        public string DesignOvid { get; set; }
        public string RemotedesignId { get; set; }
        public string RemotemodelId { get; set; }
        public string RemoteobjectId { get; set; }
        public string Remoteobjectrltvstoragename { get; set; }
        public string Usedasremoteobject { get; set; }
        public string ShortName { get; set; }
    }
}
