using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {


        private readonly HealthContext _healthContext;

        public MedicoRepository()
        {
            _healthContext = new HealthContext();
        }

        public void Atualizar(Guid id, MedicoDomain medico)
        {
            {
                throw new NotImplementedException();
            }
        }

        public MedicoDomain BuscarPorId(Guid id)
        {


            try
            {
                MedicoDomain medicoBuscado = _healthContext.Medico.FirstOrDefault(u => u.IdMedico == id)!;

                if (medicoBuscado == null)
                {
                    throw new Exception($"O médico com o ID {id} não foi encontrado");

                }
                 return (medicoBuscado);
            }
            catch (Exception)
            {
                throw;
            }

               //.Select(u => new MedicoDomain
               // {
               //     IdMedico = u.IdMedico,
               //     CRM = u.CRM,
               //     NomeMedico = u.NomeMedico,
               //     IdEspecialidade = u.IdEspecialidade,


               // })
        }

        public void Cadastrar(MedicoDomain medico)
        {
            try
            {
                medico.IdMedico = Guid.NewGuid();

                _healthContext.Medico.Add(medico);

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
                MedicoDomain medicoBuscado = _healthContext.Medico.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (medicoBuscado != null)
                {
                    _healthContext.Medico.Remove(medicoBuscado);
                }

                _healthContext.SaveChanges();
            }

            catch (Exception)
            {
                throw;
            }
        }

        public List<MedicoDomain> Listar()
        {
            try
            {
                List<MedicoDomain> ListaMedico = new List<MedicoDomain>();
                ListaMedico = _healthContext.Medico
                    .Select(u => new MedicoDomain
                    {

                        IdMedico = u.IdMedico,
                        CRM = u.CRM,
                        NomeMedico = u.NomeMedico,

                        Especialidades = new EspecialidadesDomain
                        {
                            IdEspecialidade = u.IdEspecialidade,
                            NomeEspecialidade = u.Especialidades.NomeEspecialidade
                        },

                        Usuario = new UsuarioDomain
                        {
                            IdUsuario = u.IdUsuario,
                        },

                        Clinica = new ClinicaDomain
                        {
                            IdClinica = u.IdClinica,
                        }
                    })
                    .ToList();

                return (ListaMedico);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<MedicoDomain> BuscarPorEspecialidade(string especialidadeDesejada)
        {
            try
            {
                // Primeiro, obtenha a lista de especialidades do EspecialidadesRepository.
                List<EspecialidadesDomain> especialidades = _healthContext.Especialidades.ToList();

                // Em seguida, filtre os médicos com base na especialidade desejada.
                List<MedicoDomain> medicosComEspecialidade = _healthContext.Medico
                    .Where(u => u.Especialidades != null && u.Especialidades.NomeEspecialidade == especialidadeDesejada)
                    .Select(u => new MedicoDomain
                    {
                        IdMedico = u.IdMedico,
                        CRM = u.CRM,
                        NomeMedico = u.NomeMedico,
                        IdEspecialidade = u.IdEspecialidade
                    })
                    .ToList();

                return medicosComEspecialidade;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<MedicoDomain> BuscarPorEspecialidade(MedicoDomain especialidadeDesejada)
        {
            throw new NotImplementedException();
        }

        MedicoDomain IMedicoRepository.BuscarPorEspecialidade(MedicoDomain especialidade)
        {
            throw new NotImplementedException();
        }


        //public MedicoDomain BuscarPorEspecialidade(MedicoDomain especialidade)
        //{




        //try
        //{
        //    List<MedicoDomain> ListaMedico = new List<MedicoDomain>();
        //      ListaMedico = _healthContext.Medico.Select(u => new MedicoDomain
        //    {
        //        IdMedico = u.IdMedico,
        //        CRM = u.CRM,
        //        NomeMedico = u.NomeMedico,
        //        IdEspecialidade = u.IdEspecialidade,


        //    }).Where(z => z.IdEspecialidade == especialidade.IdEspecialidade).ToString().ToList();

        //    return(ListaMedico);

        //}
        //catch (Exception)
        //{
        //    throw;
        //}

        //    try
        //{
        //    MedicoDomain medicoBuscado = _healthContext.Medico
        //        .Select(u => new MedicoDomain
        //        {
        //            IdMedico = u.IdMedico,
        //            CRM = u.CRM,
        //            NomeMedico = u.NomeMedico,
        //            IdEspecialidade = u.IdEspecialidade,


        //        }).FirstOrDefault(u => u.IdMedico == especialidade.IdMedico)!;

        //    if (medicoBuscado != null)
        //    {
        //        return (medicoBuscado);

        //    }
        //    return null!;
        //}
        //catch (Exception)
        //{
        //    throw;
        //}

        //_healthContext.Medico.Where(z => z.IdEspecialidade == especialidade.IdEspecialidade).ToList();





        //}





    }


}

