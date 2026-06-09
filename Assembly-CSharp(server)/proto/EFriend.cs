using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200062C RID: 1580
	[Token(Token = "0x200062C")]
	[ProtoContract]
	public class EFriend
	{
		// Token: 0x0600239D RID: 9117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x21B9808", Offset = "0x21B9808", VA = "0x7BBC9B9808")]
		public EFriend()
		{
		}

		// Token: 0x0200062D RID: 1581
		[Token(Token = "0x200062D")]
		[ProtoContract]
		public enum FriendMainType
		{
			// Token: 0x04001F6F RID: 8047
			[Token(Token = "0x4001F6F")]
			FriendMainType_NONE,
			// Token: 0x04001F70 RID: 8048
			[Token(Token = "0x4001F70")]
			FriendMainType_REGION
		}

		// Token: 0x0200062E RID: 1582
		[Token(Token = "0x200062E")]
		[ProtoContract]
		public enum IntimacyType
		{
			// Token: 0x04001F72 RID: 8050
			[Token(Token = "0x4001F72")]
			IntimacyType_NONE,
			// Token: 0x04001F73 RID: 8051
			[Token(Token = "0x4001F73")]
			IntimacyType_ENDMATCH,
			// Token: 0x04001F74 RID: 8052
			[Token(Token = "0x4001F74")]
			IntimacyType_SENDGIFT,
			// Token: 0x04001F75 RID: 8053
			[Token(Token = "0x4001F75")]
			IntimacyType_CHAT
		}

		// Token: 0x0200062F RID: 1583
		[Token(Token = "0x200062F")]
		[ProtoContract]
		public enum RelationType
		{
			// Token: 0x04001F77 RID: 8055
			[Token(Token = "0x4001F77")]
			RelationType_NONE,
			// Token: 0x04001F78 RID: 8056
			[Token(Token = "0x4001F78")]
			RelationType_CONFIDANT
		}

		// Token: 0x02000630 RID: 1584
		[Token(Token = "0x2000630")]
		[ProtoContract]
		public enum IntimacyRankAwardStatus
		{
			// Token: 0x04001F7A RID: 8058
			[Token(Token = "0x4001F7A")]
			IntimacyRankAwardStatus_INIT,
			// Token: 0x04001F7B RID: 8059
			[Token(Token = "0x4001F7B")]
			IntimacyRankAwardStatus_AWARDED
		}

		// Token: 0x02000631 RID: 1585
		[Token(Token = "0x2000631")]
		[ProtoContract]
		public enum SpecialFriendState
		{
			// Token: 0x04001F7D RID: 8061
			[Token(Token = "0x4001F7D")]
			SpecialFriendState_NONE,
			// Token: 0x04001F7E RID: 8062
			[Token(Token = "0x4001F7E")]
			SpecialFriendState_WAIT_CREATE,
			// Token: 0x04001F7F RID: 8063
			[Token(Token = "0x4001F7F")]
			SpecialFriendState_ALREADY_BE,
			// Token: 0x04001F80 RID: 8064
			[Token(Token = "0x4001F80")]
			SpecialFriendState_WAIT_DISMISS,
			// Token: 0x04001F81 RID: 8065
			[Token(Token = "0x4001F81")]
			SpecialFriendState_DECLINED
		}

		// Token: 0x02000632 RID: 1586
		[Token(Token = "0x2000632")]
		[ProtoContract]
		public enum SpecialFriendSendApplyResult
		{
			// Token: 0x04001F83 RID: 8067
			[Token(Token = "0x4001F83")]
			SpecialFriendSendApplyResult_NONE,
			// Token: 0x04001F84 RID: 8068
			[Token(Token = "0x4001F84")]
			SpecialFriendSendApplyResult_SUCCESS,
			// Token: 0x04001F85 RID: 8069
			[Token(Token = "0x4001F85")]
			SpecialFriendSendApplyResult_TARGET_APPLY_MAX,
			// Token: 0x04001F86 RID: 8070
			[Token(Token = "0x4001F86")]
			SpecialFriendSendApplyResult_TARGET_SPECIAL_FRIEND_MAX
		}

		// Token: 0x02000633 RID: 1587
		[Token(Token = "0x2000633")]
		[ProtoContract]
		public enum SpecialFriendReplyResult
		{
			// Token: 0x04001F88 RID: 8072
			[Token(Token = "0x4001F88")]
			SpecialFriendReplyResult_REJECT,
			// Token: 0x04001F89 RID: 8073
			[Token(Token = "0x4001F89")]
			SpecialFriendReplyResult_AGREE
		}
	}
}
