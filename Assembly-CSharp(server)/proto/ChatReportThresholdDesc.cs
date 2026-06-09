using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B56 RID: 2902
	[Token(Token = "0x2000B56")]
	[ProtoContract]
	public class ChatReportThresholdDesc
	{
		// Token: 0x0600285E RID: 10334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285E")]
		[Address(RVA = "0x21B82D4", Offset = "0x21B82D4", VA = "0x7BBC9B82D4")]
		public ChatReportThresholdDesc()
		{
		}

		// Token: 0x04003743 RID: 14147
		[Token(Token = "0x4003743")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E748", Offset = "0x112E748")]
		public uint reported_threshold;

		// Token: 0x04003744 RID: 14148
		[Token(Token = "0x4003744")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E75C", Offset = "0x112E75C")]
		public uint add_muted_time;
	}
}
