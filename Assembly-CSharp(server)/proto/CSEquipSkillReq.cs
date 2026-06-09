using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000805 RID: 2053
	[Token(Token = "0x2000805")]
	[ProtoContract]
	public class CSEquipSkillReq
	{
		// Token: 0x06002514 RID: 9492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002514")]
		[Address(RVA = "0x21B1178", Offset = "0x21B1178", VA = "0x7BBC9B1178")]
		public CSEquipSkillReq()
		{
		}

		// Token: 0x040026EE RID: 9966
		[Token(Token = "0x40026EE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11109F0", Offset = "0x11109F0")]
		public uint avatar_id;

		// Token: 0x040026EF RID: 9967
		[Token(Token = "0x40026EF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110A04", Offset = "0x1110A04")]
		public uint slot_id;

		// Token: 0x040026F0 RID: 9968
		[Token(Token = "0x40026F0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110A18", Offset = "0x1110A18")]
		public uint skill_id;

		// Token: 0x040026F1 RID: 9969
		[Token(Token = "0x40026F1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110A2C", Offset = "0x1110A2C")]
		public ulong group_id;

		// Token: 0x040026F2 RID: 9970
		[Token(Token = "0x40026F2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110A40", Offset = "0x1110A40")]
		public ulong room_id;
	}
}
