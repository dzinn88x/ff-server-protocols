using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A0D RID: 2573
	[Token(Token = "0x2000A0D")]
	[ProtoContract]
	public class RandomMapDesc
	{
		// Token: 0x06002717 RID: 10007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x249F8A4", Offset = "0x249F8A4", VA = "0x7BBCC9F8A4")]
		public RandomMapDesc()
		{
		}

		// Token: 0x04002EFB RID: 12027
		[Token(Token = "0x4002EFB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E654", Offset = "0x111E654")]
		public uint match_mode;

		// Token: 0x04002EFC RID: 12028
		[Token(Token = "0x4002EFC")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E668", Offset = "0x111E668")]
		public uint game_mode;

		// Token: 0x04002EFD RID: 12029
		[Token(Token = "0x4002EFD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E67C", Offset = "0x111E67C")]
		public MapConfig map_set;

		// Token: 0x04002EFE RID: 12030
		[Token(Token = "0x4002EFE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E690", Offset = "0x111E690")]
		public List<MapConfig> maps;
	}
}
