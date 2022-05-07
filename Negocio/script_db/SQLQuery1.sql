use CATALOGO_DB
Go

select * from ARTICULOS
Go
select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion, C.Descripcion, A.Precio, A.ImagenUrl from ARTICULOS A, MARCAS M, CATEGORIAS C where M.Id = A.IdMarca AND C.Id = A.IdCategoria
Go
select * from CATEGORIAS
Go

select * from MARCAS
Go

