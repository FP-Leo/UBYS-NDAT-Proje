using api.DTO.Department;
using api.Models;

namespace api.Mappers
{
    public static class DepartmentMapper
    {
        public static DepartmentDto ToDepartmentDto(this Department department){
            return new DepartmentDto{
                DepartmentId = department.DepartmentId,
                DepartmentName = department.DepartmentName,
                BuildingNumber = department.BuildingNumber,
                FloorNumber = department.FloorNumber,
                FacultyName = department.FacultyName,
                HeadOfDepartmentTC = department.HeadOfDepartmentTC,
            };
        }

        public static Department ToDepartment(this DepartmentPostDto departmentPostDto){
            return new Department{
                DepartmentName = departmentPostDto.DepartmentName,
                BuildingNumber = departmentPostDto.BuildingNumber,
                FloorNumber = departmentPostDto.FloorNumber,
                FacultyName = departmentPostDto.FacultyName,
                HeadOfDepartmentTC = departmentPostDto.HeadOfDepartmentTC,
            };
        }
    }
}