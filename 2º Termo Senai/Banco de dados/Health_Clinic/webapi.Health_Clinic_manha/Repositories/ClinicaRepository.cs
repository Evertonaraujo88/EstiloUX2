using Microsoft.EntityFrameworkCore;
using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;
using webapi.Health_Clinic_manha.Utils;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class ClinicaRepository : IClinicaRepository
    {
        private readonly HealthContext _healthContext;

        public ClinicaRepository()
        {
            _healthContext = new HealthContext();
        }


        public void Atualizar(Guid id, ClinicaDomain clinica)
        {
            try
            {
                ClinicaDomain clinicaBuscada = _healthContext.Clinica.Find(id)!;

                if (clinicaBuscada != null)
                {
                    clinicaBuscada.CNPJ = clinica.CNPJ;
                    clinicaBuscada.Endereco = clinica.Endereco;
                    clinicaBuscada.NomeFantasia = clinica.NomeFantasia;
                    clinicaBuscada.RazaoSocial = clinica.RazaoSocial;
                    clinicaBuscada.HorarioAbertura = clinica.HorarioAbertura;
                    clinicaBuscada.HorarioFechamento = clinica.HorarioFechamento;
                }

                _healthContext.Clinica.Update(clinicaBuscada!);

                _healthContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ClinicaDomain BuscarPorId(Guid id)
        {
            try
            {
                ClinicaDomain clinicaBuscada = _healthContext.Clinica
                    .Select(u => new ClinicaDomain
                    {
                        IdClinica = u.IdClinica,
                        CNPJ = u.CNPJ,
                        RazaoSocial = u.RazaoSocial,
                        NomeFantasia = u.NomeFantasia,
                        Endereco = u.Endereco,
                        HorarioAbertura = u.HorarioAbertura,
                        HorarioFechamento = u.HorarioFechamento

                    }).FirstOrDefault(u => u.IdClinica == id)!;

                if (clinicaBuscada != null)
                {
                    return (clinicaBuscada);

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(ClinicaDomain clinica)
        {
            try
            {
                clinica.IdClinica = Guid.NewGuid();

                _healthContext.Clinica.Add(clinica);

                _healthContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
                
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                //instacia um objeto na domain e faz um Find(busca) pelo id informado pelo usuario.
                ClinicaDomain clinicaBuscada = _healthContext.Clinica.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (clinicaBuscada != null)
                {
                    _healthContext.Clinica.Remove(clinicaBuscada);
                }

                _healthContext.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<ClinicaDomain> Listar()
        {
            try
            {
                List<ClinicaDomain> ListaClinica = new List<ClinicaDomain>();
                ListaClinica = _healthContext.Clinica
                    .Select(u => new ClinicaDomain
                    {
                        IdClinica = u.IdClinica,
                        CNPJ = u.CNPJ,
                        RazaoSocial = u.RazaoSocial,
                        NomeFantasia = u.NomeFantasia,
                        Endereco = u.Endereco,
                        HorarioAbertura = u.HorarioAbertura,
                        HorarioFechamento = u.HorarioFechamento
                                            
                    })
                    .ToList();

                return (ListaClinica);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
