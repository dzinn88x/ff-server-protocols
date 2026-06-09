using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D5F RID: 7519
	[Token(Token = "0x2001D5F")]
	public class UIModelAnnouncement : UIBaseModel
	{
		// Token: 0x0600A3F4 RID: 41972 RVA: 0x0002B680 File Offset: 0x00029880
		[Token(Token = "0x600A3F4")]
		[Address(RVA = "0x23537C0", Offset = "0x23537C0", VA = "0x7BBCB537C0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x0002B698 File Offset: 0x00029898
		// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD7")]
		public UIModelAnnouncement.DataState CurrentDataState
		{
			[Token(Token = "0x600A3F5")]
			[Address(RVA = "0x23537C8", Offset = "0x23537C8", VA = "0x7BBCB537C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145AAC", Offset = "0x1145AAC")]
			get
			{
				return UIModelAnnouncement.DataState.None;
			}
			[Token(Token = "0x600A3F6")]
			[Address(RVA = "0x23537D0", Offset = "0x23537D0", VA = "0x7BBCB537D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145ABC", Offset = "0x1145ABC")]
			set
			{
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD8")]
		public List<AnnoucementInfo> AnnouncementDataList
		{
			[Token(Token = "0x600A3F7")]
			[Address(RVA = "0x23537D8", Offset = "0x23537D8", VA = "0x7BBCB537D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3F8")]
		[Address(RVA = "0x23537E0", Offset = "0x23537E0", VA = "0x7BBCB537E0", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3F9")]
		[Address(RVA = "0x2353898", Offset = "0x2353898", VA = "0x7BBCB53898", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A3FA")]
		[Address(RVA = "0x23539D0", Offset = "0x23539D0", VA = "0x7BBCB539D0")]
		public HttpRequest RequestAnnouncementSplashActivityData(float timeout = 0f, bool forceUpdate = false)
		{
			return null;
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FB")]
		[Address(RVA = "0x2353CC4", Offset = "0x2353CC4", VA = "0x7BBCB53CC4")]
		private void UpdateTipsNum()
		{
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x0002B6B0 File Offset: 0x000298B0
		[Token(Token = "0x600A3FC")]
		[Address(RVA = "0x2353E00", Offset = "0x2353E00", VA = "0x7BBCB53E00")]
		public bool IsUnreadAnnouncement(uint id)
		{
			return default(bool);
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FD")]
		[Address(RVA = "0x2353EBC", Offset = "0x2353EBC", VA = "0x7BBCB53EBC")]
		public void SetReadAnnouncement(uint id)
		{
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A3FE")]
		[Address(RVA = "0x2353F80", Offset = "0x2353F80", VA = "0x7BBCB53F80")]
		public void TestAnnouncementData(List<AnnoucementInfo> announcementData)
		{
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x0002B6C8 File Offset: 0x000298C8
		[Token(Token = "0x600A3FF")]
		[Address(RVA = "0x2354088", Offset = "0x2354088", VA = "0x7BBCB54088")]
		public bool CheckCanShowByQuality(EAnnouncement.PhoneQuality quality)
		{
			return default(bool);
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x0002B6E0 File Offset: 0x000298E0
		[Token(Token = "0x600A400")]
		[Address(RVA = "0x23541DC", Offset = "0x23541DC", VA = "0x7BBCB541DC")]
		public bool CheckCanShowByAccountID(string lastNums)
		{
			return default(bool);
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A401")]
		[Address(RVA = "0x23543EC", Offset = "0x23543EC", VA = "0x7BBCB543EC")]
		public UIModelAnnouncement()
		{
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A402")]
		[Address(RVA = "0x235447C", Offset = "0x235447C", VA = "0x7BBCB5447C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145ACC", Offset = "0x1145ACC")]
		private void <RequestAnnouncementSplashActivityData>b__16_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400AA03 RID: 43523
		[Token(Token = "0x400AA03")]
		public const uint PropID_AnnounceRetOK = 2U;

		// Token: 0x0400AA04 RID: 43524
		[Token(Token = "0x400AA04")]
		public const uint PropID_AnnounceRetFailed = 4U;

		// Token: 0x0400AA05 RID: 43525
		[Token(Token = "0x400AA05")]
		private const string ANNOUNCEMENT_READED_FORMAT = "Announcement{0}";

		// Token: 0x0400AA06 RID: 43526
		[Token(Token = "0x400AA06")]
		[FieldOffset(Offset = "0x18")]
		public bool IsAnnouncementShowed;

		// Token: 0x0400AA07 RID: 43527
		[Token(Token = "0x400AA07")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE7C", Offset = "0x112FE7C")]
		private UIModelAnnouncement.DataState <CurrentDataState>k__BackingField;

		// Token: 0x0400AA08 RID: 43528
		[Token(Token = "0x400AA08")]
		[FieldOffset(Offset = "0x20")]
		private List<AnnoucementInfo> m_AnnouncementDataList;

		// Token: 0x0400AA09 RID: 43529
		[Token(Token = "0x400AA09")]
		[FieldOffset(Offset = "0x28")]
		private LoginRes m_LastLoginResCache;

		// Token: 0x02001D60 RID: 7520
		[Token(Token = "0x2001D60")]
		public enum DataState
		{
			// Token: 0x0400AA0B RID: 43531
			[Token(Token = "0x400AA0B")]
			None,
			// Token: 0x0400AA0C RID: 43532
			[Token(Token = "0x400AA0C")]
			Fetching,
			// Token: 0x0400AA0D RID: 43533
			[Token(Token = "0x400AA0D")]
			Fetched
		}

		// Token: 0x02001D61 RID: 7521
		[Token(Token = "0x2001D61")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBD14", Offset = "0x10FBD14")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A404 RID: 41988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A404")]
			[Address(RVA = "0x2354998", Offset = "0x2354998", VA = "0x7BBCB54998")]
			public <>c()
			{
			}

			// Token: 0x0600A405 RID: 41989 RVA: 0x0002B6F8 File Offset: 0x000298F8
			[Token(Token = "0x600A405")]
			[Address(RVA = "0x23549A0", Offset = "0x23549A0", VA = "0x7BBCB549A0")]
			internal int <RequestAnnouncementSplashActivityData>b__16_1(AnnoucementInfo a, AnnoucementInfo b)
			{
				return 0;
			}

			// Token: 0x0600A406 RID: 41990 RVA: 0x0002B710 File Offset: 0x00029910
			[Token(Token = "0x600A406")]
			[Address(RVA = "0x2354A08", Offset = "0x2354A08", VA = "0x7BBCB54A08")]
			internal int <TestAnnouncementData>b__20_0(AnnoucementInfo a, AnnoucementInfo b)
			{
				return 0;
			}

			// Token: 0x0400AA0E RID: 43534
			[Token(Token = "0x400AA0E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelAnnouncement.<>c <>9;

			// Token: 0x0400AA0F RID: 43535
			[Token(Token = "0x400AA0F")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AnnoucementInfo> <>9__16_1;

			// Token: 0x0400AA10 RID: 43536
			[Token(Token = "0x400AA10")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<AnnoucementInfo> <>9__20_0;
		}
	}
}
