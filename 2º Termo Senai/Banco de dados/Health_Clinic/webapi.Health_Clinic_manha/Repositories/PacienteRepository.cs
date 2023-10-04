using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {

        private readonly HealthContext _healthContext;

        public PacienteRepository()
        {
            _healthContext = new HealthContext();
        }


        public void Atualizar(Guid id, PacienteDomain paciente)
        {
            throw new NotImplementedException();
        }

        public PacienteDomain BuscarDataDeNascimento(DateTime dataNascimento)
        {
            throw new NotImplementedException();

            //try
            //{
            //    PacienteDomain dataBuscada = _healthContext.Paciente.Find(u => u.DataNascimento == dataNascimento).Tolist();

            //    if (dataBuscada != null)
            //    {
            //        return (dataBuscada);

            //    }
            //    return null!;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }


        public PacienteDomain BuscarPorId(Guid id)
        {
            try
            {
                PacienteDomain pacienteBuscado = _healthContext.Paciente.FirstOrDefault(u => u.IdPaciente == id)!;

                if (pacienteBuscado != null)
                {
                    return (pacienteBuscado);

                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(PacienteDomain paciente)
        {
            try
            {
                paciente.IdPaciente = Guid.NewGuid();

                _healthContext.Paciente.Add(paciente);

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
                PacienteDomain pacienteBuscado = _healthContext.Paciente.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (pacienteBuscado != null)
                {
                    _healthContext.Paciente.Remove(pacienteBuscado);
                }

                _healthContext.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<PacienteDomain> ListaDataNascimento()
        {
            throw new NotImplementedException();
        }

        public List<PacienteDomain> Listar()
        {
            try
            {
                List<PacienteDomain> ListaPaciente = new List<PacienteDomain>();
                ListaPaciente = _healthContext.Paciente
                    .Select(u => new PacienteDomain
                    {
                        IdPaciente = u.IdPaciente,
                        NomePaciente = u.NomePaciente,
                        CPF= u.CPF,
                        DataNascimento= u.DataNascimento,
                        Telefone= u.Telefone,
                        Endereco= u.Endereco,

                        Usuario = new UsuarioDomain
                        {
                            IdUsuario = u.IdUsuario,
                        }

                    })
                    .ToList();

                return (ListaPaciente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        List<PacienteDomain> BuscarDataDeNascimento()
        {
            throw new NotImplementedException();
        }
    }
}
