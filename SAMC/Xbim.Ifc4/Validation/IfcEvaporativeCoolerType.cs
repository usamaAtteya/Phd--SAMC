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
namespace Xbim.Ifc4.HvacDomain
{
	public partial class IfcEvaporativeCoolerType : IExpressValidatable
	{
		public enum IfcEvaporativeCoolerTypeClause
		{
			CorrectPredefinedType,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcEvaporativeCoolerTypeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcEvaporativeCoolerTypeClause.CorrectPredefinedType:
						retVal = (PredefinedType != IfcEvaporativeCoolerTypeEnum.USERDEFINED) || ((PredefinedType == IfcEvaporativeCoolerTypeEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcElementType*/.ElementType));
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.HvacDomain.IfcEvaporativeCoolerType");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcEvaporativeCoolerType.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcEvaporativeCoolerTypeClause.CorrectPredefinedType))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcEvaporativeCoolerType.CorrectPredefinedType", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
