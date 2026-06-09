using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F93 RID: 3987
	[Token(Token = "0x2000F93")]
	public class NetworkMessageDispatcher
	{
		// Token: 0x170006E7 RID: 1767
		// (set) Token: 0x06003A0B RID: 14859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E7")]
		public bool EnableSimpleInvokeExceptionInfo
		{
			[Token(Token = "0x6003A0B")]
			[Address(RVA = "0x245DE58", Offset = "0x245DE58", VA = "0x7BBCC5DE58")]
			set
			{
			}
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0C")]
		public void RegisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
		{
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0D")]
		[Address(RVA = "0x2466F60", Offset = "0x2466F60", VA = "0x7BBCC66F60")]
		public void UnregisterHandlers(uint cmd)
		{
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0E")]
		public void UnregisterHandler<T>(uint cmd, NetworkMessageDispatcher.NetworkMessageHandler<T> handler)
		{
		}

		// Token: 0x06003A0F RID: 14863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A0F")]
		[Address(RVA = "0x246700C", Offset = "0x246700C", VA = "0x7BBCC6700C")]
		public void Clear()
		{
		}

		// Token: 0x06003A10 RID: 14864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A10")]
		[Address(RVA = "0x2467090", Offset = "0x2467090", VA = "0x7BBCC67090")]
		public Type GetCmdType(uint cmd)
		{
			return null;
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A11")]
		[Address(RVA = "0x246712C", Offset = "0x246712C", VA = "0x7BBCC6712C")]
		public void Invoke(uint cmd, object msg)
		{
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A12")]
		[Address(RVA = "0x245E2E8", Offset = "0x245E2E8", VA = "0x7BBCC5E2E8")]
		public NetworkMessageDispatcher()
		{
		}

		// Token: 0x04004BA2 RID: 19362
		[Token(Token = "0x4004BA2")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<uint, NetworkMessageHandlerPair> m_Handlers;

		// Token: 0x04004BA3 RID: 19363
		[Token(Token = "0x4004BA3")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, string> m_InvokeExceptionCmds;

		// Token: 0x04004BA4 RID: 19364
		[Token(Token = "0x4004BA4")]
		[FieldOffset(Offset = "0x20")]
		private bool m_EnableSimpleInvokeExceptionInfo;

		// Token: 0x04004BA5 RID: 19365
		[Token(Token = "0x4004BA5")]
		[FieldOffset(Offset = "0x28")]
		private object[] m_Param;

		// Token: 0x02000F94 RID: 3988
		// (Invoke) Token: 0x06003A14 RID: 14868
		[Token(Token = "0x2000F94")]
		public delegate void NetworkMessageHandler<T>(T arg);
	}
}
