﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xbim.COBieLiteUK;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Attribute = Xbim.COBieLiteUK.Attribute;

namespace Tests
{
    [TestClass]
    public class CoBieLiteUkTests
    {
        [TestMethod]
        public void CoBieLiteUkCreation()
        {
            var facility = new Facility
            {
                CreatedOn = DateTime.Now,
                CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                Category = "Schools",
                ExternalId = System.Guid.NewGuid().ToString(),
                AreaUnits = AreaUnit.squaremeters,
                CurrencyUnit = CurrencyUnit.GBP,
                LinearUnits = LinearUnit.millimeters,
                AreaMeasurement = "NRM",
                VolumeUnits = VolumeUnit.cubicmeters,
                Phase = "Phase A",
                Description = "New facility description",
                Name = "Ellison Building",
                Project = new Project
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = "Project A"
                },
                Site = new Site
                {
                    ExternalId = Guid.NewGuid().ToString(),
                    Name = "Site A"
                },
                Zones = new List<Zone>
                {
                    new Zone
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        ExternalId = Guid.NewGuid().ToString(),
                        Name = "Zone A",
                        Category = "45.789.78",
                        Description = "Description of the zone A",
                        Spaces = new List<SpaceKey>
                        {
                            new SpaceKey {Name = "A001 - Front Room"},
                            new SpaceKey {Name = "A002 - Living Room"},
                            new SpaceKey {Name = "A003 - Bedroom"},
                        }
                    }
                },
                Contacts = new List<Contact>
                {
                    new Contact
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Category = "12.45.56",
                        FamilyName = "Martin",
                        Email = "martin.cerny@northumbria.ac.uk",
                        GivenName = "Cerny"
                    },
                    new Contact
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Category = "12.45.56",
                        FamilyName = "Peter",
                        Email = "peter.pan@northumbria.ac.uk",
                        GivenName = "Pan"
                    },
                    new Contact
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Category = "12.45.56",
                        FamilyName = "Paul",
                        Email = "paul.mccartney@northumbria.ac.uk",
                        GivenName = "McCartney"
                    }
                },
                Floors = new List<Floor>
                {
                    new Floor
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Elevation = 15000,
                        Height = 3400,
                        Spaces = new List<Space>
                        {
                            new Space
                            {
                                CreatedOn = DateTime.Now,
                                CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                                Category = "Sp_02_78_98",
                                Description = "First front room in COBieLiteUK ever",
                                Name = "A001 - Front Room",
                                UsableHeight = 3500,
                                NetArea = 6
                            },
                            new Space
                            {
                                CreatedOn = DateTime.Now,
                                CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                                Category = "Sp_02_78_98",
                                Description = "First living room in COBieLiteUK ever",
                                Name = "A002 - Living Room",
                                UsableHeight = 4200,
                                NetArea = 55
                            },
                            new Space
                            {
                                CreatedOn = DateTime.Now,
                                CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                                Category = "Sp_02_78_98",
                                Description = "First bedroom in COBieLiteUK ever",
                                Name = "A003 - Bedroom",
                                UsableHeight = 4100,
                                NetArea = 25
                            }
                        }
                    }
                },
                AssetTypes = new List<AssetType>
                {
                    new AssetType
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Name = "Brick layered wall",
                        Assets = new List<Asset>
                        {
                            new Asset
                            {
                                CreatedOn = DateTime.Now,
                                Name = "120mm partition wall",
                                Representations = new List<Representation>
                                {
                                    new Representation
                                    {
                                        CreatedOn = DateTime.Now,
                                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                                        X = 0,
                                        Y = 0,
                                        Z = 0,
                                        SizeX = 1000,
                                        SizeY = 2000,
                                        SizeZ = 200,
                                        Name = Guid.NewGuid().ToString()
                                    }
                                },
                                CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"}
                            },
                            new Asset
                            {
                                CreatedOn = DateTime.Now,
                                Name = "180mm partition wall",
                                Representations = new List<Representation>
                                {
                                    new Representation
                                    {
                                        CreatedOn = DateTime.Now,
                                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                                        X = 0,
                                        Y = 0,
                                        Z = 0,
                                        SizeX = 1000,
                                        SizeY = 2000,
                                        SizeZ = 200,
                                        Name = Guid.NewGuid().ToString()
                                    }
                                },
                                CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"}
                            },
                            new Asset
                            {
                                CreatedOn = DateTime.Now,
                                Name = "350mm external brick wall",
                                Representations = new List<Representation>
                                {
                                    new Representation
                                    {
                                        CreatedOn = DateTime.Now,
                                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                                        X = 0,
                                        Y = 0,
                                        Z = 0,
                                        SizeX = 1000,
                                        SizeY = 2000,
                                        SizeZ = 200,
                                        Name = Guid.NewGuid().ToString()
                                    }
                                },
                                CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"}
                            }
                        }
                    }
                },
                Attributes = new List<Attribute>
                {
                    new Attribute
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Name = "String attribute",
                        Value = new StringAttributeValue {Value = "Almukantarant"},
                        Category = "Submited"
                    },
                    new Attribute
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Name = "Boolean attribute",
                        Value = new BooleanAttributeValue {Value = true},
                        Category = "Submited"
                    },
                    new Attribute
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Name = "Datetime attribute",
                        Value = new DateTimeAttributeValue {Value = DateTime.Now},
                        Category = "Submited"
                    },
                    new Attribute
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Name = "Decimal attribute",
                        Value = new DecimalAttributeValue {Value = 256.2},
                        Category = "Submited"
                    },
                    new Attribute
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Name = "Integer attribute",
                        Value = new IntegerAttributeValue {Value = 7},
                        Category = "Submited"
                    },
                    new Attribute
                    {
                        CreatedOn = DateTime.Now,
                        CreatedBy = new ContactKey {Email = "martin.cerny@northumbria.ac.uk"},
                        Name = "Null attribute"
                    }
                }
            };

            //save model to file to check it
            const string xmlFile = "facility.cobielite.xml";
            const string jsonFile = "facility.cobielite.json";
            facility.WriteXml(xmlFile, true);
            facility.WriteJson(jsonFile, true);

            var facility2 = Facility.ReadXml(xmlFile);
            var facility3 = Facility.ReadJson(jsonFile);
        }
    }
}