using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc4.Interfaces;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc4.RepresentationResource
{
	public partial class IfcProductDefinitionShape : IExpressValidatable
	{
		public enum IfcProductDefinitionShapeClause
		{
			OnlyShapeModel,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcProductDefinitionShapeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcProductDefinitionShapeClause.OnlyShapeModel:
						retVal = Functions.SIZEOF(Representations.Where(temp => (!(Functions.TYPEOF(temp).Contains("IFC4.IFCSHAPEMODEL"))))) == 0;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.RepresentationResource.IfcProductDefinitionShape");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcProductDefinitionShape.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcProductDefinitionShapeClause.OnlyShapeModel))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcProductDefinitionShape.OnlyShapeModel", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
