using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001F15 RID: 7957
	[Token(Token = "0x2001F15")]
	public class UIModelLobbyAds : UIBaseModel
	{
		// Token: 0x0600AED0 RID: 44752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED0")]
		[Address(RVA = "0x1641D30", Offset = "0x1641D30", VA = "0x7BBBE41D30", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED1")]
		[Address(RVA = "0x1641DFC", Offset = "0x1641DFC", VA = "0x7BBBE41DFC", Slot = "11")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x0600AED2 RID: 44754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B9C")]
		public List<UIModelLobbyAds.AdInfo> AdList
		{
			[Token(Token = "0x600AED2")]
			[Address(RVA = "0x1641EBC", Offset = "0x1641EBC", VA = "0x7BBBE41EBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED3")]
		[Address(RVA = "0x1642064", Offset = "0x1642064", VA = "0x7BBBE42064")]
		private void UpdateAnnouncementAdList(params object[] data)
		{
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED4")]
		[Address(RVA = "0x1642068", Offset = "0x1642068", VA = "0x7BBBE42068")]
		public void UpdateAnnouncementAdList()
		{
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED5")]
		[Address(RVA = "0x16423A0", Offset = "0x16423A0", VA = "0x7BBBE423A0")]
		public void UpdateEventAdList()
		{
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x00030900 File Offset: 0x0002EB00
		[Token(Token = "0x600AED6")]
		[Address(RVA = "0x16426FC", Offset = "0x16426FC", VA = "0x7BBBE426FC", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600AED7 RID: 44759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED7")]
		[Address(RVA = "0x1642704", Offset = "0x1642704", VA = "0x7BBBE42704")]
		public void GetLobbyAdRes()
		{
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AED8")]
		[Address(RVA = "0x1642AA0", Offset = "0x1642AA0", VA = "0x7BBBE42AA0")]
		public List<AdvertDesc> GetLobbyExtraAdRes()
		{
			return null;
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x00030918 File Offset: 0x0002EB18
		[Token(Token = "0x600AED9")]
		[Address(RVA = "0x1642CF0", Offset = "0x1642CF0", VA = "0x7BBBE42CF0")]
		public bool IsLobbyExtraAdsNewID(uint cdnID)
		{
			return default(bool);
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x00030930 File Offset: 0x0002EB30
		[Token(Token = "0x600AEDA")]
		[Address(RVA = "0x1642DAC", Offset = "0x1642DAC", VA = "0x7BBBE42DAC")]
		public bool IsLobbyExtraAdsUnClicked(int extraIdx)
		{
			return default(bool);
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x00030948 File Offset: 0x0002EB48
		[Token(Token = "0x600AEDB")]
		[Address(RVA = "0x1642E6C", Offset = "0x1642E6C", VA = "0x7BBBE42E6C")]
		public bool IsLobbyExtraAdsUnClicked(ulong accountID, uint cdnID)
		{
			return default(bool);
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x00030960 File Offset: 0x0002EB60
		[Token(Token = "0x600AEDC")]
		[Address(RVA = "0x1642F58", Offset = "0x1642F58", VA = "0x7BBBE42F58")]
		public bool IsExtraAdTimeOut(uint cdnID)
		{
			return default(bool);
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEDD")]
		[Address(RVA = "0x16432F4", Offset = "0x16432F4", VA = "0x7BBBE432F4")]
		public void SetExtraAdPrefNewID(uint cdnID, ulong value = 0UL)
		{
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEDE")]
		[Address(RVA = "0x1643404", Offset = "0x1643404", VA = "0x7BBBE43404")]
		public void SetExtraAdClicked(int extraIdx)
		{
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEDF")]
		[Address(RVA = "0x16434BC", Offset = "0x16434BC", VA = "0x7BBBE434BC")]
		public void SetExtraAdClicked(ulong accountID, uint cdnID)
		{
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x00030978 File Offset: 0x0002EB78
		[Token(Token = "0x600AEE0")]
		[Address(RVA = "0x1643208", Offset = "0x1643208", VA = "0x7BBBE43208")]
		public ulong GetExtraAdPrefValue(uint cdnID)
		{
			return 0UL;
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x00030990 File Offset: 0x0002EB90
		[Token(Token = "0x600AEE1")]
		[Address(RVA = "0x16435A0", Offset = "0x16435A0", VA = "0x7BBBE435A0")]
		public bool IsExtraAdLastDay(uint endTimeStamp)
		{
			return default(bool);
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE2")]
		[Address(RVA = "0x164361C", Offset = "0x164361C", VA = "0x7BBBE4361C")]
		public UIModelLobbyAds()
		{
		}

		// Token: 0x0400B2DB RID: 45787
		[Token(Token = "0x400B2DB")]
		[FieldOffset(Offset = "0x18")]
		private List<UIModelLobbyAds.AdInfo> m_AnnouncementAdList;

		// Token: 0x0400B2DC RID: 45788
		[Token(Token = "0x400B2DC")]
		[FieldOffset(Offset = "0x20")]
		private List<UIModelLobbyAds.AdInfo> m_EventAdList;

		// Token: 0x0400B2DD RID: 45789
		[Token(Token = "0x400B2DD")]
		[FieldOffset(Offset = "0x28")]
		private List<UIModelLobbyAds.AdInfo> m_CDNAdList;

		// Token: 0x0400B2DE RID: 45790
		[Token(Token = "0x400B2DE")]
		[FieldOffset(Offset = "0x30")]
		private List<UIModelLobbyAds.AdInfo> m_AllAdList;

		// Token: 0x0400B2DF RID: 45791
		[Token(Token = "0x400B2DF")]
		public const int PropID_UpdateLobbyAds = 2;

		// Token: 0x0400B2E0 RID: 45792
		[Token(Token = "0x400B2E0")]
		private const string LOBBYEXTRAADS_ID_NEW = "LobbyExtraAds{0}";

		// Token: 0x0400B2E1 RID: 45793
		[Token(Token = "0x400B2E1")]
		private const string LOBBYEXTRAADS_CLICKED = "LobbyExtraAdsClicked{0}";

		// Token: 0x0400B2E2 RID: 45794
		[Token(Token = "0x400B2E2")]
		private const string LOBBYEXTRAADS_ACCOUNT_CLICKED = "LobbyExtraAdsClicked{0}{1}";

		// Token: 0x02001F16 RID: 7958
		[Token(Token = "0x2001F16")]
		public class AdInfo : IComparable<UIModelLobbyAds.AdInfo>
		{
			// Token: 0x17000B9D RID: 2973
			// (get) Token: 0x0600AEE3 RID: 44771 RVA: 0x000309A8 File Offset: 0x0002EBA8
			[Token(Token = "0x17000B9D")]
			public uint ID
			{
				[Token(Token = "0x600AEE3")]
				[Address(RVA = "0x1643814", Offset = "0x1643814", VA = "0x7BBBE43814")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x0600AEE4 RID: 44772 RVA: 0x000309C0 File Offset: 0x0002EBC0
			[Token(Token = "0x600AEE4")]
			[Address(RVA = "0x1643820", Offset = "0x1643820", VA = "0x7BBBE43820", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x0600AEE5 RID: 44773 RVA: 0x000309D8 File Offset: 0x0002EBD8
			[Token(Token = "0x600AEE5")]
			[Address(RVA = "0x16438E4", Offset = "0x16438E4", VA = "0x7BBBE438E4", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x0600AEE6 RID: 44774 RVA: 0x000309F0 File Offset: 0x0002EBF0
			[Token(Token = "0x600AEE6")]
			[Address(RVA = "0x16438F0", Offset = "0x16438F0", VA = "0x7BBBE438F0", Slot = "4")]
			public int CompareTo(UIModelLobbyAds.AdInfo other)
			{
				return 0;
			}

			// Token: 0x0600AEE7 RID: 44775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEE7")]
			[Address(RVA = "0x16422A0", Offset = "0x16422A0", VA = "0x7BBBE422A0")]
			public AdInfo(AnnoucementInfo info)
			{
			}

			// Token: 0x0600AEE8 RID: 44776 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEE8")]
			[Address(RVA = "0x1642598", Offset = "0x1642598", VA = "0x7BBBE42598")]
			public AdInfo(ActivityGroupDesc group)
			{
			}

			// Token: 0x0600AEE9 RID: 44777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEE9")]
			[Address(RVA = "0x1642958", Offset = "0x1642958", VA = "0x7BBBE42958")]
			public AdInfo(AdvertDesc advert)
			{
			}

			// Token: 0x0600AEEA RID: 44778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEEA")]
			[Address(RVA = "0x1643938", Offset = "0x1643938", VA = "0x7BBBE43938")]
			public AdInfo(BermudaIntroDesc info)
			{
			}

			// Token: 0x0400B2E3 RID: 45795
			[Token(Token = "0x400B2E3")]
			[FieldOffset(Offset = "0x10")]
			public string url;

			// Token: 0x0400B2E4 RID: 45796
			[Token(Token = "0x400B2E4")]
			[FieldOffset(Offset = "0x18")]
			public uint goPos;

			// Token: 0x0400B2E5 RID: 45797
			[Token(Token = "0x400B2E5")]
			[FieldOffset(Offset = "0x20")]
			public string goSubPos;

			// Token: 0x0400B2E6 RID: 45798
			[Token(Token = "0x400B2E6")]
			[FieldOffset(Offset = "0x28")]
			public uint sortId;

			// Token: 0x0400B2E7 RID: 45799
			[Token(Token = "0x400B2E7")]
			[FieldOffset(Offset = "0x2C")]
			public uint optGroupId;

			// Token: 0x0400B2E8 RID: 45800
			[Token(Token = "0x400B2E8")]
			[FieldOffset(Offset = "0x30")]
			public uint optActivityId;

			// Token: 0x0400B2E9 RID: 45801
			[Token(Token = "0x400B2E9")]
			[FieldOffset(Offset = "0x34")]
			public uint optAnnouncementId;

			// Token: 0x0400B2EA RID: 45802
			[Token(Token = "0x400B2EA")]
			[FieldOffset(Offset = "0x38")]
			public uint optCountdownStyle;

			// Token: 0x0400B2EB RID: 45803
			[Token(Token = "0x400B2EB")]
			[FieldOffset(Offset = "0x40")]
			public ulong optStartTime;

			// Token: 0x0400B2EC RID: 45804
			[Token(Token = "0x400B2EC")]
			[FieldOffset(Offset = "0x48")]
			public ulong optEndTime;

			// Token: 0x0400B2ED RID: 45805
			[Token(Token = "0x400B2ED")]
			[FieldOffset(Offset = "0x50")]
			public string lastNum;

			// Token: 0x0400B2EE RID: 45806
			[Token(Token = "0x400B2EE")]
			[FieldOffset(Offset = "0x58")]
			public object source;
		}

		// Token: 0x02001F17 RID: 7959
		[Token(Token = "0x2001F17")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCE44", Offset = "0x10FCE44")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600AEEC RID: 44780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AEEC")]
			[Address(RVA = "0x1643760", Offset = "0x1643760", VA = "0x7BBBE43760")]
			public <>c()
			{
			}

			// Token: 0x0600AEED RID: 44781 RVA: 0x00030A08 File Offset: 0x0002EC08
			[Token(Token = "0x600AEED")]
			[Address(RVA = "0x1643768", Offset = "0x1643768", VA = "0x7BBBE43768")]
			internal int <get_AdList>b__9_0(UIModelLobbyAds.AdInfo x, UIModelLobbyAds.AdInfo y)
			{
				return 0;
			}

			// Token: 0x0600AEEE RID: 44782 RVA: 0x00030A20 File Offset: 0x0002EC20
			[Token(Token = "0x600AEEE")]
			[Address(RVA = "0x16437B0", Offset = "0x16437B0", VA = "0x7BBBE437B0")]
			internal int <GetLobbyExtraAdRes>b__15_0(AdvertDesc a, AdvertDesc b)
			{
				return 0;
			}

			// Token: 0x0400B2EF RID: 45807
			[Token(Token = "0x400B2EF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelLobbyAds.<>c <>9;

			// Token: 0x0400B2F0 RID: 45808
			[Token(Token = "0x400B2F0")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<UIModelLobbyAds.AdInfo> <>9__9_0;

			// Token: 0x0400B2F1 RID: 45809
			[Token(Token = "0x400B2F1")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<AdvertDesc> <>9__15_0;
		}
	}
}
