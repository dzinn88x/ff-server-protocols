using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000726 RID: 1830
	[Token(Token = "0x2000726")]
	[ProtoContract]
	public class CSSelectPetReq
	{
		// Token: 0x06002433 RID: 9267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x21B75D8", Offset = "0x21B75D8", VA = "0x7BBC9B75D8")]
		public CSSelectPetReq()
		{
		}

		// Token: 0x0400245E RID: 9310
		[Token(Token = "0x400245E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C2B0", Offset = "0x110C2B0")]
		public uint pet_id;

		// Token: 0x0400245F RID: 9311
		[Token(Token = "0x400245F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C2C4", Offset = "0x110C2C4")]
		public bool is_selected;
	}
}
