using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D7 RID: 2263
	[Token(Token = "0x20008D7")]
	[ProtoContract]
	public class CSGetLiveInfoRes
	{
		// Token: 0x060025E5 RID: 9701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x21B46D8", Offset = "0x21B46D8", VA = "0x7BBC9B46D8")]
		public CSGetLiveInfoRes()
		{
		}

		// Token: 0x04002A62 RID: 10850
		[Token(Token = "0x4002A62")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116E40", Offset = "0x1116E40")]
		public bool is_streamer;

		// Token: 0x04002A63 RID: 10851
		[Token(Token = "0x4002A63")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116E54", Offset = "0x1116E54")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116E54", Offset = "0x1116E54")]
		public string nickname;

		// Token: 0x04002A64 RID: 10852
		[Token(Token = "0x4002A64")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116EA4", Offset = "0x1116EA4")]
		public EInventory.GenderType sex;

		// Token: 0x04002A65 RID: 10853
		[Token(Token = "0x4002A65")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116EB8", Offset = "0x1116EB8")]
		public uint head_pic;

		// Token: 0x04002A66 RID: 10854
		[Token(Token = "0x4002A66")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116ECC", Offset = "0x1116ECC")]
		public uint banner_id;

		// Token: 0x04002A67 RID: 10855
		[Token(Token = "0x4002A67")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116EE0", Offset = "0x1116EE0")]
		public uint fan_count;
	}
}
