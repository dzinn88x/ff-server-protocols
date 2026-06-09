using System;
using GCommon;
using Il2CppDummyDll;

namespace COW.GamePlay
{
	// Token: 0x02002B2B RID: 11051
	[Token(Token = "0x2002B2B")]
	internal class tKT|HYT : LoadingProcess
	{
		// Token: 0x0600F2AF RID: 62127 RVA: 0x00045858 File Offset: 0x00043A58
		[Token(Token = "0x600F2AF")]
		[Address(RVA = "0x1ABEC2C", Offset = "0x1ABEC2C", VA = "0x7BBC2BEC2C", Slot = "4")]
		public override bool IsMainProcess()
		{
			return default(bool);
		}

		// Token: 0x0600F2B0 RID: 62128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2B0")]
		[Address(RVA = "0x1ABEC34", Offset = "0x1ABEC34", VA = "0x7BBC2BEC34", Slot = "5")]
		protected override void OnStartProcess()
		{
		}

		// Token: 0x0600F2B1 RID: 62129 RVA: 0x00045870 File Offset: 0x00043A70
		[Token(Token = "0x600F2B1")]
		[Address(RVA = "0x1ABEC3C", Offset = "0x1ABEC3C", VA = "0x7BBC2BEC3C", Slot = "6")]
		protected override LoadingProcess.EProcessStatus OnUpdateProcess()
		{
			return LoadingProcess.EProcessStatus.NotStarted;
		}

		// Token: 0x0600F2B2 RID: 62130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2B2")]
		[Address(RVA = "0x1ABEC5C", Offset = "0x1ABEC5C", VA = "0x7BBC2BEC5C")]
		public tKT|HYT()
		{
		}

		// Token: 0x04011821 RID: 71713
		[Token(Token = "0x4011821")]
		[FieldOffset(Offset = "0x14")]
		private bool CekAAy~;
	}
}
