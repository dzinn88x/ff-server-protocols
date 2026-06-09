using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FE5 RID: 8165
	[Token(Token = "0x2001FE5")]
	public class UIModelRetentionPushNotification : UIBaseModel
	{
		// Token: 0x0600B546 RID: 46406 RVA: 0x000336F0 File Offset: 0x000318F0
		[Token(Token = "0x600B546")]
		[Address(RVA = "0x22F225C", Offset = "0x22F225C", VA = "0x7BBCAF225C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B547")]
		[Address(RVA = "0x22F2264", Offset = "0x22F2264", VA = "0x7BBCAF2264", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B548")]
		[Address(RVA = "0x22F2F78", Offset = "0x22F2F78", VA = "0x7BBCAF2F78")]
		private List<RetentionPushNotificationData> GetData(string region = "")
		{
			return null;
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B549")]
		[Address(RVA = "0x22F237C", Offset = "0x22F237C", VA = "0x7BBCAF237C")]
		private void CheckForRewards(LoginRes loginRes)
		{
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54A")]
		[Address(RVA = "0x22F2A88", Offset = "0x22F2A88", VA = "0x7BBCAF2A88")]
		private void ScheduleNotifications()
		{
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B54B")]
		[Address(RVA = "0x22F3488", Offset = "0x22F3488", VA = "0x7BBCAF3488")]
		private string _NotifyUrl(params object[] parameters)
		{
			return null;
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B54C")]
		[Address(RVA = "0x22F3230", Offset = "0x22F3230", VA = "0x7BBCAF3230")]
		private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, RetentionPushNotificationData datum)
		{
			return null;
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B54D")]
		[Address(RVA = "0x22F34F0", Offset = "0x22F34F0", VA = "0x7BBCAF34F0")]
		public UIModelRetentionPushNotification()
		{
		}

		// Token: 0x02001FE6 RID: 8166
		[Token(Token = "0x2001FE6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD6A4", Offset = "0x10FD6A4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B54F RID: 46415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B54F")]
			[Address(RVA = "0x22F35BC", Offset = "0x22F35BC", VA = "0x7BBCAF35BC")]
			public <>c()
			{
			}

			// Token: 0x0600B550 RID: 46416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B550")]
			[Address(RVA = "0x22F35C4", Offset = "0x22F35C4", VA = "0x7BBCAF35C4")]
			internal void <CheckForRewards>b__3_0(HttpErrorCode error, object resObj)
			{
			}

			// Token: 0x0400B789 RID: 46985
			[Token(Token = "0x400B789")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelRetentionPushNotification.<>c <>9;

			// Token: 0x0400B78A RID: 46986
			[Token(Token = "0x400B78A")]
			[FieldOffset(Offset = "0x8")]
			public static Action<HttpErrorCode, object> <>9__3_0;
		}

		// Token: 0x02001FE7 RID: 8167
		[Token(Token = "0x2001FE7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD6B4", Offset = "0x10FD6B4")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600B551 RID: 46417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B551")]
			[Address(RVA = "0x22F34E8", Offset = "0x22F34E8", VA = "0x7BBCAF34E8")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600B552 RID: 46418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B552")]
			[Address(RVA = "0x22F370C", Offset = "0x22F370C", VA = "0x7BBCAF370C")]
			internal string <GetNotifyInfo>b__0()
			{
				return null;
			}

			// Token: 0x0600B553 RID: 46419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B553")]
			[Address(RVA = "0x22F37CC", Offset = "0x22F37CC", VA = "0x7BBCAF37CC")]
			internal string <GetNotifyInfo>b__1()
			{
				return null;
			}

			// Token: 0x0400B78B RID: 46987
			[Token(Token = "0x400B78B")]
			[FieldOffset(Offset = "0x10")]
			public RetentionPushNotificationData datum;
		}
	}
}
