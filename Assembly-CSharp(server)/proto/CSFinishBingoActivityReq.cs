using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007CB RID: 1995
	[Token(Token = "0x20007CB")]
	[ProtoContract]
	public class CSFinishBingoActivityReq
	{
		// Token: 0x060024DA RID: 9434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x21B1464", Offset = "0x21B1464", VA = "0x7BBC9B1464")]
		public CSFinishBingoActivityReq()
		{
		}

		// Token: 0x0400261E RID: 9758
		[Token(Token = "0x400261E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F1CC", Offset = "0x110F1CC")]
		public uint activity_id;

		// Token: 0x0400261F RID: 9759
		[Token(Token = "0x400261F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F1E0", Offset = "0x110F1E0")]
		public uint key_id;

		// Token: 0x04002620 RID: 9760
		[Token(Token = "0x4002620")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110F1F4", Offset = "0x110F1F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F1F4", Offset = "0x110F1F4")]
		public string language;
	}
}
