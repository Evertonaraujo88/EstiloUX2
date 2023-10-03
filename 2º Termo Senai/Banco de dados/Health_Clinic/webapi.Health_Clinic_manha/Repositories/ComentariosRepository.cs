using webapi.Health_Clinic_manha.Context;
using webapi.Health_Clinic_manha.Domains;
using webapi.Health_Clinic_manha.Interfaces;

namespace webapi.Health_Clinic_manha.Repositories
{
    public class ComentariosRepository : IComentariosRepository
    {
        private readonly HealthContext _healthContext;

        public ComentariosRepository()
        {
            _healthContext = new HealthContext();
        }


        public void Atualizar(Guid id, ComentariosDomain comentario)
        {
            throw new NotImplementedException();
        }

        public ComentariosDomain BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(ComentariosDomain comentario)
        {
            try
            {
                _healthContext.Comentarios.Add(comentario);

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
                ComentariosDomain comentarioBuscado = _healthContext.Comentarios.Find(id)!;

                //se o usuario encontrado for diferente de nulo, remove e depois salva.
                if (comentarioBuscado != null)
                {
                    _healthContext.Comentarios.Remove(comentarioBuscado);

                }

                _healthContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ComentariosDomain> Listar()
        {
            try
            {
                List<ComentariosDomain> ListaComentarios = new List<ComentariosDomain>();
                ListaComentarios = _healthContext.Comentarios
                    .Select(u => new ComentariosDomain
                    {
                        IdComentario = u.IdComentario,
                        Descricao = u.Descricao,
                        Exibe= u.Exibe,

                        Paciente = new PacienteDomain 
                        {
                            IdPaciente= u.IdPaciente,
                            
                        },

                        Consulta = new ConsultaDomain 
                        {
                            IdConsulta= u.IdConsulta,
                        },


                    })
                    .ToList();

                return (ListaComentarios);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}

