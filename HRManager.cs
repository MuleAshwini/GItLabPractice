﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BOL;
using DAL;
//comment added
//omkar comment added
//Comment added Ashwini
<<<<<<< HEAD
//extra comment added again by omkar jadhav
=======
// This is Omkar Ganjave Adding comment

>>>>>>> fc081919a9906dbb8a8714f2a70cf1d8c31f9391
namespace BLL
{
	//hello this is HRManager class
	public class Point
<<<<<<< HEAD
	{
		public int X { get; set; }
=======
	{ 
	
	 public int X { get; set; }
>>>>>>> dabf4254ea7dcbdbe7b540e776e37bd08c7de410
		public int Y { get; set; }

		public Point
			{

            }
	}
<<<<<<< HEAD




	//employee class added
	public class Employee
    {
		public int EmpId { get; set;}
		public String EmpName { get; set; }
    }

	s

=======
	
>>>>>>> 24a20793333864bb311755f3086a800556b7318e
	public class HRManager
    { 
		public static List<Employee> GetAll()
		{
			//YOu can put your business Logic code here before sending data to outer layer
			//return EmployeeDAL.GetAll();
			return EmployeeDALDisConnected.GetAll();

		}
		public static bool Insert(Employee emp)
		{
			//YOu can put your business Logic code here before sending data to outer layer
			//return EmployeeDAL.Insert(emp);
			return EmployeeDALDisConnected.Insert(emp);
		}

		public static bool Update(Employee empToUpdate)
		{
			//YOu can put your business Logic code here before sending data to outer layer
			//return EmployeeDAL.Update(empToUpdate);
			return EmployeeDALDisConnected.Update(empToUpdate);
		}
		public static bool Delete(int id)
		{
			//YOu can put your business Logic code here before sending data to outer layer
			//	return EmployeeDAL.Delete(id);
			return EmployeeDALDisConnected.Delete(id);
		}
		public static Employee GetByID(int id)
		{ 
			//YOu can put your business Logic code here before sending data to outer layer
			//return EmployeeDAL.GetByID(id);
			return EmployeeDALDisConnected.GetById(id);	
		}
	}
}
// mayur