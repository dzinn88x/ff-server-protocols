using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000828 RID: 2088
	[Token(Token = "0x2000828")]
	[ProtoContract]
	public class CSRemoveFriendRes
	{
		// Token: 0x06002537 RID: 9527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002537")]
		[Address(RVA = "0x21B73CC", Offset = "0x21B73CC", VA = "0x7BBC9B73CC")]
		public CSRemoveFriendRes()
		{
		}

		// Token: 0x04002736 RID: 10038
		[Token(Token = "0x4002736")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111030", Offset = "0x1111030")]
		public ulong remover;

		// Token: 0x04002737 RID: 10039
		[Token(Token = "0x4002737")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111044", Offset = "0x1111044")]
		public ulong removee;

		// Token: 0x04002738 RID: 10040
		[Token(Token = "0x4002738")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1111058", Offset = "0x1111058")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1111058", Offset = "0x1111058")]
		public string lock_region;

		// Token: 0x04002739 RID: 10041
		[Token(Token = "0x4002739")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11110A8", Offset = "0x11110A8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11110A8", Offset = "0x11110A8")]
		public string noti_region;
	}
}
