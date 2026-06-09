using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000724 RID: 1828
	[Token(Token = "0x2000724")]
	[ProtoContract]
	public class CSFeedPetReq
	{
		// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x21B136C", Offset = "0x21B136C", VA = "0x7BBC9B136C")]
		public CSFeedPetReq()
		{
		}

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C210", Offset = "0x110C210")]
		public uint pet_id;

		// Token: 0x04002457 RID: 9303
		[Token(Token = "0x4002457")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C224", Offset = "0x110C224")]
		public uint food_id;

		// Token: 0x04002458 RID: 9304
		[Token(Token = "0x4002458")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C238", Offset = "0x110C238")]
		public uint food_num;
	}
}
