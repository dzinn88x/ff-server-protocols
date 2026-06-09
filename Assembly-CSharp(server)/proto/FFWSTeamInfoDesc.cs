using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B48 RID: 2888
	[Token(Token = "0x2000B48")]
	[ProtoContract]
	public class FFWSTeamInfoDesc
	{
		// Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x21BA264", Offset = "0x21BA264", VA = "0x7BBC9BA264")]
		public FFWSTeamInfoDesc()
		{
		}

		// Token: 0x040036E3 RID: 14051
		[Token(Token = "0x40036E3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D8FC", Offset = "0x112D8FC")]
		public uint team_id;

		// Token: 0x040036E4 RID: 14052
		[Token(Token = "0x40036E4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D910", Offset = "0x112D910")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D910", Offset = "0x112D910")]
		public string team_icon;

		// Token: 0x040036E5 RID: 14053
		[Token(Token = "0x40036E5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D960", Offset = "0x112D960")]
		public uint weight;

		// Token: 0x040036E6 RID: 14054
		[Token(Token = "0x40036E6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D974", Offset = "0x112D974")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D974", Offset = "0x112D974")]
		public string url;

		// Token: 0x040036E7 RID: 14055
		[Token(Token = "0x40036E7")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D9C4", Offset = "0x112D9C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D9C4", Offset = "0x112D9C4")]
		public string team_name;
	}
}
