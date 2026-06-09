using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000EE8 RID: 3816
	[Token(Token = "0x2000EE8")]
	public class LoadingProcessManager
	{
		// Token: 0x0600352F RID: 13615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600352F")]
		[Address(RVA = "0x2120AA0", Offset = "0x2120AA0", VA = "0x7BBC920AA0")]
		public void Start(LoadingProcess[] processes, Action<bool, int> finishedHandler)
		{
		}

		// Token: 0x06003530 RID: 13616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003530")]
		[Address(RVA = "0x2120E0C", Offset = "0x2120E0C", VA = "0x7BBC920E0C")]
		public void Update()
		{
		}

		// Token: 0x06003531 RID: 13617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003531")]
		[Address(RVA = "0x2120CC8", Offset = "0x2120CC8", VA = "0x7BBC920CC8")]
		private void StartNextProcess()
		{
		}

		// Token: 0x06003532 RID: 13618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003532")]
		[Address(RVA = "0x2120B94", Offset = "0x2120B94", VA = "0x7BBC920B94")]
		private void DispachFinishedEvent(bool result, int exceptionProcessIndex = -1)
		{
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x6003533")]
		[Address(RVA = "0x2120B84", Offset = "0x2120B84", VA = "0x7BBC920B84")]
		private bool HasProcesses()
		{
			return default(bool);
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003534")]
		[Address(RVA = "0x2120F94", Offset = "0x2120F94", VA = "0x7BBC920F94")]
		public LoadingProcessManager()
		{
		}

		// Token: 0x0400489A RID: 18586
		[Token(Token = "0x400489A")]
		[FieldOffset(Offset = "0x10")]
		private LoadingProcess[] m_Processes;

		// Token: 0x0400489B RID: 18587
		[Token(Token = "0x400489B")]
		[FieldOffset(Offset = "0x18")]
		private int m_LastMainProcessIndex;

		// Token: 0x0400489C RID: 18588
		[Token(Token = "0x400489C")]
		[FieldOffset(Offset = "0x20")]
		private Action<bool, int> m_FinshedHandler;
	}
}
