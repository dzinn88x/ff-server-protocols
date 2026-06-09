using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AF0 RID: 2800
	[Token(Token = "0x2000AF0")]
	[ProtoContract]
	public class NewPlayerSevenDaysAwardDesc
	{
		// Token: 0x060027F8 RID: 10232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x249EB18", Offset = "0x249EB18", VA = "0x7BBCC9EB18")]
		public NewPlayerSevenDaysAwardDesc()
		{
		}

		// Token: 0x040034CC RID: 13516
		[Token(Token = "0x40034CC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129414", Offset = "0x1129414")]
		public uint achievement_id;

		// Token: 0x040034CD RID: 13517
		[Token(Token = "0x40034CD")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129428", Offset = "0x1129428")]
		public uint day_id;

		// Token: 0x040034CE RID: 13518
		[Token(Token = "0x40034CE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112943C", Offset = "0x112943C")]
		public uint[] achievement_id_array;

		// Token: 0x040034CF RID: 13519
		[Token(Token = "0x40034CF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129478", Offset = "0x1129478")]
		public List<ExchangedAward> awards;
	}
}
