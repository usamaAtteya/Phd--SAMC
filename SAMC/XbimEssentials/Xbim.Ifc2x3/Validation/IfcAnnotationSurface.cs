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
namespace Xbim.Ifc2x3.PresentationDefinitionResource
{
	public partial class IfcAnnotationSurface : IExpressValidatable
	{
		public enum IfcAnnotationSurfaceClause
		{
			WR01,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcAnnotationSurfaceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcAnnotationSurfaceClause.WR01:
						retVal = Functions.SIZEOF(Functions.NewArray("IFC2X3.IFCSURFACE", "IFC2X3.IFCSHELLBASEDSURFACEMODEL", "IFC2X3.IFCFACEBASEDSURFACEMODEL", "IFC2X3.IFCSOLIDMODEL", "IFC2X3.IFCBOOLEANRESULT", "IFC2X3.IFCCSGPRIMITIVE3D") * Functions.TYPEOF(Item)) >= 1;
						break;
				}
			} catch (Exception ex) {
				var Log = LogManager.GetLogger("Xbim.Ifc2x3.PresentationDefinitionResource.IfcAnnotationSurface");
				Log.Error(string.Format("Exception thrown evaluating where-clause 'IfcAnnotationSurface.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcAnnotationSurfaceClause.WR01))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcAnnotationSurface.WR01", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
