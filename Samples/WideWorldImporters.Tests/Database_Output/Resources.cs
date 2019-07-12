﻿// <auto-generated />
namespace WideWorldImporters.Tests.Database_Output
{
    using global::System;
    using global::System.Diagnostics.CodeAnalysis;
    using global::System.Resources;
    using global::System.Globalization;
    using global::System.ComponentModel;
    using global::System.CodeDom.Compiler;
    using global::System.Diagnostics;
    using global::System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        
        private static ResourceManager resourceMan;
        
        private static CultureInfo resourceCulture;
        
        [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager temp = new ResourceManager("WideWorldImporters.Tests.Database_Output.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-16&quot;?&gt;&lt;TestManifest failOnServerPublishFailureExpression=&quot;True&quot; testSuiteId=&quot;5dd051a5-2258-40cf-802f-020b0d134d71&quot; testSuiteName=&quot;Database&quot; testGroupId=&quot;4c0460d4-c9d1-41b4-b38f-bddf1d5649f9&quot; testGroupName=&quot;Database&quot; isSingleGroupMode=&quot;True&quot; publishUrl=&quot;http://localhost:44320&quot;&gt;&lt;Keys&gt;&lt;Key key=&quot;TestSuiteRevision&quot; value=&quot;11&quot; /&gt;&lt;/Keys&gt;&lt;MethodAssociations&gt;&lt;MethodAssociation methodName=&quot;ComparisonTest&quot; testName=&quot;Comparison Test&quot; testUniqueId=&quot;6caaacfd-401d-4dbc-8bab-e66380c2b84a&quot; / [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TestManifest_Database_4c0460d4c9d141b4b38fbddf1d5649f9
        {
            get
            {
                return ResourceManager.GetString("TestManifest_Database_4c0460d4c9d141b4b38fbddf1d5649f9", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT   --TOP 10 
        ///CAST ([WWI Order ID] AS INT) AS OrderId,
        ///         [Order Date Key],
        ///         SUM([Quantity]) AS Quantity,
        ///         SUM([Total Including Tax]) AS Total
        ///--, * 
        ///FROM     [Fact].[Order]
        ///GROUP BY [WWI Order ID], [Order Date Key]
        ///ORDER BY [WWI Order ID];
        ///
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_a216bdcaec644562b721ec41cb7b46f1
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_a216bdcaec644562b721ec41cb7b46f1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT   [WWI Order ID],
        ///         sum([total excluding tax]) AS total
        ///FROM     [Fact].[Order]
        ///GROUP BY [WWI Order ID];
        ///
        ///.
        /// </summary>
        internal static string TestResource_ActualQuery_d56234835d054017ac601fb9a407b5e5
        {
            get
            {
                return ResourceManager.GetString("TestResource_ActualQuery_d56234835d054017ac601fb9a407b5e5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_5f1cc400840145d7b1aeecca58f58db9
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_5f1cc400840145d7b1aeecca58f58db9", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_668e24ea32a9454ab6b2c01b78bb4c4d
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_668e24ea32a9454ab6b2c01b78bb4c4d", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ComparisonManifest_6d0324245572438c9d276c2827655cd4
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ComparisonManifest_6d0324245572438c9d276c2827655cd4", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_DelimitedFileReference_7b9bdd937aa84a52b3a435253bfe1ecd
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_DelimitedFileReference_7b9bdd937aa84a52b3a435253bfe1ecd", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_DelimitedFileReference_92bf42bfceec41f1ae6ba3c41332417a
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_DelimitedFileReference_92bf42bfceec41f1ae6ba3c41332417a", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_Emptysetvalidationmanifest_3b48b94dcd56482cbbe6ab0158afc977
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_Emptysetvalidationmanifest_3b48b94dcd56482cbbe6ab0158afc977", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_Emptysetvalidationmanifest_cf1cbc41adca4e3395058bb06c33a311
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_Emptysetvalidationmanifest_cf1cbc41adca4e3395058bb06c33a311", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_Emptysetvalidationmanifest_f5321a5eb9b8422782bf2b194ebe676f
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_Emptysetvalidationmanifest_f5321a5eb9b8422782bf2b194ebe676f", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT   orderid,
        ///         sum(quantity * unitprice) AS total
        ///FROM     [Sales].[OrderLines]
        ///GROUP BY orderid;
        ///
        ///.
        /// </summary>
        internal static string TestResource_ExpectedQuery_1fb338e8d4544b1ea7b1d14b11d89773
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_1fb338e8d4544b1ea7b1d14b11d89773", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT 
        ///	--TOP 10
        ///	o.[OrderID], 
        ///	o.[OrderDate], 
        ///	SUM([ol].[Quantity]) AS Quantity, 
        ///	SUM([ol].[UnitPrice] * ol.[Quantity] * ([TaxRate]/100+1)) AS Total
        ///	--, o.* 
        ///FROM 
        ///	[Sales].[Orders] o
        ///		INNER JOIN
        ///	[Sales].[OrderLines] ol ON [ol].[OrderID] = [o].[OrderID]
        ///GROUP BY [o].[OrderID], [o].[OrderDate]
        ///ORDER BY [OrderID].
        /// </summary>
        internal static string TestResource_ExpectedQuery_274f0b9ecb7f464fb1825527161680f3
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_274f0b9ecb7f464fb1825527161680f3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select PersonID, fullname
        ///from application.people
        ///where isemployee = 1
        ///and validto = &apos;9999-12-31 23:59:59.9999999&apos;.
        /// </summary>
        internal static string TestResource_ExpectedQuery_fe97b35901e54552901f962b112aabe0
        {
            get
            {
                return ResourceManager.GetString("TestResource_ExpectedQuery_fe97b35901e54552901f962b112aabe0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to select StockItemID, QuantityOnHand, laststocktakequantity
        ///from [Warehouse].[StockItemHoldings]
        ///where abs(((QuantityOnHand - laststocktakequantity)/laststocktakequantity)) &gt; .05.
        /// </summary>
        internal static string TestResource_Query_2d600ff1ee0a46c99a293e130e141fee
        {
            get
            {
                return ResourceManager.GetString("TestResource_Query_2d600ff1ee0a46c99a293e130e141fee", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT SpecialDealID, DiscountPercentage, P.FULLNAME
        ///FROM Sales.SpecialDeals s
        ///INNER JOIN Application.People P 
        ///ON S.LastEditedBy = P.PersonID
        ///
        ///.
        /// </summary>
        internal static string TestResource_Query_32b90a4b2fed4a29ad31e69a47f661cf
        {
            get
            {
                return ResourceManager.GetString("TestResource_Query_32b90a4b2fed4a29ad31e69a47f661cf", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_RowCount_76b5b2839cd34ecaa4da15b049a0076a
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_RowCount_76b5b2839cd34ecaa4da15b049a0076a", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [Outstanding Balance] FROM [Fact].[Transaction] WHERE [Outstanding Balance] &gt; 500000 OR [Outstanding Balance] &lt; 0.
        /// </summary>
        internal static string TestResource_SourceQuery_a9bc0891684343aebcbcad8afe48885d
        {
            get
            {
                return ResourceManager.GetString("TestResource_SourceQuery_a9bc0891684343aebcbcad8afe48885d", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [InvoiceID], COUNT(*) AS DuplicateCount FROM [Sales].[Invoices] GROUP BY [InvoiceID] HAVING COUNT(*) &gt; 1.
        /// </summary>
        internal static string TestResource_SourceQuery_acbe73c08028489ba4b1f63d28e9b706
        {
            get
            {
                return ResourceManager.GetString("TestResource_SourceQuery_acbe73c08028489ba4b1f63d28e9b706", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT &apos;[Application].[PaymentMethods]&apos; AS TableName, COUNT(*) AS NumberOfRows FROM [Application].[PaymentMethods] 
        ///.
        /// </summary>
        internal static string TestResource_SourceQuery_ce90f3f781e746e29089d6a7932e31ef
        {
            get
            {
                return ResourceManager.GetString("TestResource_SourceQuery_ce90f3f781e746e29089d6a7932e31ef", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT [ColdRoomSensorNumber], STDEV([Temperature]) AS StandardDeviation FROM [Warehouse].[ColdRoomTemperatures] GROUP BY [ColdRoomSensorNumber] HAVING STDEV([Temperature]) &gt; 1.
        /// </summary>
        internal static string TestResource_StandardDeviationQuery_c5e05ae3eeb8448cb05f8e5e9ff50e98
        {
            get
            {
                return ResourceManager.GetString("TestResource_StandardDeviationQuery_c5e05ae3eeb8448cb05f8e5e9ff50e98", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT &apos;[Dimension].[Payment Method]&apos; AS TableName, COUNT(*) AS NumberOfRows FROM [Dimension].[Payment Method] WHERE ([Valid To] = &apos;9999-12-31 23:59:59.9999999&apos; AND [Lineage Key] = 4)
        ///.
        /// </summary>
        internal static string TestResource_TargetQuery_c7e08fdf7c034e2c90b7b4e20f5164dd
        {
            get
            {
                return ResourceManager.GetString("TestResource_TargetQuery_c7e08fdf7c034e2c90b7b4e20f5164dd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ValidationManifest_88f1cc585d884547a3f3014e7efc3129
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ValidationManifest_88f1cc585d884547a3f3014e7efc3129", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_ValidationManifest_f0ff97a3657a40c69043fa8b85dbf7c3
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_ValidationManifest_f0ff97a3657a40c69043fa8b85dbf7c3", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_WideWorldImporters_41e6c71419f7453cbf0c35f50ab94707
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_WideWorldImporters_41e6c71419f7453cbf0c35f50ab94707", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type Byte[].
        /// </summary>
        internal static byte[] TestResource_WideWorldImportersDW_9e990a18f179475e9a24eca7ef66ba76
        {
            get
            {
                object obj = ResourceManager.GetObject("TestResource_WideWorldImportersDW_9e990a18f179475e9a24eca7ef66ba76", resourceCulture);
                return ((byte[])(obj));
            }
        }
    }
}
