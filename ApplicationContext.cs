using Fornecedores.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fornecedores
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Populando a entidade Estado com inicialmente todos os estados para o Brasil
            modelBuilder.Entity<Estado>().HasKey(t => t.EstadoId);
            modelBuilder.Entity<Estado>().HasData(
                    new Estado { EstadoId = 1 , SiglaEstado = "AC", DescricaoEstado = "Acre"                },
                    new Estado { EstadoId = 2 , SiglaEstado = "AL", DescricaoEstado = "Alagoas"             },
                    new Estado { EstadoId = 3 , SiglaEstado = "AP", DescricaoEstado = "Amapá"               },
                    new Estado { EstadoId = 4 , SiglaEstado = "AM", DescricaoEstado = "Amazonas"            },
                    new Estado { EstadoId = 5 , SiglaEstado = "BA", DescricaoEstado = "Bahia"               },
                    new Estado { EstadoId = 6 , SiglaEstado = "CE", DescricaoEstado = "Ceará"               },
                    new Estado { EstadoId = 7 , SiglaEstado = "ES", DescricaoEstado = "Espirito Santo"      },
                    new Estado { EstadoId = 8 , SiglaEstado = "GO", DescricaoEstado = "Goiás"               },
                    new Estado { EstadoId = 9 , SiglaEstado = "MA", DescricaoEstado = "Maranhão"            },
                    new Estado { EstadoId = 10, SiglaEstado = "MT", DescricaoEstado = "Mato Grosso"         },
                    new Estado { EstadoId = 11, SiglaEstado = "MS", DescricaoEstado = "Mato Grosso do Sul"  },
                    new Estado { EstadoId = 12, SiglaEstado = "MG", DescricaoEstado = "Minas Gerais"        },
                    new Estado { EstadoId = 13, SiglaEstado = "PA", DescricaoEstado = "Pará"                },
                    new Estado { EstadoId = 14, SiglaEstado = "PB", DescricaoEstado = "Paraíba"             },
                    new Estado { EstadoId = 15, SiglaEstado = "PR", DescricaoEstado = "Paraná"              },
                    new Estado { EstadoId = 16, SiglaEstado = "PE", DescricaoEstado = "Pernambuco"          },
                    new Estado { EstadoId = 17, SiglaEstado = "PI", DescricaoEstado = "Piauí"               },
                    new Estado { EstadoId = 18, SiglaEstado = "RJ", DescricaoEstado = "Rio de Janeiro"      },
                    new Estado { EstadoId = 19, SiglaEstado = "RN", DescricaoEstado = "Rio Grande do Norte" },
                    new Estado { EstadoId = 20, SiglaEstado = "RS", DescricaoEstado = "Rio Grande do Sul"   },
                    new Estado { EstadoId = 21, SiglaEstado = "RO", DescricaoEstado = "Rondônia"            },
                    new Estado { EstadoId = 22, SiglaEstado = "RR", DescricaoEstado = "Roraima"             },
                    new Estado { EstadoId = 23, SiglaEstado = "SC", DescricaoEstado = "Santa Catarina"      },
                    new Estado { EstadoId = 24, SiglaEstado = "SP", DescricaoEstado = "São Paulo"           },
                    new Estado { EstadoId = 25, SiglaEstado = "SE", DescricaoEstado = "Sergipe"             },
                    new Estado { EstadoId = 26, SiglaEstado = "TO", DescricaoEstado = "Tocantins"           },
                    new Estado { EstadoId = 27, SiglaEstado = "DF", DescricaoEstado = "Distrito Federal"    }
                );

            modelBuilder.Entity<Telefone>().HasKey(t => t.TelefoneId);
            modelBuilder.Entity<Empresa>().HasKey(t => t.EmpresaId);
            modelBuilder.Entity<Fornecedor>().HasKey(t => t.FornecedorId);

        }
    }
}
