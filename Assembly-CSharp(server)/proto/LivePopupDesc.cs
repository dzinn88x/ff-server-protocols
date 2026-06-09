using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B3D RID: 2877
	[Token(Token = "0x2000B3D")]
	[ProtoContract]
	public class LivePopupDesc
	{
		// Token: 0x06002845 RID: 10309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x21BBD48", Offset = "0x21BBD48", VA = "0x7BBC9BBD48")]
		public LivePopupDesc()
		{
		}

		// Token: 0x0400369F RID: 13983
		[Token(Token = "0x400369F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112D0DC", Offset = "0x112D0DC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D0DC", Offset = "0x112D0DC")]
		public string tips;

		// Token: 0x040036A0 RID: 13984
		[Token(Token = "0x40036A0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D12C", Offset = "0x112D12C")]
		public uint tips_start_time;

		// Token: 0x040036A1 RID: 13985
		[Token(Token = "0x40036A1")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112D140", Offset = "0x112D140")]
		public uint tips_end_time;
	}
}
