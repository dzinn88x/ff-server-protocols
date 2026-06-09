using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A08 RID: 2568
	[Token(Token = "0x2000A08")]
	[ProtoContract]
	public class GameModeNameDesc
	{
		// Token: 0x06002712 RID: 10002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x21BA730", Offset = "0x21BA730", VA = "0x7BBC9BA730")]
		public GameModeNameDesc()
		{
		}

		// Token: 0x04002EF0 RID: 12016
		[Token(Token = "0x4002EF0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E500", Offset = "0x111E500")]
		public uint mode_id;

		// Token: 0x04002EF1 RID: 12017
		[Token(Token = "0x4002EF1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E514", Offset = "0x111E514")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E514", Offset = "0x111E514")]
		public string language;

		// Token: 0x04002EF2 RID: 12018
		[Token(Token = "0x4002EF2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E564", Offset = "0x111E564")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E564", Offset = "0x111E564")]
		public string translation;
	}
}
