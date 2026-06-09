using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B3E RID: 2878
	[Token(Token = "0x2000B3E")]
	[ProtoContract]
	public class LiveDesc
	{
		// Token: 0x06002846 RID: 10310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x21BBCC4", Offset = "0x21BBCC4", VA = "0x7BBC9BBCC4")]
		public LiveDesc()
		{
		}

		// Token: 0x040036A2 RID: 13986
		[Token(Token = "0x40036A2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D154", Offset = "0x112D154")]
		public uint id;

		// Token: 0x040036A3 RID: 13987
		[Token(Token = "0x40036A3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D168", Offset = "0x112D168")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D168", Offset = "0x112D168")]
		public string tab_name;

		// Token: 0x040036A4 RID: 13988
		[Token(Token = "0x40036A4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D1B8", Offset = "0x112D1B8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D1B8", Offset = "0x112D1B8")]
		public string web_link;

		// Token: 0x040036A5 RID: 13989
		[Token(Token = "0x40036A5")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D208", Offset = "0x112D208")]
		public List<LivePopupDesc> live_popup;
	}
}
