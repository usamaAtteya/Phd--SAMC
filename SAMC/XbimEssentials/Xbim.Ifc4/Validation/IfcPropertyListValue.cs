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
namespace Xbim.Ifc4.PropertyResource
{
	public partial class IfcPropertyListValue : IExpressValidatable
	{
		public enum IfcPropertyListValueClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPropertyListValueClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPropertyListValueClause.WR31:
						retVal = Functions.SIZEOF(this.ListValues.Where(temp => !(Functions.TYPEOF(this.ListValues.ItemAt(0)) == Functions.TYPEOF(temp)))) == 0;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc4.PropertyResource.IfcPropertyListValue");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcPropertyListValue.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPropertyListValueClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPropertyListValue.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
