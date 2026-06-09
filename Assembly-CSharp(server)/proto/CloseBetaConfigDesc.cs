using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A34 RID: 2612
	[Token(Token = "0x2000A34")]
	[ProtoContract]
	public class CloseBetaConfigDesc
	{
		// Token: 0x0600273E RID: 10046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273E")]
		[Address(RVA = "0x21B8E60", Offset = "0x21B8E60", VA = "0x7BBC9B8E60")]
		public CloseBetaConfigDesc()
		{
		}

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111FD38", Offset = "0x111FD38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FD38", Offset = "0x111FD38")]
		public string region;

		// Token: 0x04002FA6 RID: 12198
		[Token(Token = "0x4002FA6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FD88", Offset = "0x111FD88")]
		public EAccount.CBSwitchStatus switch_status;

		// Token: 0x04002FA7 RID: 12199
		[Token(Token = "0x4002FA7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FD9C", Offset = "0x111FD9C")]
		public List<string> versions;

		// Token: 0x04002FA8 RID: 12200
		[Token(Token = "0x4002FA8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FDB0", Offset = "0x111FDB0")]
		public uint platform;

		// Token: 0x04002FA9 RID: 12201
		[Token(Token = "0x4002FA9")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FDC4", Offset = "0x111FDC4")]
		public EAccount.TrialSwitchStatus trial_status;
	}
}
