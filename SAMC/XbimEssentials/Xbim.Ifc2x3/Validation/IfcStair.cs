using System;
using log4net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Xbim.Common.Enumerations;
using Xbim.Common.ExpressValidation;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.Kernel;
using Xbim.Ifc2x3.ProfileResource;
using Xbim.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class IfcStair : IExpressValidatable
	{
		public enum IfcStairClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcStairClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcStairClause.WR1:
						retVal = (Functions.HIINDEX(this/* as IfcObjectDefinition*/.IsDecomposedBy) == 0) || ((Functions.HIINDEX(this/* as IfcObjectDefinition*/.IsDecomposedBy) == 1) && (!(Functions.EXISTS(this/* as IfcProduct*/.Representation))));
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.SharedBldgElements.IfcStair");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcStair.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcStairClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStair.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
