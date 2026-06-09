using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F24 RID: 7972
	[Token(Token = "0x2001F24")]
	public class UIModelMail : UIBaseModel
	{
		// Token: 0x0600AF4B RID: 44875 RVA: 0x00030B40 File Offset: 0x0002ED40
		[Token(Token = "0x600AF4B")]
		[Address(RVA = "0x1656488", Offset = "0x1656488", VA = "0x7BBBE56488", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x00030B58 File Offset: 0x0002ED58
		// (set) Token: 0x0600AF4D RID: 44877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BA2")]
		public bool HasNewMail
		{
			[Token(Token = "0x600AF4C")]
			[Address(RVA = "0x1656490", Offset = "0x1656490", VA = "0x7BBBE56490")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11466AC", Offset = "0x11466AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AF4D")]
			[Address(RVA = "0x1656498", Offset = "0x1656498", VA = "0x7BBBE56498")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11466BC", Offset = "0x11466BC")]
			set
			{
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x00030B70 File Offset: 0x0002ED70
		// (set) Token: 0x0600AF4F RID: 44879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BA3")]
		public int NewMailCount
		{
			[Token(Token = "0x600AF4E")]
			[Address(RVA = "0x16564A4", Offset = "0x16564A4", VA = "0x7BBBE564A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11466CC", Offset = "0x11466CC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600AF4F")]
			[Address(RVA = "0x16564AC", Offset = "0x16564AC", VA = "0x7BBBE564AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11466DC", Offset = "0x11466DC")]
			set
			{
			}
		}

		// Token: 0x0600AF50 RID: 44880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AF50")]
		[Address(RVA = "0x16564B4", Offset = "0x16564B4", VA = "0x7BBBE564B4")]
		public List<MailInfo> GetMailInfoList(bool sorted = true)
		{
			return null;
		}

		// Token: 0x0600AF51 RID: 44881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AF51")]
		[Address(RVA = "0x1656738", Offset = "0x1656738", VA = "0x7BBBE56738")]
		public List<MailInfo> GetNoReciveGiftMailList()
		{
			return null;
		}

		// Token: 0x0600AF52 RID: 44882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF52")]
		[Address(RVA = "0x16568A8", Offset = "0x16568A8", VA = "0x7BBBE568A8", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600AF53 RID: 44883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF53")]
		[Address(RVA = "0x1656A1C", Offset = "0x1656A1C", VA = "0x7BBBE56A1C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600AF54 RID: 44884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF54")]
		[Address(RVA = "0x164E2E8", Offset = "0x164E2E8", VA = "0x7BBBE4E2E8")]
		public void RequestMailList(uint httpOp = 0U)
		{
		}

		// Token: 0x0600AF55 RID: 44885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF55")]
		[Address(RVA = "0x1656698", Offset = "0x1656698", VA = "0x7BBBE56698")]
		private void SortMailList(List<MailInfo> list)
		{
		}

		// Token: 0x0600AF56 RID: 44886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF56")]
		[Address(RVA = "0x1656BB4", Offset = "0x1656BB4", VA = "0x7BBBE56BB4")]
		public void SetMailStatus(EMail.Status status, MailInfo mailInfo, bool isFriendGift = false)
		{
		}

		// Token: 0x0600AF57 RID: 44887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF57")]
		[Address(RVA = "0x1656C98", Offset = "0x1656C98", VA = "0x7BBBE56C98")]
		public void RequestReadMail(List<MailInfo> mails, EMail.Status status, bool isBatchOp, bool isFriendGift = false)
		{
		}

		// Token: 0x0600AF58 RID: 44888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF58")]
		[Address(RVA = "0x1657024", Offset = "0x1657024", VA = "0x7BBBE57024")]
		public void CheckIfPopupRewards(EMail.Status type, CSReadMailRes readMailRes)
		{
		}

		// Token: 0x0600AF59 RID: 44889 RVA: 0x00030B88 File Offset: 0x0002ED88
		[Token(Token = "0x600AF59")]
		[Address(RVA = "0x1657544", Offset = "0x1657544", VA = "0x7BBBE57544")]
		public bool IsMailRead(ulong id)
		{
			return default(bool);
		}

		// Token: 0x0600AF5A RID: 44890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5A")]
		[Address(RVA = "0x16575CC", Offset = "0x16575CC", VA = "0x7BBBE575CC")]
		public void SetMailRead(ulong id)
		{
		}

		// Token: 0x0600AF5B RID: 44891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5B")]
		[Address(RVA = "0x1657650", Offset = "0x1657650", VA = "0x7BBBE57650")]
		public void RemoveMailRead(ulong id)
		{
		}

		// Token: 0x0600AF5C RID: 44892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5C")]
		[Address(RVA = "0x16576D4", Offset = "0x16576D4", VA = "0x7BBBE576D4")]
		public void UpdateMailRead()
		{
		}

		// Token: 0x0600AF5D RID: 44893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF5D")]
		[Address(RVA = "0x1656B04", Offset = "0x1656B04", VA = "0x7BBBE56B04")]
		public void SaveMailRead()
		{
		}

		// Token: 0x0600AF5E RID: 44894 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		[Token(Token = "0x600AF5E")]
		[Address(RVA = "0x165773C", Offset = "0x165773C", VA = "0x7BBBE5773C")]
		public bool HasUnreadMail()
		{
			return default(bool);
		}

		// Token: 0x0600AF5F RID: 44895 RVA: 0x00030BB8 File Offset: 0x0002EDB8
		[Token(Token = "0x600AF5F")]
		[Address(RVA = "0x16578B4", Offset = "0x16578B4", VA = "0x7BBBE578B4")]
		public bool HasNewMailNtf()
		{
			return default(bool);
		}

		// Token: 0x0600AF60 RID: 44896 RVA: 0x00030BD0 File Offset: 0x0002EDD0
		[Token(Token = "0x600AF60")]
		[Address(RVA = "0x16578D4", Offset = "0x16578D4", VA = "0x7BBBE578D4")]
		public bool ConditionHasAttachmentMail(MailInfo mail)
		{
			return default(bool);
		}

		// Token: 0x0600AF61 RID: 44897 RVA: 0x00030BE8 File Offset: 0x0002EDE8
		[Token(Token = "0x600AF61")]
		[Address(RVA = "0x1657958", Offset = "0x1657958", VA = "0x7BBBE57958")]
		public bool ConditionRecevableMail(MailInfo mail)
		{
			return default(bool);
		}

		// Token: 0x0600AF62 RID: 44898 RVA: 0x00030C00 File Offset: 0x0002EE00
		[Token(Token = "0x600AF62")]
		[Address(RVA = "0x165799C", Offset = "0x165799C", VA = "0x7BBBE5799C")]
		public bool ConditionProcessableMail(MailInfo mail)
		{
			return default(bool);
		}

		// Token: 0x0600AF63 RID: 44899 RVA: 0x00030C18 File Offset: 0x0002EE18
		[Token(Token = "0x600AF63")]
		[Address(RVA = "0x16579F4", Offset = "0x16579F4", VA = "0x7BBBE579F4")]
		public bool ConditionDeletableMail(MailInfo mail)
		{
			return default(bool);
		}

		// Token: 0x0600AF64 RID: 44900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AF64")]
		[Address(RVA = "0x1657A48", Offset = "0x1657A48", VA = "0x7BBBE57A48")]
		public string MakeUrl(string url)
		{
			return null;
		}

		// Token: 0x0600AF65 RID: 44901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF65")]
		[Address(RVA = "0x1657C40", Offset = "0x1657C40", VA = "0x7BBBE57C40")]
		public UIModelMail()
		{
		}

		// Token: 0x0600AF67 RID: 44903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF67")]
		[Address(RVA = "0x1657E54", Offset = "0x1657E54", VA = "0x7BBBE57E54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11466EC", Offset = "0x11466EC")]
		private void <RequestMailList>b__25_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600AF68 RID: 44904 RVA: 0x00030C30 File Offset: 0x0002EE30
		[Token(Token = "0x600AF68")]
		[Address(RVA = "0x165821C", Offset = "0x165821C", VA = "0x7BBBE5821C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11466FC", Offset = "0x11466FC")]
		private int <SortMailList>b__26_0(MailInfo a, MailInfo b)
		{
			return 0;
		}

		// Token: 0x0400B33F RID: 45887
		[Token(Token = "0x400B33F")]
		private const string READ_MAIL_KEY = "READ_MAIL";

		// Token: 0x0400B340 RID: 45888
		[Token(Token = "0x400B340")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MAX_MAIL_SHOW;

		// Token: 0x0400B341 RID: 45889
		[Token(Token = "0x400B341")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int MAIL_EXPIRE_DAYS;

		// Token: 0x0400B342 RID: 45890
		[Token(Token = "0x400B342")]
		public const uint PropID_GetMailRetOK = 2U;

		// Token: 0x0400B343 RID: 45891
		[Token(Token = "0x400B343")]
		public const uint PropID_GetMailRetFail = 4U;

		// Token: 0x0400B344 RID: 45892
		[Token(Token = "0x400B344")]
		public const uint PropID_ReadMailRetOK = 8U;

		// Token: 0x0400B345 RID: 45893
		[Token(Token = "0x400B345")]
		public const uint PropID_ReadMailRetFail = 16U;

		// Token: 0x0400B346 RID: 45894
		[Token(Token = "0x400B346")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113011C", Offset = "0x113011C")]
		private bool <HasNewMail>k__BackingField;

		// Token: 0x0400B347 RID: 45895
		[Token(Token = "0x400B347")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113012C", Offset = "0x113012C")]
		private int <NewMailCount>k__BackingField;

		// Token: 0x0400B348 RID: 45896
		[Token(Token = "0x400B348")]
		[FieldOffset(Offset = "0x20")]
		private List<MailInfo> m_CachedMailInfoList;

		// Token: 0x0400B349 RID: 45897
		[Token(Token = "0x400B349")]
		[FieldOffset(Offset = "0x28")]
		private List<MailInfo> m_ShowMailInfoList;

		// Token: 0x0400B34A RID: 45898
		[Token(Token = "0x400B34A")]
		[FieldOffset(Offset = "0x30")]
		private List<MailInfo> m_NoReciveGiftMailList;

		// Token: 0x0400B34B RID: 45899
		[Token(Token = "0x400B34B")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<string> m_ReadMailIDs;

		// Token: 0x0400B34C RID: 45900
		[Token(Token = "0x400B34C")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<string> m_CurrentMailIDs;

		// Token: 0x02001F25 RID: 7973
		[Token(Token = "0x2001F25")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCED4", Offset = "0x10FCED4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AF6A RID: 44906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF6A")]
			[Address(RVA = "0x1658318", Offset = "0x1658318", VA = "0x7BBBE58318")]
			public <>c()
			{
			}

			// Token: 0x0600AF6B RID: 44907 RVA: 0x00030C48 File Offset: 0x0002EE48
			[Token(Token = "0x600AF6B")]
			[Address(RVA = "0x1658320", Offset = "0x1658320", VA = "0x7BBBE58320")]
			internal int <RequestMailList>b__25_1(MailInfo a, MailInfo b)
			{
				return 0;
			}

			// Token: 0x0600AF6C RID: 44908 RVA: 0x00030C60 File Offset: 0x0002EE60
			[Token(Token = "0x600AF6C")]
			[Address(RVA = "0x1658370", Offset = "0x1658370", VA = "0x7BBBE58370")]
			internal ulong <RequestReadMail>b__28_0(MailInfo a)
			{
				return 0UL;
			}

			// Token: 0x0600AF6D RID: 44909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AF6D")]
			[Address(RVA = "0x165839C", Offset = "0x165839C", VA = "0x7BBBE5839C")]
			internal CommonRewardItemInfo <CheckIfPopupRewards>b__29_0(ExchangedAward item)
			{
				return null;
			}

			// Token: 0x0600AF6E RID: 44910 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600AF6E")]
			[Address(RVA = "0x16583A8", Offset = "0x16583A8", VA = "0x7BBBE583A8")]
			internal CommonRewardItemInfo <CheckIfPopupRewards>b__29_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600AF6F RID: 44911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF6F")]
			[Address(RVA = "0x16583B4", Offset = "0x16583B4", VA = "0x7BBBE583B4")]
			internal void <CheckIfPopupRewards>b__29_2()
			{
			}

			// Token: 0x0400B34D RID: 45901
			[Token(Token = "0x400B34D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelMail.<>c <>9;

			// Token: 0x0400B34E RID: 45902
			[Token(Token = "0x400B34E")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<MailInfo> <>9__25_1;

			// Token: 0x0400B34F RID: 45903
			[Token(Token = "0x400B34F")]
			[FieldOffset(Offset = "0x10")]
			public static Func<MailInfo, ulong> <>9__28_0;

			// Token: 0x0400B350 RID: 45904
			[Token(Token = "0x400B350")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<ExchangedAward, CommonRewardItemInfo> <>9__29_0;

			// Token: 0x0400B351 RID: 45905
			[Token(Token = "0x400B351")]
			[FieldOffset(Offset = "0x20")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__29_1;

			// Token: 0x0400B352 RID: 45906
			[Token(Token = "0x400B352")]
			[FieldOffset(Offset = "0x28")]
			public static Action <>9__29_2;
		}

		// Token: 0x02001F26 RID: 7974
		[Token(Token = "0x2001F26")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCEE4", Offset = "0x10FCEE4")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x0600AF70 RID: 44912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF70")]
			[Address(RVA = "0x165701C", Offset = "0x165701C", VA = "0x7BBBE5701C")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x0600AF71 RID: 44913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF71")]
			[Address(RVA = "0x1658450", Offset = "0x1658450", VA = "0x7BBBE58450")]
			internal void <RequestReadMail>b__1(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600AF72 RID: 44914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF72")]
			[Address(RVA = "0x165897C", Offset = "0x165897C", VA = "0x7BBBE5897C")]
			internal void <RequestReadMail>b__2(MailInfo a)
			{
			}

			// Token: 0x0600AF73 RID: 44915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF73")]
			[Address(RVA = "0x16589E8", Offset = "0x16589E8", VA = "0x7BBBE589E8")]
			internal void <RequestReadMail>b__3(MailInfo a)
			{
			}

			// Token: 0x0400B353 RID: 45907
			[Token(Token = "0x400B353")]
			[FieldOffset(Offset = "0x10")]
			public EMail.Status status;

			// Token: 0x0400B354 RID: 45908
			[Token(Token = "0x400B354")]
			[FieldOffset(Offset = "0x18")]
			public List<MailInfo> mails;

			// Token: 0x0400B355 RID: 45909
			[Token(Token = "0x400B355")]
			[FieldOffset(Offset = "0x20")]
			public UIModelMail <>4__this;

			// Token: 0x0400B356 RID: 45910
			[Token(Token = "0x400B356")]
			[FieldOffset(Offset = "0x28")]
			public bool isBatchOp;

			// Token: 0x0400B357 RID: 45911
			[Token(Token = "0x400B357")]
			[FieldOffset(Offset = "0x29")]
			public bool isFriendGift;

			// Token: 0x0400B358 RID: 45912
			[Token(Token = "0x400B358")]
			[FieldOffset(Offset = "0x30")]
			public Action<MailInfo> <>9__2;

			// Token: 0x0400B359 RID: 45913
			[Token(Token = "0x400B359")]
			[FieldOffset(Offset = "0x38")]
			public Action<MailInfo> <>9__3;
		}
	}
}
