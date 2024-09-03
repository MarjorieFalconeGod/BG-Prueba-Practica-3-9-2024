using BG_Marjorie_Falcone_Godoy_392024.Models;

namespace BG_Marjorie_Falcone_Godoy_392024.Service
{
    internal interface IUserService
    {
        Task<IResult> Actualizar(User user);
        Task<IResult> ConsultarTodos();
        Task<IResult> Registrar(User user);
        Task<IResult> ver(int codigo);
    }
}