SELECT
    P.ProductName,
    COALESCE(C.CategoryName, 'No Category') AS CategoryName
FROM Products P 
LEFT JOIN ProductCategories PC ON P.ProductId = PC.ProductId
LEFT JOIN Categories C ON PC.CategoryId = C.CategoryId
ORDER BY P.ProductName, C.CategoryName;