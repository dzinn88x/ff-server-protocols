using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A15 RID: 2581
	[Token(Token = "0x2000A15")]
	[ProtoContract]
	public class RoomNumLimitDesc
	{
		// Token: 0x0600271F RID: 10015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x24A03E4", Offset = "0x24A03E4", VA = "0x7BBCCA03E4")]
		public RoomNumLimitDesc()
		{
		}

		// Token: 0x04002F1B RID: 12059
		[Token(Token = "0x4002F1B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E960", Offset = "0x111E960")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E960", Offset = "0x111E960")]
		public string region;

		// Token: 0x04002F1C RID: 12060
		[Token(Token = "0x4002F1C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E9B0", Offset = "0x111E9B0")]
		public uint max_in_game_room_num;

		// Token: 0x04002F1D RID: 12061
		[Token(Token = "0x4002F1D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E9C4", Offset = "0x111E9C4")]
		public uint tab_type;
	}
}
