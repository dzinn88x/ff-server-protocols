using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000896 RID: 2198
	[Token(Token = "0x2000896")]
	[ProtoContract]
	public class CSGetEPArchivesInfoRes
	{
		// Token: 0x060025A4 RID: 9636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A4")]
		[Address(RVA = "0x21B316C", Offset = "0x21B316C", VA = "0x7BBC9B316C")]
		public CSGetEPArchivesInfoRes()
		{
		}

		// Token: 0x040028F4 RID: 10484
		[Token(Token = "0x40028F4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113DA8", Offset = "0x1113DA8")]
		public List<EPArchiveInfo> ep_archives_info;
	}
}
