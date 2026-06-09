using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B8 RID: 2232
	[Token(Token = "0x20008B8")]
	[ProtoContract]
	public class CSGetPayBundleWindowDescRes
	{
		// Token: 0x060025C6 RID: 9670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C6")]
		[Address(RVA = "0x21B50CC", Offset = "0x21B50CC", VA = "0x7BBC9B50CC")]
		public CSGetPayBundleWindowDescRes()
		{
		}

		// Token: 0x04002A00 RID: 10752
		[Token(Token = "0x4002A00")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116404", Offset = "0x1116404")]
		public List<PayBundleWindowDesc> pay_bundle_windows;

		// Token: 0x04002A01 RID: 10753
		[Token(Token = "0x4002A01")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116418", Offset = "0x1116418")]
		public uint next_refresh_time;
	}
}
