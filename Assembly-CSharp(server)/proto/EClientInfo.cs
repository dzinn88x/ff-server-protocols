using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006D1 RID: 1745
	[Token(Token = "0x20006D1")]
	[ProtoContract]
	public class EClientInfo
	{
		// Token: 0x060023E2 RID: 9186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x21B97F8", Offset = "0x21B97F8", VA = "0x7BBC9B97F8")]
		public EClientInfo()
		{
		}

		// Token: 0x020006D2 RID: 1746
		[Token(Token = "0x20006D2")]
		[ProtoContract]
		public enum ChannelType
		{
			// Token: 0x0400226C RID: 8812
			[Token(Token = "0x400226C")]
			ChannelType_DEV,
			// Token: 0x0400226D RID: 8813
			[Token(Token = "0x400226D")]
			ChannelType_TRAIL,
			// Token: 0x0400226E RID: 8814
			[Token(Token = "0x400226E")]
			ChannelType_MAX,
			// Token: 0x0400226F RID: 8815
			[Token(Token = "0x400226F")]
			ChannelType_GP,
			// Token: 0x04002270 RID: 8816
			[Token(Token = "0x4002270")]
			ChannelType_HUAWEI,
			// Token: 0x04002271 RID: 8817
			[Token(Token = "0x4002271")]
			ChannelType_SAMSUNG,
			// Token: 0x04002272 RID: 8818
			[Token(Token = "0x4002272")]
			ChannelType_THIRDPARTY
		}

		// Token: 0x020006D3 RID: 1747
		[Token(Token = "0x20006D3")]
		[ProtoContract]
		public enum Architecture
		{
			// Token: 0x04002274 RID: 8820
			[Token(Token = "0x4002274")]
			Architecture_None,
			// Token: 0x04002275 RID: 8821
			[Token(Token = "0x4002275")]
			Architecture_ARM,
			// Token: 0x04002276 RID: 8822
			[Token(Token = "0x4002276")]
			Architecture_ARM64,
			// Token: 0x04002277 RID: 8823
			[Token(Token = "0x4002277")]
			Architecture_X86
		}
	}
}
