using Senai.CodeTur.Dominio.Entidades;
using Senai.CodeTur.Dominio.Interfaces.Repositorios;
using Senai.CodeTur.Infra.Data.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Senai.CodeTur.Teste.XUnit.Repositorios
{
    public class TesteUsuario
    {
        private IUsuarioRepositorio _repositorioUsuario;

        public TesteUsuario()
        {
            _repositorioUsuario = new UsuarioRepositorio();
        }

        [Fact]
        public void VerficaUsuarioEInvalido()
        {
            var validacao = _repositorioUsuario.EfetuarLogin("admin@gmail.com", "12345");

            Assert.Null(validacao);
        }

        [Fact]
        public void VerificaSeUsuarioEValido()
        {
            var validacao = _repositorioUsuario.EfetuarLogin("admin@codetur.com", "Codetur@132");

            Assert.NotNull(validacao);
        }

        [Fact]
        public void VerificarSeUsuarioEValidoEInfoCorretas()
        {
            UsuarioDominio usuario = new UsuarioDominio()
            {
                Email = "admin@codetur.com",
                Senha = "Codetur@132"
            };

            UsuarioDominio usuarioRetorno = _repositorioUsuario
                                                .EfetuarLogin(usuario.Email, usuario.Senha);

            Assert.Equal(usuarioRetorno.Email, usuario.Email);
            Assert.Equal(usuarioRetorno.Senha, usuario.Senha);
        }
    }
}
