using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200202F RID: 8239
	[Token(Token = "0x200202F")]
	public class UIModelWeaponSkinUpgrader : UIBaseModel
	{
		// Token: 0x0600B7AE RID: 47022 RVA: 0x000347E8 File Offset: 0x000329E8
		[Token(Token = "0x600B7AE")]
		[Address(RVA = "0x14C1FD4", Offset = "0x14C1FD4", VA = "0x7BBBCC1FD4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7AF")]
		[Address(RVA = "0x14C1FDC", Offset = "0x14C1FDC", VA = "0x7BBBCC1FDC", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7B0")]
		[Address(RVA = "0x14C239C", Offset = "0x14C239C", VA = "0x7BBBCC239C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7B1")]
		[Address(RVA = "0x14C247C", Offset = "0x14C247C", VA = "0x7BBBCC247C")]
		public WeaponSkinUpgradeInfoData GetFeatureInfo(WeaponSkinFeature feature)
		{
			return null;
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7B2")]
		[Address(RVA = "0x14C2504", Offset = "0x14C2504", VA = "0x7BBBCC2504")]
		public void SetSystemOpenTimeStamp(long systemOpenTimeStamp)
		{
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7B3")]
		[Address(RVA = "0x14C250C", Offset = "0x14C250C", VA = "0x7BBBCC250C")]
		public void RefreshDictTips()
		{
		}

		// Token: 0x0600B7B4 RID: 47028 RVA: 0x00034800 File Offset: 0x00032A00
		[Token(Token = "0x600B7B4")]
		[Address(RVA = "0x14C2778", Offset = "0x14C2778", VA = "0x7BBBCC2778")]
		public bool HasUnclickedNewSkin()
		{
			return default(bool);
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x00034818 File Offset: 0x00032A18
		[Token(Token = "0x600B7B5")]
		[Address(RVA = "0x14C2944", Offset = "0x14C2944", VA = "0x7BBBCC2944")]
		public bool GetNewRedPointStateBySkin(uint skinId)
		{
			return default(bool);
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x00034830 File Offset: 0x00032A30
		[Token(Token = "0x600B7B6")]
		[Address(RVA = "0x14C2A40", Offset = "0x14C2A40", VA = "0x7BBBCC2A40")]
		public bool IsSystemOpen()
		{
			return default(bool);
		}

		// Token: 0x0600B7B7 RID: 47031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7B7")]
		[Address(RVA = "0x14C2AC4", Offset = "0x14C2AC4", VA = "0x7BBBCC2AC4")]
		public void SeeSuit(uint setId)
		{
		}

		// Token: 0x0600B7B8 RID: 47032 RVA: 0x00034848 File Offset: 0x00032A48
		[Token(Token = "0x600B7B8")]
		[Address(RVA = "0x14C2B38", Offset = "0x14C2B38", VA = "0x7BBBCC2B38")]
		public bool HaveSeenSuit(uint setId)
		{
			return default(bool);
		}

		// Token: 0x0600B7B9 RID: 47033 RVA: 0x00034860 File Offset: 0x00032A60
		[Token(Token = "0x600B7B9")]
		[Address(RVA = "0x14C2BA8", Offset = "0x14C2BA8", VA = "0x7BBBCC2BA8")]
		public uint GetHaveHadSkinInSuit(uint suitId)
		{
			return 0U;
		}

		// Token: 0x0600B7BA RID: 47034 RVA: 0x00034878 File Offset: 0x00032A78
		[Token(Token = "0x600B7BA")]
		[Address(RVA = "0x14C2D44", Offset = "0x14C2D44", VA = "0x7BBBCC2D44")]
		public uint GetHaveHadSkinInSameSuit(uint skinId)
		{
			return 0U;
		}

		// Token: 0x0600B7BB RID: 47035 RVA: 0x00034890 File Offset: 0x00032A90
		[Token(Token = "0x600B7BB")]
		[Address(RVA = "0x14C2EE0", Offset = "0x14C2EE0", VA = "0x7BBBCC2EE0")]
		public uint GetNextUnhaveSkinInSameSuit(uint skinId)
		{
			return 0U;
		}

		// Token: 0x0600B7BC RID: 47036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7BC")]
		[Address(RVA = "0x14C3050", Offset = "0x14C3050", VA = "0x7BBBCC3050")]
		public WeaponSkinUpgradeConfig GetUpgradeConfigBySkin(uint skinId)
		{
			return null;
		}

		// Token: 0x0600B7BD RID: 47037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7BD")]
		[Address(RVA = "0x14C31A4", Offset = "0x14C31A4", VA = "0x7BBBCC31A4")]
		public List<SkinOwnAndOpenInfo> GetOwnedOrOpenningSkins()
		{
			return null;
		}

		// Token: 0x0600B7BE RID: 47038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7BE")]
		[Address(RVA = "0x14C35CC", Offset = "0x14C35CC", VA = "0x7BBBCC35CC")]
		public SkinOwnAndOpenInfo GetOwnAndOpenInfoById(uint skinItemId)
		{
			return null;
		}

		// Token: 0x0600B7BF RID: 47039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7BF")]
		[Address(RVA = "0x14C2E58", Offset = "0x14C2E58", VA = "0x7BBBCC2E58")]
		public List<uint> GetSuitSkinIdsBySkinId(uint skinItemId)
		{
			return null;
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7C0")]
		[Address(RVA = "0x14C2CBC", Offset = "0x14C2CBC", VA = "0x7BBBCC2CBC")]
		public List<uint> GetSuitSkinIdsBySuitId(uint suitId)
		{
			return null;
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x000348A8 File Offset: 0x00032AA8
		[Token(Token = "0x600B7C1")]
		[Address(RVA = "0x14C4674", Offset = "0x14C4674", VA = "0x7BBBCC4674")]
		public bool IsMaxLevelSkin(uint skinId)
		{
			return default(bool);
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x000348C0 File Offset: 0x00032AC0
		[Token(Token = "0x600B7C2")]
		[Address(RVA = "0x14C4700", Offset = "0x14C4700", VA = "0x7BBBCC4700")]
		public uint GetMaxLevelSkinBySuitId(uint suitId)
		{
			return 0U;
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x000348D8 File Offset: 0x00032AD8
		[Token(Token = "0x600B7C3")]
		[Address(RVA = "0x14C4798", Offset = "0x14C4798", VA = "0x7BBBCC4798")]
		public uint GetMinLevelSkinBySuitId(uint suitId)
		{
			return 0U;
		}

		// Token: 0x0600B7C4 RID: 47044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7C4")]
		[Address(RVA = "0x14C4824", Offset = "0x14C4824", VA = "0x7BBBCC4824")]
		public GoPos GetGoPosWhenOpen(uint skinId)
		{
			return null;
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B7C5")]
		[Address(RVA = "0x14C4A44", Offset = "0x14C4A44", VA = "0x7BBBCC4A44")]
		public List<uint> GetCanUpgradeCauseMaterialEnoughSkinIds()
		{
			return null;
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7C6")]
		[Address(RVA = "0x14C5138", Offset = "0x14C5138", VA = "0x7BBBCC5138")]
		public void RefreshHaveHadSkinIds()
		{
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7C7")]
		[Address(RVA = "0x14C20F4", Offset = "0x14C20F4", VA = "0x7BBBCC20F4")]
		private void InitFeatureInThisLevel()
		{
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7C8")]
		[Address(RVA = "0x14C2288", Offset = "0x14C2288", VA = "0x7BBBCC2288")]
		private void LoadUpgradeConfig()
		{
		}

		// Token: 0x0600B7C9 RID: 47049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7C9")]
		[Address(RVA = "0x14C5424", Offset = "0x14C5424", VA = "0x7BBBCC5424")]
		public void GetOpenningSetIds(bool forceRequest = false)
		{
		}

		// Token: 0x0600B7CA RID: 47050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7CA")]
		[Address(RVA = "0x14C55BC", Offset = "0x14C55BC", VA = "0x7BBBCC55BC")]
		public void UpgradeWeaponSkin(WeaponSkinData skinData)
		{
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7CB")]
		[Address(RVA = "0x14C57F4", Offset = "0x14C57F4", VA = "0x7BBBCC57F4")]
		public UIModelWeaponSkinUpgrader()
		{
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B7CC")]
		[Address(RVA = "0x14C585C", Offset = "0x14C585C", VA = "0x7BBBCC585C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11478EC", Offset = "0x11478EC")]
		private void <GetOpenningSetIds>b__40_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B9BE RID: 47550
		[Token(Token = "0x400B9BE")]
		[FieldOffset(Offset = "0x18")]
		private List<uint> m_HaveHadSkinIds;

		// Token: 0x0400B9BF RID: 47551
		[Token(Token = "0x400B9BF")]
		[FieldOffset(Offset = "0x20")]
		private List<SuitOpenInfo> m_SuitOpenInfos;

		// Token: 0x0400B9C0 RID: 47552
		[Token(Token = "0x400B9C0")]
		[FieldOffset(Offset = "0x28")]
		private List<uint> m_HaveSeenSets;

		// Token: 0x0400B9C1 RID: 47553
		[Token(Token = "0x400B9C1")]
		[FieldOffset(Offset = "0x30")]
		private List<WeaponSkinUpgradeConfig> m_UpgradeConfig;

		// Token: 0x0400B9C2 RID: 47554
		[Token(Token = "0x400B9C2")]
		[FieldOffset(Offset = "0x38")]
		private long m_SystemOpenTimeStamp;

		// Token: 0x0400B9C3 RID: 47555
		[Token(Token = "0x400B9C3")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<WeaponSkinFeature, WeaponSkinUpgradeInfoData> m_FeatureInThisLevel;

		// Token: 0x0400B9C4 RID: 47556
		[Token(Token = "0x400B9C4")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, bool> m_DictNewTipSkinIds;

		// Token: 0x0400B9C5 RID: 47557
		[Token(Token = "0x400B9C5")]
		public const int PropID_GetOpenningSetConfig = 2;

		// Token: 0x0400B9C6 RID: 47558
		[Token(Token = "0x400B9C6")]
		public const int PropID_UpgradeSuccessd = 4;

		// Token: 0x0400B9C7 RID: 47559
		[Token(Token = "0x400B9C7")]
		public const int PropID_RefreshHaveHadSkinIds = 8;

		// Token: 0x0400B9C8 RID: 47560
		[Token(Token = "0x400B9C8")]
		public const int PropID_RefreshUpgradeConfig = 16;

		// Token: 0x0400B9C9 RID: 47561
		[Token(Token = "0x400B9C9")]
		public const int PropID_UpgradeFail = 32;

		// Token: 0x02002030 RID: 8240
		[Token(Token = "0x2002030")]
		private class WSUFeatureComparer : IComparer<WeaponSkinFeature>
		{
			// Token: 0x0600B7CD RID: 47053 RVA: 0x000348F0 File Offset: 0x00032AF0
			[Token(Token = "0x600B7CD")]
			[Address(RVA = "0x14C5F4C", Offset = "0x14C5F4C", VA = "0x7BBBCC5F4C", Slot = "4")]
			public int Compare(WeaponSkinFeature x, WeaponSkinFeature y)
			{
				return 0;
			}

			// Token: 0x0600B7CE RID: 47054 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7CE")]
			[Address(RVA = "0x14C466C", Offset = "0x14C466C", VA = "0x7BBBCC466C")]
			public WSUFeatureComparer()
			{
			}
		}

		// Token: 0x02002031 RID: 8241
		[Token(Token = "0x2002031")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD874", Offset = "0x10FD874")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x0600B7CF RID: 47055 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7CF")]
			[Address(RVA = "0x14C4664", Offset = "0x14C4664", VA = "0x7BBBCC4664")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x0600B7D0 RID: 47056 RVA: 0x00034908 File Offset: 0x00032B08
			[Token(Token = "0x600B7D0")]
			[Address(RVA = "0x14C5B8C", Offset = "0x14C5B8C", VA = "0x7BBBCC5B8C")]
			internal bool <GetOwnAndOpenInfoById>b__0(WeaponSkinUpgradeConfig x)
			{
				return default(bool);
			}

			// Token: 0x0400B9CA RID: 47562
			[Token(Token = "0x400B9CA")]
			[FieldOffset(Offset = "0x10")]
			public uint skinItemId;
		}

		// Token: 0x02002032 RID: 8242
		[Token(Token = "0x2002032")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD884", Offset = "0x10FD884")]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x0600B7D1 RID: 47057 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7D1")]
			[Address(RVA = "0x14C5130", Offset = "0x14C5130", VA = "0x7BBBCC5130")]
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x0600B7D2 RID: 47058 RVA: 0x00034920 File Offset: 0x00032B20
			[Token(Token = "0x600B7D2")]
			[Address(RVA = "0x14C5BC8", Offset = "0x14C5BC8", VA = "0x7BBBCC5BC8")]
			internal bool <GetCanUpgradeCauseMaterialEnoughSkinIds>b__0(WeaponSkinUpgradeConfig x)
			{
				return default(bool);
			}

			// Token: 0x0400B9CB RID: 47563
			[Token(Token = "0x400B9CB")]
			[FieldOffset(Offset = "0x10")]
			public uint item;
		}

		// Token: 0x02002033 RID: 8243
		[Token(Token = "0x2002033")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD894", Offset = "0x10FD894")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B7D4 RID: 47060 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7D4")]
			[Address(RVA = "0x14C5B58", Offset = "0x14C5B58", VA = "0x7BBBCC5B58")]
			public <>c()
			{
			}

			// Token: 0x0600B7D5 RID: 47061 RVA: 0x00034938 File Offset: 0x00032B38
			[Token(Token = "0x600B7D5")]
			[Address(RVA = "0x14C5B60", Offset = "0x14C5B60", VA = "0x7BBBCC5B60")]
			internal WeaponSkinFeature <InitFeatureInThisLevel>b__38_0(WeaponSkinUpgradeInfoData key)
			{
				return WeaponSkinFeature.None;
			}

			// Token: 0x0400B9CC RID: 47564
			[Token(Token = "0x400B9CC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelWeaponSkinUpgrader.<>c <>9;

			// Token: 0x0400B9CD RID: 47565
			[Token(Token = "0x400B9CD")]
			[FieldOffset(Offset = "0x8")]
			public static Func<WeaponSkinUpgradeInfoData, WeaponSkinFeature> <>9__38_0;
		}

		// Token: 0x02002034 RID: 8244
		[Token(Token = "0x2002034")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD8A4", Offset = "0x10FD8A4")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x0600B7D6 RID: 47062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7D6")]
			[Address(RVA = "0x14C57EC", Offset = "0x14C57EC", VA = "0x7BBBCC57EC")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x0600B7D7 RID: 47063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B7D7")]
			[Address(RVA = "0x14C5C04", Offset = "0x14C5C04", VA = "0x7BBBCC5C04")]
			internal void <UpgradeWeaponSkin>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B9CE RID: 47566
			[Token(Token = "0x400B9CE")]
			[FieldOffset(Offset = "0x10")]
			public UIModelWeaponSkinUpgrader <>4__this;

			// Token: 0x0400B9CF RID: 47567
			[Token(Token = "0x400B9CF")]
			[FieldOffset(Offset = "0x18")]
			public CSUpgradeWeaponSkinReq req;
		}
	}
}
