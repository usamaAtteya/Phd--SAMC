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
namespace Xbim.Ifc4.ConstraintResource
{
	public partial class IfcConstraint : IExpressValidatable
	{
		public enum IfcConstraintClause
		{
			WR11,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcConstraintClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcConstraintClause.WR11:
						retVal = (ConstraintGrade != IfcConstraintEnum.USERDEFINED) || ((ConstraintGrade == IfcConstraintEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcConstraint*/.UserDefinedGrade));
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.ConstraintResource.IfcConstraint");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcConstraint.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcConstraintClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcConstraint.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
