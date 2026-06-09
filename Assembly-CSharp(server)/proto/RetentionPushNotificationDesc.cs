using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AFF RID: 2815
	[Token(Token = "0x2000AFF")]
	[ProtoContract]
	public class RetentionPushNotificationDesc
	{
		// Token: 0x06002807 RID: 10247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x24A012C", Offset = "0x24A012C", VA = "0x7BBCCA012C")]
		public RetentionPushNotificationDesc()
		{
		}

		// Token: 0x04003515 RID: 13589
		[Token(Token = "0x4003515")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129D60", Offset = "0x1129D60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1129D60", Offset = "0x1129D60")]
		public string region;

		// Token: 0x04003516 RID: 13590
		[Token(Token = "0x4003516")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129DB0", Offset = "0x1129DB0")]
		public uint status;

		// Token: 0x04003517 RID: 13591
		[Token(Token = "0x4003517")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129DC4", Offset = "0x1129DC4")]
		public uint notify_time;

		// Token: 0x04003518 RID: 13592
		[Token(Token = "0x4003518")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129DD8", Offset = "0x1129DD8")]
		public AwardDesc Award;
	}
}
