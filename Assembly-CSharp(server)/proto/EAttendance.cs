using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005AB RID: 1451
	[Token(Token = "0x20005AB")]
	[ProtoContract]
	public class EAttendance
	{
		// Token: 0x0600234E RID: 9038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234E")]
		[Address(RVA = "0x21B97D0", Offset = "0x21B97D0", VA = "0x7BBC9B97D0")]
		public EAttendance()
		{
		}

		// Token: 0x020005AC RID: 1452
		[Token(Token = "0x20005AC")]
		[ProtoContract]
		public enum VeteranRewardStatus
		{
			// Token: 0x04001CBF RID: 7359
			[Token(Token = "0x4001CBF")]
			VeteranRewardStatus_NOT_SIGNED,
			// Token: 0x04001CC0 RID: 7360
			[Token(Token = "0x4001CC0")]
			VeteranRewardStatus_SIGNED,
			// Token: 0x04001CC1 RID: 7361
			[Token(Token = "0x4001CC1")]
			VeteranRewardStatus_CLAIMED
		}

		// Token: 0x020005AD RID: 1453
		[Token(Token = "0x20005AD")]
		[ProtoContract]
		public enum FestivalSourceType
		{
			// Token: 0x04001CC3 RID: 7363
			[Token(Token = "0x4001CC3")]
			FestivalSourceType_NONE,
			// Token: 0x04001CC4 RID: 7364
			[Token(Token = "0x4001CC4")]
			FestivalSourceType_ACTIVITY,
			// Token: 0x04001CC5 RID: 7365
			[Token(Token = "0x4001CC5")]
			FestivalSourceType_GAME_DROP
		}

		// Token: 0x020005AE RID: 1454
		[Token(Token = "0x20005AE")]
		[ProtoContract]
		public enum VeteranClass
		{
			// Token: 0x04001CC7 RID: 7367
			[Token(Token = "0x4001CC7")]
			VeteranClass_NONE,
			// Token: 0x04001CC8 RID: 7368
			[Token(Token = "0x4001CC8")]
			VeteranClass_NOMAL,
			// Token: 0x04001CC9 RID: 7369
			[Token(Token = "0x4001CC9")]
			VeteranClass_SENIOR,
			// Token: 0x04001CCA RID: 7370
			[Token(Token = "0x4001CCA")]
			VeteranClass_RICH
		}

		// Token: 0x020005AF RID: 1455
		[Token(Token = "0x20005AF")]
		[ProtoContract]
		public enum VeteranTaskBigPrize
		{
			// Token: 0x04001CCC RID: 7372
			[Token(Token = "0x4001CCC")]
			VeteranTaskBigPrize_NOT_AVALIBLE,
			// Token: 0x04001CCD RID: 7373
			[Token(Token = "0x4001CCD")]
			VeteranTaskBigPrize_CAN_GET,
			// Token: 0x04001CCE RID: 7374
			[Token(Token = "0x4001CCE")]
			VeteranTaskBigPrize_CLAIMED
		}

		// Token: 0x020005B0 RID: 1456
		[Token(Token = "0x20005B0")]
		[ProtoContract]
		public enum AttendanceType
		{
			// Token: 0x04001CD0 RID: 7376
			[Token(Token = "0x4001CD0")]
			AttendanceType_NORMAL,
			// Token: 0x04001CD1 RID: 7377
			[Token(Token = "0x4001CD1")]
			AttendanceType_TURNTABLE
		}

		// Token: 0x020005B1 RID: 1457
		[Token(Token = "0x20005B1")]
		[ProtoContract]
		public enum FestivalAttendanceState
		{
			// Token: 0x04001CD3 RID: 7379
			[Token(Token = "0x4001CD3")]
			FestivalAttendanceState_NOT_SIGNED,
			// Token: 0x04001CD4 RID: 7380
			[Token(Token = "0x4001CD4")]
			FestivalAttendanceState_SIGNED,
			// Token: 0x04001CD5 RID: 7381
			[Token(Token = "0x4001CD5")]
			FestivalAttendanceState_CLAIMED = 3
		}
	}
}
