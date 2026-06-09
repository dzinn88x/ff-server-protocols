using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D58 RID: 7512
	[Token(Token = "0x2001D58")]
	public class UIModelAnnoucementReward : UIBaseModel
	{
		// Token: 0x0600A3C5 RID: 41925 RVA: 0x0002B4E8 File Offset: 0x000296E8
		[Token(Token = "0x600A3C5")]
		[Address(RVA = "0x2351090", Offset = "0x2351090", VA = "0x7BBCB51090", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x0600A3C6 RID: 41926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACF")]
		public List<AttendaceItemInfo> AttendaceInfoList
		{
			[Token(Token = "0x600A3C6")]
			[Address(RVA = "0x2351098", Offset = "0x2351098", VA = "0x7BBCB51098")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x0002B500 File Offset: 0x00029700
		[Token(Token = "0x17000AD0")]
		public DateTime AttendanceEndTime
		{
			[Token(Token = "0x600A3C7")]
			[Address(RVA = "0x23510A0", Offset = "0x23510A0", VA = "0x7BBCB510A0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x0600A3C8 RID: 41928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD1")]
		public AwardItemInfo CurrentAwardInfo
		{
			[Token(Token = "0x600A3C8")]
			[Address(RVA = "0x23510A8", Offset = "0x23510A8", VA = "0x7BBCB510A8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600A3C9 RID: 41929 RVA: 0x0002B518 File Offset: 0x00029718
		[Token(Token = "0x17000AD2")]
		public DateTimeOffset LastSingedTime
		{
			[Token(Token = "0x600A3C9")]
			[Address(RVA = "0x23510B0", Offset = "0x23510B0", VA = "0x7BBCB510B0")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600A3CA RID: 41930 RVA: 0x0002B530 File Offset: 0x00029730
		[Token(Token = "0x17000AD3")]
		public int LastSignedIndex
		{
			[Token(Token = "0x600A3CA")]
			[Address(RVA = "0x23510BC", Offset = "0x23510BC", VA = "0x7BBCB510BC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x0600A3CB RID: 41931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD4")]
		public string SignPictureUrl
		{
			[Token(Token = "0x600A3CB")]
			[Address(RVA = "0x23510C4", Offset = "0x23510C4", VA = "0x7BBCB510C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x0600A3CC RID: 41932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD5")]
		public string SignDesc
		{
			[Token(Token = "0x600A3CC")]
			[Address(RVA = "0x23510CC", Offset = "0x23510CC", VA = "0x7BBCB510CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600A3CD RID: 41933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD6")]
		public AttendanceList TurntableAttendanceRes
		{
			[Token(Token = "0x600A3CD")]
			[Address(RVA = "0x23510D4", Offset = "0x23510D4", VA = "0x7BBCB510D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A3CE RID: 41934 RVA: 0x0002B548 File Offset: 0x00029748
		[Token(Token = "0x600A3CE")]
		[Address(RVA = "0x23510DC", Offset = "0x23510DC", VA = "0x7BBCB510DC")]
		public bool IsSignedToday()
		{
			return default(bool);
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x0002B560 File Offset: 0x00029760
		[Token(Token = "0x600A3CF")]
		[Address(RVA = "0x23510E4", Offset = "0x23510E4", VA = "0x7BBCB510E4")]
		public bool CheckIsNeedAutoSign()
		{
			return default(bool);
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x0002B578 File Offset: 0x00029778
		[Token(Token = "0x600A3D0")]
		[Address(RVA = "0x23511F8", Offset = "0x23511F8", VA = "0x7BBCB511F8")]
		public bool CheckNeedRefreshTurntableSign()
		{
			return default(bool);
		}

		// Token: 0x0600A3D1 RID: 41937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D1")]
		[Address(RVA = "0x23513A0", Offset = "0x23513A0", VA = "0x7BBCB513A0", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D2")]
		[Address(RVA = "0x23514B4", Offset = "0x23514B4", VA = "0x7BBCB514B4")]
		public void RequestAttendanceRes(uint httpOp = 0U)
		{
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3D3")]
		[Address(RVA = "0x235190C", Offset = "0x235190C", VA = "0x7BBCB5190C")]
		public HttpRequest RequestTurntableAttendance()
		{
			return null;
		}

		// Token: 0x0600A3D4 RID: 41940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D4")]
		[Address(RVA = "0x2351ACC", Offset = "0x2351ACC", VA = "0x7BBCB51ACC")]
		public void ProcessTurntableRes(AttendanceList rewards)
		{
		}

		// Token: 0x0600A3D5 RID: 41941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D5")]
		[Address(RVA = "0x2351C40", Offset = "0x2351C40", VA = "0x7BBCB51C40")]
		public void RefreshTurntableSigninTips()
		{
		}

		// Token: 0x0600A3D6 RID: 41942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D6")]
		[Address(RVA = "0x2351E00", Offset = "0x2351E00", VA = "0x7BBCB51E00")]
		public void ProcessAttendanceRes(AttendanceList res)
		{
		}

		// Token: 0x0600A3D7 RID: 41943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D7")]
		[Address(RVA = "0x2352188", Offset = "0x2352188", VA = "0x7BBCB52188")]
		public void AttendanceSignin(AwardItemInfo itemInfo, int AttendaceInfoIndex)
		{
		}

		// Token: 0x0600A3D8 RID: 41944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D8")]
		[Address(RVA = "0x23523E8", Offset = "0x23523E8", VA = "0x7BBCB523E8")]
		public void TurntableAttendanceSignin()
		{
		}

		// Token: 0x0600A3D9 RID: 41945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3D9")]
		[Address(RVA = "0x2352704", Offset = "0x2352704", VA = "0x7BBCB52704", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A3DA RID: 41946 RVA: 0x0002B590 File Offset: 0x00029790
		[Token(Token = "0x600A3DA")]
		[Address(RVA = "0x23527C0", Offset = "0x23527C0", VA = "0x7BBCB527C0")]
		public bool HasUnclaimedSignInReward()
		{
			return default(bool);
		}

		// Token: 0x0600A3DB RID: 41947 RVA: 0x0002B5A8 File Offset: 0x000297A8
		[Token(Token = "0x600A3DB")]
		[Address(RVA = "0x23528D0", Offset = "0x23528D0", VA = "0x7BBCB528D0")]
		public bool CheckAllSigned()
		{
			return default(bool);
		}

		// Token: 0x0600A3DC RID: 41948 RVA: 0x0002B5C0 File Offset: 0x000297C0
		[Token(Token = "0x600A3DC")]
		[Address(RVA = "0x2352968", Offset = "0x2352968", VA = "0x7BBCB52968")]
		public int GetSignedCount()
		{
			return 0;
		}

		// Token: 0x0600A3DD RID: 41949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3DD")]
		[Address(RVA = "0x2352A68", Offset = "0x2352A68", VA = "0x7BBCB52A68")]
		public UIModelAnnoucementReward()
		{
		}

		// Token: 0x0600A3DE RID: 41950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3DE")]
		[Address(RVA = "0x2352B8C", Offset = "0x2352B8C", VA = "0x7BBCB52B8C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145A7C", Offset = "0x1145A7C")]
		private void <RequestAttendanceRes>b__38_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A3DF RID: 41951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3DF")]
		[Address(RVA = "0x2352EF8", Offset = "0x2352EF8", VA = "0x7BBCB52EF8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145A8C", Offset = "0x1145A8C")]
		private void <RequestTurntableAttendance>b__40_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A3E0 RID: 41952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3E0")]
		[Address(RVA = "0x23530C4", Offset = "0x23530C4", VA = "0x7BBCB530C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145A9C", Offset = "0x1145A9C")]
		private void <TurntableAttendanceSignin>b__46_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400A9DD RID: 43485
		[Token(Token = "0x400A9DD")]
		public const uint PropID_AttendanceLisUpdate = 8U;

		// Token: 0x0400A9DE RID: 43486
		[Token(Token = "0x400A9DE")]
		public const uint PropID_GetReward = 16U;

		// Token: 0x0400A9DF RID: 43487
		[Token(Token = "0x400A9DF")]
		public const uint PropID_TurntableAttendanceListUpdate = 32U;

		// Token: 0x0400A9E0 RID: 43488
		[Token(Token = "0x400A9E0")]
		public const uint PropID_TurntableSigned = 64U;

		// Token: 0x0400A9E1 RID: 43489
		[Token(Token = "0x400A9E1")]
		[FieldOffset(Offset = "0x18")]
		private List<AttendaceItemInfo> m_AttendaceInfoList;

		// Token: 0x0400A9E2 RID: 43490
		[Token(Token = "0x400A9E2")]
		[FieldOffset(Offset = "0x20")]
		public bool HaveGetAttendance;

		// Token: 0x0400A9E3 RID: 43491
		[Token(Token = "0x400A9E3")]
		[FieldOffset(Offset = "0x28")]
		private DateTime m_AttendanceEndTime;

		// Token: 0x0400A9E4 RID: 43492
		[Token(Token = "0x400A9E4")]
		[FieldOffset(Offset = "0x30")]
		private AwardItemInfo m_CurrentAwardInfo;

		// Token: 0x0400A9E5 RID: 43493
		[Token(Token = "0x400A9E5")]
		[FieldOffset(Offset = "0x38")]
		private DateTimeOffset m_BeijingLastSignedTime;

		// Token: 0x0400A9E6 RID: 43494
		[Token(Token = "0x400A9E6")]
		[FieldOffset(Offset = "0x48")]
		private int m_LastSignedIndex;

		// Token: 0x0400A9E7 RID: 43495
		[Token(Token = "0x400A9E7")]
		[FieldOffset(Offset = "0x50")]
		private string m_SignPictureUrl;

		// Token: 0x0400A9E8 RID: 43496
		[Token(Token = "0x400A9E8")]
		[FieldOffset(Offset = "0x58")]
		private string m_SignDesc;

		// Token: 0x0400A9E9 RID: 43497
		[Token(Token = "0x400A9E9")]
		[FieldOffset(Offset = "0x60")]
		private bool m_WaitingForReponse;

		// Token: 0x0400A9EA RID: 43498
		[Token(Token = "0x400A9EA")]
		[FieldOffset(Offset = "0x61")]
		private bool m_IsSignedToday;

		// Token: 0x0400A9EB RID: 43499
		[Token(Token = "0x400A9EB")]
		[FieldOffset(Offset = "0x64")]
		private uint m_ConfigId;

		// Token: 0x0400A9EC RID: 43500
		[Token(Token = "0x400A9EC")]
		[FieldOffset(Offset = "0x68")]
		private AttendanceList m_TurntableAttendanceRes;

		// Token: 0x0400A9ED RID: 43501
		[Token(Token = "0x400A9ED")]
		[FieldOffset(Offset = "0x70")]
		private DateTime m_LastRefreshTurntableDateTime;

		// Token: 0x0400A9EE RID: 43502
		[Token(Token = "0x400A9EE")]
		[FieldOffset(Offset = "0x78")]
		private bool waitTurntableResponse;

		// Token: 0x02001D59 RID: 7513
		[Token(Token = "0x2001D59")]
		public class NotifyArgs
		{
			// Token: 0x0600A3E1 RID: 41953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3E1")]
			[Address(RVA = "0x2353304", Offset = "0x2353304", VA = "0x7BBCB53304")]
			public NotifyArgs()
			{
			}

			// Token: 0x0400A9EF RID: 43503
			[Token(Token = "0x400A9EF")]
			[FieldOffset(Offset = "0x10")]
			public bool success;

			// Token: 0x0400A9F0 RID: 43504
			[Token(Token = "0x400A9F0")]
			[FieldOffset(Offset = "0x14")]
			public uint signId;
		}

		// Token: 0x02001D5A RID: 7514
		[Token(Token = "0x2001D5A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBCE4", Offset = "0x10FBCE4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A3E3 RID: 41955 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3E3")]
			[Address(RVA = "0x2353378", Offset = "0x2353378", VA = "0x7BBCB53378")]
			public <>c()
			{
			}

			// Token: 0x0600A3E4 RID: 41956 RVA: 0x0002B5D8 File Offset: 0x000297D8
			[Token(Token = "0x600A3E4")]
			[Address(RVA = "0x2353380", Offset = "0x2353380", VA = "0x7BBCB53380")]
			internal int <ProcessTurntableRes>b__41_0(AttendanceItem x, AttendanceItem y)
			{
				return 0;
			}

			// Token: 0x0600A3E5 RID: 41957 RVA: 0x0002B5F0 File Offset: 0x000297F0
			[Token(Token = "0x600A3E5")]
			[Address(RVA = "0x23533C8", Offset = "0x23533C8", VA = "0x7BBCB533C8")]
			internal bool <RefreshTurntableSigninTips>b__42_0(AttendanceItem e)
			{
				return default(bool);
			}

			// Token: 0x0600A3E6 RID: 41958 RVA: 0x0002B608 File Offset: 0x00029808
			[Token(Token = "0x600A3E6")]
			[Address(RVA = "0x23533FC", Offset = "0x23533FC", VA = "0x7BBCB533FC")]
			internal bool <HasUnclaimedSignInReward>b__48_0(AttendaceItemInfo a)
			{
				return default(bool);
			}

			// Token: 0x0400A9F1 RID: 43505
			[Token(Token = "0x400A9F1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelAnnoucementReward.<>c <>9;

			// Token: 0x0400A9F2 RID: 43506
			[Token(Token = "0x400A9F2")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AttendanceItem> <>9__41_0;

			// Token: 0x0400A9F3 RID: 43507
			[Token(Token = "0x400A9F3")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<AttendanceItem> <>9__42_0;

			// Token: 0x0400A9F4 RID: 43508
			[Token(Token = "0x400A9F4")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<AttendaceItemInfo> <>9__48_0;
		}

		// Token: 0x02001D5B RID: 7515
		[Token(Token = "0x2001D5B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBCF4", Offset = "0x10FBCF4")]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x0600A3E7 RID: 41959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3E7")]
			[Address(RVA = "0x23523E0", Offset = "0x23523E0", VA = "0x7BBCB523E0")]
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x0600A3E8 RID: 41960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3E8")]
			[Address(RVA = "0x2353438", Offset = "0x2353438", VA = "0x7BBCB53438")]
			internal void <AttendanceSignin>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400A9F5 RID: 43509
			[Token(Token = "0x400A9F5")]
			[FieldOffset(Offset = "0x10")]
			public int AttendaceInfoIndex;

			// Token: 0x0400A9F6 RID: 43510
			[Token(Token = "0x400A9F6")]
			[FieldOffset(Offset = "0x18")]
			public UIModelAnnoucementReward <>4__this;
		}

		// Token: 0x02001D5C RID: 7516
		[Token(Token = "0x2001D5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD04", Offset = "0x10FBD04")]
		private sealed class <>c__DisplayClass46_0
		{
			// Token: 0x0600A3E9 RID: 41961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A3E9")]
			[Address(RVA = "0x235330C", Offset = "0x235330C", VA = "0x7BBCB5330C")]
			public <>c__DisplayClass46_0()
			{
			}

			// Token: 0x0600A3EA RID: 41962 RVA: 0x0002B620 File Offset: 0x00029820
			[Token(Token = "0x600A3EA")]
			[Address(RVA = "0x2353784", Offset = "0x2353784", VA = "0x7BBCB53784")]
			internal bool <TurntableAttendanceSignin>b__1(AttendanceItem item)
			{
				return default(bool);
			}

			// Token: 0x0400A9F7 RID: 43511
			[Token(Token = "0x400A9F7")]
			[FieldOffset(Offset = "0x10")]
			public uint sign_id;
		}
	}
}
