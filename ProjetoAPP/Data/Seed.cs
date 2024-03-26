using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProjetoAPP.Data.Enum;
using ProjetoAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAPP.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.Clubes.Any())
                {
                    context.Clubes.AddRange(new List<Clube>()
                    {
                        new Clube()
                        {
                            Titulo = "Clube de Corrida 1",
                            Imagem = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Descricao = "Essa e a descricao do clube",
                            ClubeCategoria = ClubeCategoria.Cidade,
                            Endereco = new Endereco()
                            {
                                Rua = "123 Avenida Aguiar",
                                Cidade = "São Vicente",
                                Estado = "SP"
                            }
                         },
                        new Clube()
                        {
                            Titulo = "Clube de Corrida 2",
                            Imagem = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Descricao = "Essa e a descricao do clube",
                            ClubeCategoria = ClubeCategoria.Resistencia,
                            Endereco = new Endereco()
                            {
                                Rua = "123 Avenida Contorno",
                                Cidade = "São Vicente",
                                Estado = "SP"
                            }
                        },
                        new Clube()
                        {
                            Titulo = "Clube de Corrida 3",
                            Imagem = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Descricao = "Essa e a descricao do clube",
                            ClubeCategoria = ClubeCategoria.Trilha,
                            Endereco = new Endereco()
                            {
                                Rua = "123 Avenida Adornos",
                                Cidade = "Praia Grande",
                                Estado = "SP"
                            }
                        },
                        new Clube()
                        {
                            Titulo = "Clube de Corrida 4",
                            Imagem = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Descricao = "Essa e a descricao do clube",
                            ClubeCategoria = ClubeCategoria.Cidade,
                            Endereco = new Endereco()
                            {
                                Rua = "123 Avenida Alexandra de Gusmão",
                                Cidade = "Praia Grande",
                                Estado = "SP"
                            }
                        }
                    });
                    context.SaveChanges();
                }
                //Corridas
                if (!context.Corridas.Any())
                {
                    context.Corridas.AddRange(new List<Corrida>()
                    {
                        new Corrida()
                        {
                            Titulo = "Corrida 1",
                            Imagem = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Descricao = "Essa e a descricao da primeira corrida",
                            CorridaCategoria = CorridaCategoria.Maratona,
                            Endereco = new Endereco()
                            {
                                Rua = "123 Largo Machado",
                                Cidade = "Santos",
                                Estado = "SP"
                            }
                        },
                        new Corrida()
                        {
                            Titulo = "Corrida 2",
                            Imagem = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                            Descricao = "Essa e a descricao da primeira corrida",
                            CorridaCategoria = CorridaCategoria.Ultra,
                            EnderecoId = 5,
                            Endereco = new Endereco()
                            {
                                Rua = "123 Praca Almirante Gago Coutinho",
                                Cidade = "Santos",
                                Estado = "SP"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
