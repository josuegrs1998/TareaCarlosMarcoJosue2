use AdventureWorks2016;

	create view Production.VistaProducto as
	select PP.ProductID, PP.Name as Producto, PP.ProductNumber as NumeroDeProducto, PP.Color as Color, PS.Name as SubCategoria, PC.Name as Categoria, SUM(PINV.Quantity) as Cantidad, PD.Description as Description
	from Production.Product as PP
	left join Production.ProductSubcategory as PS on (PP.ProductSubcategoryID = PS.ProductSubcategoryID)
	left join Production.ProductCategory as PC on (PC.ProductCategoryID = PS.ProductCategoryID)
	left join Production.ProductInventory as PINV on (PINV.ProductID = PP.ProductID)
	left join Production.ProductModelProductDescriptionCulture as PMPDC on (PMPDC.ProductModelID = PP.ProductModelID and PMPDC.CultureID = 'en')
	left join Production.ProductDescription as PD on (PD.ProductDescriptionID = PMPDC.ProductDescriptionID)
	group by PP.ProductID, PP.Name, PP.ProductNumber, PP.Color, PS.Name, PC.Name, PD.Description
