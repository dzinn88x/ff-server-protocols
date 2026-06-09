using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	[ProtoContract]
	public class AttendanceConfigDesc
	{
		// Token: 0x0600272E RID: 10030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x21AF228", Offset = "0x21AF228", VA = "0x7BBC9AF228")]
		public AttendanceConfigDesc()
		{
		}

		// Token: 0x04002F4C RID: 12108
		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F0B8", Offset = "0x111F0B8")]
		public uint id;

		// Token: 0x04002F4D RID: 12109
		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F0CC", Offset = "0x111F0CC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F0CC", Offset = "0x111F0CC")]
		public string start_time;

		// Token: 0x04002F4E RID: 12110
		[Token(Token = "0x4002F4E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F11C", Offset = "0x111F11C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F11C", Offset = "0x111F11C")]
		public string end_time;

		// Token: 0x04002F4F RID: 12111
		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F16C", Offset = "0x111F16C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F16C", Offset = "0x111F16C")]
		public string url;

		// Token: 0x04002F50 RID: 12112
		[Token(Token = "0x4002F50")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F1BC", Offset = "0x111F1BC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F1BC", Offset = "0x111F1BC")]
		public string loc_key;

		// Token: 0x04002F51 RID: 12113
		[Token(Token = "0x4002F51")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F20C", Offset = "0x111F20C")]
		public EAttendance.AttendanceType attendance_type;
	}
}
