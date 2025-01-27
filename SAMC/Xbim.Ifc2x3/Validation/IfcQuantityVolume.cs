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
namespace Xbim.Ifc2x3.QuantityResource
{
	public partial class IfcQuantityVolume : IExpressValidatable
	{
		public enum IfcQuantityVolumeClause
		{
			WR21,
			WR22,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcQuantityVolumeClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcQuantityVolumeClause.WR21:
						retVal = !(Functions.EXISTS(this/* as IfcPhysicalSimpleQuantity*/.Unit)) || (this/* as IfcPhysicalSimpleQuantity*/.Unit.UnitType == IfcUnitEnum.VOLUMEUNIT);
						break;
					case IfcQuantityVolumeClause.WR22:
						retVal = VolumeValue >= 0;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.QuantityResource.IfcQuantityVolume");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcQuantityVolume.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcQuantityVolumeClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcQuantityVolume.WR21", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcQuantityVolumeClause.WR22))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcQuantityVolume.WR22", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
