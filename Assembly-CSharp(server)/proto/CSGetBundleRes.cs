using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200076E RID: 1902
	[Token(Token = "0x200076E")]
	[ProtoContract]
	public class CSGetBundleRes
	{
		// Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x21B2A2C", Offset = "0x21B2A2C", VA = "0x7BBC9B2A2C")]
		public CSGetBundleRes()
		{
		}

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D868", Offset = "0x110D868")]
		public List<BundleShow> bundle_show;
	}
}
