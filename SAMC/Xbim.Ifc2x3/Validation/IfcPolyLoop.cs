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
namespace Xbim.Ifc2x3.TopologyResource
{
	public partial class IfcPolyLoop : IExpressValidatable
	{
		public enum IfcPolyLoopClause
		{
			WR21,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPolyLoopClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPolyLoopClause.WR21:
						retVal = Functions.SIZEOF(Polygon.Where(Temp => Temp.Dim != Polygon.ItemAt(0).Dim)) == 0;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.TopologyResource.IfcPolyLoop");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcPolyLoop.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPolyLoopClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPolyLoop.WR21", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
