using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B09 RID: 2825
	[Token(Token = "0x2000B09")]
	[ProtoContract]
	public class ScheduleTaskDesc
	{
		// Token: 0x06002811 RID: 10257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x24A0440", Offset = "0x24A0440", VA = "0x7BBCCA0440")]
		public ScheduleTaskDesc()
		{
		}

		// Token: 0x0400354D RID: 13645
		[Token(Token = "0x400354D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A4A4", Offset = "0x112A4A4")]
		public uint task_id;

		// Token: 0x0400354E RID: 13646
		[Token(Token = "0x400354E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A4B8", Offset = "0x112A4B8")]
		public ESchedule.TaskType task_type;

		// Token: 0x0400354F RID: 13647
		[Token(Token = "0x400354F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A4CC", Offset = "0x112A4CC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A4CC", Offset = "0x112A4CC")]
		public string param1;

		// Token: 0x04003550 RID: 13648
		[Token(Token = "0x4003550")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A51C", Offset = "0x112A51C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A51C", Offset = "0x112A51C")]
		public string param2;

		// Token: 0x04003551 RID: 13649
		[Token(Token = "0x4003551")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A56C", Offset = "0x112A56C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A56C", Offset = "0x112A56C")]
		public string param3;

		// Token: 0x04003552 RID: 13650
		[Token(Token = "0x4003552")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A5BC", Offset = "0x112A5BC")]
		public long start_time;

		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A5D0", Offset = "0x112A5D0")]
		public long end_time;

		// Token: 0x04003554 RID: 13652
		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A5E4", Offset = "0x112A5E4")]
		public uint loop_cycle;
	}
}
