using Loja.Modules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NFe.Testes.Gerais
{
	[TestClass]
	public class NfceStateMachineTests
	{
		[TestMethod]
		public void Deve_Permitir_Transicao_Contingencia_Para_Autorizada()
		{
			Assert.IsTrue(NfceStateMachine.CanTransition("C", "A"));
		}

		[TestMethod]
		public void Deve_Bloquear_Transicao_Autorizada_Para_Contingencia()
		{
			Assert.IsFalse(NfceStateMachine.CanTransition("A", "C"));
		}

		[TestMethod]
		public void Deve_Permitir_Cancelamento_De_Autorizada()
		{
			Assert.IsTrue(NfceStateMachine.CanTransition("A", "X"));
		}
	}
}
