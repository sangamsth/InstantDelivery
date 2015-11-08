﻿using InstantDelivery.Core.Entities;
using System.Linq;

namespace InstantDelivery.Services
{
    /// <summary>
    /// Interfejs warstwy serwisu pracowników
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Dodaje pracownika do bazy danych
        /// </summary>
        /// <param name="employee"></param>
        void AddEmployee(Employee employee);
        /// <summary>
        /// Zwraca wszystkich pracowników z bazy danych
        /// </summary>
        /// <returns></returns>
        IQueryable<Employee> GetAll();
        /// <summary>
        /// Aktualizuje dane pracownika
        /// </summary>
        /// <param name="employee"></param>
        void Reload(Employee employee);
        /// <summary>
        /// Usuwa pracownika z bazy danych
        /// </summary>
        /// <param name="employee"></param>
        void RemoveEmployee(Employee employee);
        /// <summary>
        /// Zapisuje aktualny stan kontekstu
        /// </summary>
        void Save();
        /// <summary>
        /// Zmienia pojazd przypisany do pracownika
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="selectedVehicle"></param>
        void ChangeEmployeesVehicle(Employee employee, Vehicle selectedVehicle);
    }
}