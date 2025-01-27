﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.Common.Step21;
using Xbim.Ifc;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.Interfaces;
using Xbim.Common;

namespace Xbim.Essentials.Tests
{
    [TestClass]
    public class Pure4Tests
    {
        [TestMethod]
        public void IndependentCreation()
        {
            using (var model = IfcStore.Create(IfcSchemaVersion.Ifc2X3, XbimStoreType.InMemoryModel))
            {
                CreateDataWithInitializers(model);

                CreateDataWithoutInitializers(model);
            }

            using (var model = IfcStore.Create(IfcSchemaVersion.Ifc2X3, XbimStoreType.EsentDatabase))
            {
                CreateDataWithInitializers(model);

                CreateDataWithoutInitializers(model);
            }

            using (var model = IfcStore.Create(IfcSchemaVersion.Ifc4, XbimStoreType.InMemoryModel))
            {
                CreateDataWithInitializers(model);

                CreateDataWithoutInitializers(model);
            }

            using (var model = IfcStore.Create(IfcSchemaVersion.Ifc4, XbimStoreType.EsentDatabase))
            {
                CreateDataWithInitializers(model);

                CreateDataWithoutInitializers(model);
            }
        }

        public void CreateDataWithoutInitializers(IModel model)
        {
            using (var txn = model.BeginTransaction("Objects creation"))
            {
                var create = new Create(model);
                var wall = create.Wall();
                wall.PredefinedType = IfcWallTypeEnum.POLYGONAL;
                wall.Name = "Name of the perfect wall";
                
                var wallType = create.WallType();
                wallType.Name = "Super wall type";

                var relDef = create.RelDefinesByType();
                relDef.RelatedObjects.Add(wall);
                relDef.RelatingType = wallType;

            txn.Commit();
            }
        }

        public void CreateDataWithInitializers(IModel model)
        {
            using (var txn = model.BeginTransaction("Objects creation"))
            {
                var create = new Create(model);
                var wall = create.Wall(w =>
                {
                    w.PredefinedType = IfcWallTypeEnum.POLYGONAL;
                    w.Name = "Name of the perfect wall";
                });


                create.RelDefinesByProperties(r =>
                {
                    r.RelatedObjects.Add(wall);
                    r.RelatingPropertyDefinition = create.PropertySet(ps =>
                    {
                        ps.HasProperties.AddRange(new[]
                    {
                            create.PropertySingleValue(p =>
                            {
                                p.Name = "Single value";
                                p.NominalValue = new IfcLabel("Value of the single value property");
                            }),
                            create.PropertySingleValue(p =>
                            {
                                p.Name = "Single length";
                                p.NominalValue = new IfcLengthMeasure(15.5);
                            }),
                            create.PropertySingleValue(p =>
                            {
                                p.Name = "Single boolean";
                                p.NominalValue = new IfcBoolean(true);
                            }),
                        });
                    });
                });

                create.RelDefinesByType(r =>
                {
                    r.RelatedObjects.Add(wall);
                    r.RelatingType = create.WallType(t => t.Name = "Super wall type");
                });

                txn.Commit();
            }
        }
    }
}
