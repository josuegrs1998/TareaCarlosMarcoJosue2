use AdventureWorks2016;

create view Person.VistaRecursosHumanos 
as 
SELECT p.FirstName as PrimerNombre, ISNULL(p.MiddleName, '') as SegundoNombre, p.LastName as Apellidos, e.JobTitle as Titulo, IIF(e.Gender= 'M', 'Masculino' , 'Femenino' )
as Genero, e.HireDate as FechaContratacion, e.BirthDate as FechaNacimiento,  IIF(e.SalariedFlag = 0,'Por Hora', 'Salario') as TipoSalario,  ph.Rate as TasaSalario, 
IIF(ph.PayFrequency = 1,'Mensual', 'Quincenal') as FrecuenciaSalario, IIF(e.CurrentFlag = 0, 'Inactivo', 'Activo') as Estado, e.SickLeaveHours as HorasIndemnizadas, 
e.VacationHours as HorasVacaiones, d.DepartmentID as IDDepartamento, d.Name as Departmento, d.GroupName as GrupoDepartamento, s.ShiftID as IDTurno, s.Name as Turno
from HumanResources.Employee as e 
	inner join HumanResources.EmployeeDepartmentHistory as dh on (e.BusinessEntityID = dh.BusinessEntityID and dh.EndDate is null)
	inner join HumanResources.Department as d on (dh.DepartmentID = d.DepartmentID)
	inner join HumanResources.Shift as s on (dh.ShiftID = s.ShiftID)
	inner join 
		(select ph.BusinessEntityID, ph.Rate, ph.PayFrequency from HumanResources.EmployeePayHistory as ph
		inner join
			(select i.BusinessEntityID, MAX(i.RateChangeDate) as Date 
			from HumanResources.EmployeePayHistory as i 
			group by i.BusinessEntityID) as re on re.BusinessEntityID = ph.BusinessEntityID and re.Date = ph.RateChangeDate) 
		as ph on ph.BusinessEntityID = e.BusinessEntityID
	inner join Person.Person as p on p.BusinessEntityID = e.BusinessEntityID;