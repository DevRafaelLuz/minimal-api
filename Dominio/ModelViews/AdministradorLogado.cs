using MinimalApi.Dominio.ModelViews;

namespace MinimalApi.Dominio.ViewModels;

public record AdministradorLogado {
    public string Email { get; set; } = default!;
    public string Perfil { get; set; } = default!;
    public string Token { get; set; } = default!;
}