using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cifrado_Cesar;
using NUnit.Framework;

namespace Cifrado_Cesar_Test
{
    public class Cifrado_Cesar_Test
    {
        [TestFixture]
        public class Numero_Magico_Menor_Que_Cero
        {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            
            [Test]
            public void Debe_Devolver_Una_Excepcion()
            {
                var excepcion = Assert.Throws<ArgumentException>(() => SUT.Cifrado("a", -1));
                Assert.That(excepcion, Has.Message.EqualTo("número mágico menor que 0 no permitido"));
            }
        }

        [TestFixture]
        public class Numero_Magico_Cero {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            private string resultado;

            [SetUp]
            public void SetUp() {
                resultado = SUT.Cifrado("a", 0);
            }
            [Test]
            public void Debe_Devolver_a() {
                Assert.AreEqual(resultado, "a");
            }
        }

        [TestFixture]
        public class Numero_Magico_Dos_Frase_a
        {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            private string resultado;

            [SetUp]
            public void SetUp()
            {
                resultado = SUT.Cifrado("a", 2);
            }
            [Test]
            public void Debe_Devolver_c()
            {
                Assert.AreEqual(resultado, "c");
            }
        }

        [TestFixture]
        public class Numero_Magico_Dos_Frase_A
        {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            private string resultado;

            [SetUp]
            public void SetUp()
            {
                resultado = SUT.Cifrado("A", 2);
            }
            [Test]
            public void Debe_Devolver_c()
            {
                Assert.AreEqual(resultado, "c");
            }
        }

        [TestFixture]
        public class Numero_Magico_Dos_Frase_a_Con_Tilde
        {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            private string resultado;

            [SetUp]
            public void SetUp()
            {
                resultado = SUT.Cifrado("á", 2);
            }
            [Test]
            public void Debe_Devolver_a_Con_Tilde()
            {
                Assert.AreEqual(resultado, "á");
            }
        }

        [TestFixture]
        public class Numero_Magico_Espacio
        {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            private string resultado;

            [SetUp]
            public void SetUp()
            {
                resultado = SUT.Cifrado(" ", 2);
            }
            [Test]
            public void Debe_Devolver_Espacio()
            {
                Assert.AreEqual(resultado, " ");
            }
        }

        [TestFixture]
        public class Numero_Magico_Punto
        {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            private string resultado;

            [SetUp]
            public void SetUp()
            {
                resultado = SUT.Cifrado(".", 2);
            }
            [Test]
            public void Debe_Devolver_Punto()
            {
                Assert.AreEqual(resultado, ".");
            }
        }

        [TestFixture]
        public class Prueba_Final
        {
            Cifrado_Cesar.ICifrado_Cesar SUT = new Cifrado_Cesar.Cifrado_Cesar();
            private string resultado;

            [SetUp]
            public void SetUp()
            {
                resultado = SUT.Cifrado("Todo lo que se preguntaba eran las mismas respuestas que buscamos el resto de nosotros. ¿De dónde vengo? ¿A dónde voy? ¿Cuánto tiempo tengo? Todo lo que pude hacer fue sentarme y ver como moría.", 3);
            }
            [Test]
            public void Resultado_Prueba_Final()
            {
                Assert.AreEqual(resultado,
                    "wrgr or txh vh suhjxqwded hudq odv plvpdv uhvsxhvwdv txh exvfdprv ho uhvwr gh qrvrwurv. ¿gh góqgh yhqjr? ¿d góqgh yrb? ¿fxáqwr wlhpsr whqjr? wrgr or txh sxgh kdfhu ixh vhqwduph b yhu frpr pruíd."
                    );
            }
        }
    }
}
