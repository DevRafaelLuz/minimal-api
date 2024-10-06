using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.Interfaces;

public interface iVeiculoServico {
    List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null);

    Veiculo? BuscaPorId(int id);

    void Registrar(Veiculo veiculo);
    
    void Atualizar(Veiculo veiculo);

    void ExcluirPorId(Veiculo veiculo);
}