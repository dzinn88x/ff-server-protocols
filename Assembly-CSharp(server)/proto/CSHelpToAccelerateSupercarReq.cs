using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000990 RID: 2448
	[Token(Token = "0x2000990")]
	[ProtoContract]
	public class CSHelpToAccelerateSupercarReq
	{
		// Token: 0x0600269E RID: 9886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x21B63FC", Offset = "0x21B63FC", VA = "0x7BBC9B63FC")]
		public CSHelpToAccelerateSupercarReq()
		{
		}

		// Token: 0x04002C4B RID: 11339
		[Token(Token = "0x4002C4B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119E74", Offset = "0x1119E74")]
		public uint car_id;

		// Token: 0x04002C4C RID: 11340
		[Token(Token = "0x4002C4C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119E88", Offset = "0x1119E88")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1119E88", Offset = "0x1119E88")]
		public string helper_name;

		// Token: 0x04002C4D RID: 11341
		[Token(Token = "0x4002C4D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119ED8", Offset = "0x1119ED8")]
		public ulong helpee_id;
	}
}
