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
	public partial class IfcSlab : IExpressValidatable
	{
		public enum IfcSlabClause
		{
			WR61,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcSlabClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcSlabClause.WR61:
						retVal = !(Functions.EXISTS(PredefinedType)) || (PredefinedType != IfcSlabTypeEnum.USERDEFINED) || ((PredefinedType == IfcSlabTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObject*/.ObjectType));
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.SharedBldgElements.IfcSlab");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcSlab.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcSlabClause.WR61))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSlab.WR61", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
