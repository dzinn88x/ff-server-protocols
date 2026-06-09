using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ADB RID: 2779
	[Token(Token = "0x2000ADB")]
	[ProtoContract]
	public class LiveTableNameDesc
	{
		// Token: 0x060027E3 RID: 10211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x21BBDA4", Offset = "0x21BBDA4", VA = "0x7BBC9BBDA4")]
		public LiveTableNameDesc()
		{
		}

		// Token: 0x04003431 RID: 13361
		[Token(Token = "0x4003431")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128028", Offset = "0x1128028")]
		public ELive.VideoType id;

		// Token: 0x04003432 RID: 13362
		[Token(Token = "0x4003432")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112803C", Offset = "0x112803C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112803C", Offset = "0x112803C")]
		public string content;

		// Token: 0x04003433 RID: 13363
		[Token(Token = "0x4003433")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112808C", Offset = "0x112808C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112808C", Offset = "0x112808C")]
		public string language;
	}
}
