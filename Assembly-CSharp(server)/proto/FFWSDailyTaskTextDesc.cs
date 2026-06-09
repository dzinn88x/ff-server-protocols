using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B4B RID: 2891
	[Token(Token = "0x2000B4B")]
	[ProtoContract]
	public class FFWSDailyTaskTextDesc
	{
		// Token: 0x06002853 RID: 10323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002853")]
		[Address(RVA = "0x21BA0C0", Offset = "0x21BA0C0", VA = "0x7BBC9BA0C0")]
		public FFWSDailyTaskTextDesc()
		{
		}

		// Token: 0x040036ED RID: 14061
		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DAA0", Offset = "0x112DAA0")]
		public uint index;

		// Token: 0x040036EE RID: 14062
		[Token(Token = "0x40036EE")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DAB4", Offset = "0x112DAB4")]
		public uint activity_time;

		// Token: 0x040036EF RID: 14063
		[Token(Token = "0x40036EF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DAC8", Offset = "0x112DAC8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DAC8", Offset = "0x112DAC8")]
		public string task_text1;

		// Token: 0x040036F0 RID: 14064
		[Token(Token = "0x40036F0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DB18", Offset = "0x112DB18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DB18", Offset = "0x112DB18")]
		public string task_text2;

		// Token: 0x040036F1 RID: 14065
		[Token(Token = "0x40036F1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DB68", Offset = "0x112DB68")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DB68", Offset = "0x112DB68")]
		public string task_text3;

		// Token: 0x040036F2 RID: 14066
		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DBB8", Offset = "0x112DBB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DBB8", Offset = "0x112DBB8")]
		public string task_text4;

		// Token: 0x040036F3 RID: 14067
		[Token(Token = "0x40036F3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DC08", Offset = "0x112DC08")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DC08", Offset = "0x112DC08")]
		public string task_text5;
	}
}
