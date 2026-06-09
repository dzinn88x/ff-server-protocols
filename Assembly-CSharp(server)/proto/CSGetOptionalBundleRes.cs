using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200076F RID: 1903
	[Token(Token = "0x200076F")]
	[ProtoContract]
	public class CSGetOptionalBundleRes
	{
		// Token: 0x0600247C RID: 9340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x21B4FDC", Offset = "0x21B4FDC", VA = "0x7BBC9B4FDC")]
		public CSGetOptionalBundleRes()
		{
		}

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D87C", Offset = "0x110D87C")]
		public List<OptionalBundleShow> optional_bundle_show;
	}
}
