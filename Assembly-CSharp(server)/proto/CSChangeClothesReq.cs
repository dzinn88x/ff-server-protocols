using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000807 RID: 2055
	[Token(Token = "0x2000807")]
	[ProtoContract]
	public class CSChangeClothesReq
	{
		// Token: 0x06002516 RID: 9494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002516")]
		[Address(RVA = "0x21B0638", Offset = "0x21B0638", VA = "0x7BBC9B0638")]
		public CSChangeClothesReq()
		{
		}

		// Token: 0x040026F4 RID: 9972
		[Token(Token = "0x40026F4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110A68", Offset = "0x1110A68")]
		public uint avatar_id;

		// Token: 0x040026F5 RID: 9973
		[Token(Token = "0x40026F5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110A7C", Offset = "0x1110A7C")]
		public uint[] clothes;

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110AB8", Offset = "0x1110AB8")]
		public uint skin_color;

		// Token: 0x040026F7 RID: 9975
		[Token(Token = "0x40026F7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110ACC", Offset = "0x1110ACC")]
		public ulong room_id;

		// Token: 0x040026F8 RID: 9976
		[Token(Token = "0x40026F8")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110AE0", Offset = "0x1110AE0")]
		public ulong group_id;
	}
}
