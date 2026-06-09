using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CBF RID: 7359
	[Token(Token = "0x2001CBF")]
	public class CollectionDataManager : SingletonModule<CollectionDataManager>, IUIModelDataChangeObserver
	{
		// Token: 0x0600A088 RID: 41096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A088")]
		[Address(RVA = "0x14FAED8", Offset = "0x14FAED8", VA = "0x7BBBCFAED8")]
		public List<WeaponScoreName> WeaponScoreNameList()
		{
			return null;
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A089")]
		[Address(RVA = "0x14FAEE0", Offset = "0x14FAEE0", VA = "0x7BBBCFAEE0")]
		public Dictionary<string, uint> GetWeaponScoreConfigDict()
		{
			return null;
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A08A")]
		[Address(RVA = "0x14FAEE8", Offset = "0x14FAEE8", VA = "0x7BBBCFAEE8")]
		public List<EmoteData> GetSourceEmoteData()
		{
			return null;
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A08B")]
		[Address(RVA = "0x14FAEF0", Offset = "0x14FAEF0", VA = "0x7BBBCFAEF0")]
		public List<uint> GetAllWeaponIds()
		{
			return null;
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A08C")]
		[Address(RVA = "0x14FAEF8", Offset = "0x14FAEF8", VA = "0x7BBBCFAEF8")]
		public List<WeaponSkinData> GetWeaponSkinDataListByWeaponId(uint wpId)
		{
			return null;
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x0002A018 File Offset: 0x00028218
		[Token(Token = "0x600A08D")]
		[Address(RVA = "0x14FB0A8", Offset = "0x14FB0A8", VA = "0x7BBBCFB0A8")]
		public ResourceID GetWeaponTypeSpriteRes(CollectionDataManager.ECollectionWeaponType wType)
		{
			return default(ResourceID);
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A08E")]
		[Address(RVA = "0x14FB20C", Offset = "0x14FB20C", VA = "0x7BBBCFB20C")]
		public List<uint> GetAllVehicleIds()
		{
			return null;
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A08F")]
		[Address(RVA = "0x14FB214", Offset = "0x14FB214", VA = "0x7BBBCFB214")]
		public List<VehicleSkinData> GetVehicleSkinDataListByVehicleId(uint wpId)
		{
			return null;
		}

		// Token: 0x0600A090 RID: 41104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A090")]
		[Address(RVA = "0x14FB2B8", Offset = "0x14FB2B8", VA = "0x7BBBCFB2B8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A091 RID: 41105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A091")]
		[Address(RVA = "0x14FB524", Offset = "0x14FB524", VA = "0x7BBBCFB524")]
		public void LoadCSVData()
		{
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A092")]
		[Address(RVA = "0x14FC690", Offset = "0x14FC690", VA = "0x7BBBCFC690", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A093")]
		[Address(RVA = "0x14FC7EC", Offset = "0x14FC7EC", VA = "0x7BBBCFC7EC")]
		public void LoadWithRegion()
		{
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A094")]
		[Address(RVA = "0x14FCF30", Offset = "0x14FCF30", VA = "0x7BBBCFCF30", Slot = "8")]
		protected override void OnUnloadMemeory()
		{
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A095")]
		[Address(RVA = "0x14FCFA4", Offset = "0x14FCFA4", VA = "0x7BBBCFCFA4", Slot = "9")]
		protected override void OnReloadMemory()
		{
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A096")]
		[Address(RVA = "0x14FD34C", Offset = "0x14FD34C", VA = "0x7BBBCFD34C")]
		public Dictionary<uint, BannerData> GetAllBannerData()
		{
			return null;
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A097")]
		[Address(RVA = "0x14FD354", Offset = "0x14FD354", VA = "0x7BBBCFD354")]
		public Dictionary<uint, HeadPicData> GetAllHeadPicData()
		{
			return null;
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A098")]
		[Address(RVA = "0x14FD35C", Offset = "0x14FD35C", VA = "0x7BBBCFD35C")]
		public Dictionary<uint, LootBoxData> GetAllLootBoxData()
		{
			return null;
		}

		// Token: 0x0600A099 RID: 41113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A099")]
		[Address(RVA = "0x14FD364", Offset = "0x14FD364", VA = "0x7BBBCFD364")]
		public BannerData FindBannerDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A09A RID: 41114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A09A")]
		[Address(RVA = "0x14FD3EC", Offset = "0x14FD3EC", VA = "0x7BBBCFD3EC")]
		public HeadPicData FindHeadPicDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A09B RID: 41115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A09B")]
		[Address(RVA = "0x14FD474", Offset = "0x14FD474", VA = "0x7BBBCFD474")]
		public HeadPicData FindHeadPicDataByAvatarId(uint avatarid)
		{
			return null;
		}

		// Token: 0x0600A09C RID: 41116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A09C")]
		[Address(RVA = "0x14FD5F4", Offset = "0x14FD5F4", VA = "0x7BBBCFD5F4")]
		public LootBoxData FindLootBoxDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A09D RID: 41117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A09D")]
		[Address(RVA = "0x14FD67C", Offset = "0x14FD67C", VA = "0x7BBBCFD67C")]
		public BackPackData FindBackPackDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A09E RID: 41118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A09E")]
		[Address(RVA = "0x14FD704", Offset = "0x14FD704", VA = "0x7BBBCFD704")]
		public ParachuteData FindParachuteDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A09F RID: 41119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A09F")]
		[Address(RVA = "0x14FD78C", Offset = "0x14FD78C", VA = "0x7BBBCFD78C")]
		public FlightData FindFlightDataById(uint id)
		{
			return null;
		}

		// Token: 0x0600A0A0 RID: 41120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A0")]
		[Address(RVA = "0x14FD814", Offset = "0x14FD814", VA = "0x7BBBCFD814")]
		public Dictionary<uint, SkyboardData> GetAllSkyboardData()
		{
			return null;
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A1")]
		[Address(RVA = "0x14FD81C", Offset = "0x14FD81C", VA = "0x7BBBCFD81C")]
		public SkyboardData FindSkyboardDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A2")]
		[Address(RVA = "0x14FD8A4", Offset = "0x14FD8A4", VA = "0x7BBBCFD8A4")]
		public WeaponSkinData FindWeaponSkinDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A3")]
		[Address(RVA = "0x14FD92C", Offset = "0x14FD92C", VA = "0x7BBBCFD92C")]
		public VehicleSkinPropertyScoreData FindVehicleSkinPropertyScoreDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A4")]
		[Address(RVA = "0x14FD9DC", Offset = "0x14FD9DC", VA = "0x7BBBCFD9DC")]
		public List<uint> FindWeaponSkinSuitByItemId(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A5")]
		[Address(RVA = "0x14FDA14", Offset = "0x14FDA14", VA = "0x7BBBCFDA14")]
		public List<uint> FindWeaponSkinSuitBySuitId(uint suitId)
		{
			return null;
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A6")]
		[Address(RVA = "0x14FDA9C", Offset = "0x14FDA9C", VA = "0x7BBBCFDA9C")]
		public List<uint> GetWeaponSkinsCanUpgrade()
		{
			return null;
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A7")]
		[Address(RVA = "0x14FDC50", Offset = "0x14FDC50", VA = "0x7BBBCFDC50")]
		public WeaponPropertyScore FindWeaponScoreById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0A8")]
		[Address(RVA = "0x14FDCD8", Offset = "0x14FDCD8", VA = "0x7BBBCFDCD8")]
		public PVEWeaponPropertyScore FindPVEWeaponScoreById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x0002A030 File Offset: 0x00028230
		[Token(Token = "0x600A0A9")]
		[Address(RVA = "0x14FDD60", Offset = "0x14FDD60", VA = "0x7BBBCFDD60")]
		public int PVEWeaponPropertyScoreCount()
		{
			return 0;
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0AA")]
		[Address(RVA = "0x14FDEC4", Offset = "0x14FDEC4", VA = "0x7BBBCFDEC4")]
		public WeaponSkinPropertyScore FindWeaponSkinScoreById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0AB")]
		[Address(RVA = "0x14FDF4C", Offset = "0x14FDF4C", VA = "0x7BBBCFDF4C")]
		public VehicleSkinData FindVehicleSkinDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0AC")]
		[Address(RVA = "0x14FDFD4", Offset = "0x14FDFD4", VA = "0x7BBBCFDFD4")]
		public PinData FindPinDataById(uint pinId)
		{
			return null;
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0AD")]
		[Address(RVA = "0x14FE054", Offset = "0x14FE054", VA = "0x7BBBCFE054")]
		public EmoteData FindEmoteDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A0AE")]
		[Address(RVA = "0x14FE0DC", Offset = "0x14FE0DC", VA = "0x7BBBCFE0DC")]
		public WeaponEffectConfigData FindWeaponEffectConfigDataById(uint iid)
		{
			return null;
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0AF")]
		[Address(RVA = "0x14FE164", Offset = "0x14FE164", VA = "0x7BBBCFE164", Slot = "10")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x0002A048 File Offset: 0x00028248
		[Token(Token = "0x600A0B0")]
		[Address(RVA = "0x14FE540", Offset = "0x14FE540", VA = "0x7BBBCFE540", Slot = "11")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x0002A060 File Offset: 0x00028260
		[Token(Token = "0x600A0B1")]
		[Address(RVA = "0x14FCD70", Offset = "0x14FCD70", VA = "0x7BBBCFCD70")]
		private ECollectionType ToCollectionType(CSSharedItemDataManager.CollectionSubType subType)
		{
			return ECollectionType.Banner;
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x0002A078 File Offset: 0x00028278
		[Token(Token = "0x600A0B2")]
		[Address(RVA = "0x14FE61C", Offset = "0x14FE61C", VA = "0x7BBBCFE61C")]
		public int GetTabPriority(ECollectionType tab)
		{
			return 0;
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x0002A090 File Offset: 0x00028290
		[Token(Token = "0x600A0B3")]
		[Address(RVA = "0x14FE6CC", Offset = "0x14FE6CC", VA = "0x7BBBCFE6CC")]
		public int GetWeaponTypeSort(CollectionDataManager.ECollectionWeaponType type)
		{
			return 0;
		}

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x0002A0A8 File Offset: 0x000282A8
		[Token(Token = "0x600A0B4")]
		[Address(RVA = "0x14FCDA8", Offset = "0x14FCDA8", VA = "0x7BBBCFCDA8")]
		public bool IsCurrentRegion(string regionString)
		{
			return default(bool);
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0B5")]
		[Address(RVA = "0x14FE704", Offset = "0x14FE704", VA = "0x7BBBCFE704")]
		public CollectionDataManager()
		{
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x0002A0C0 File Offset: 0x000282C0
		[Token(Token = "0x600A0B6")]
		[Address(RVA = "0x14FEB54", Offset = "0x14FEB54", VA = "0x7BBBCFEB54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114557C", Offset = "0x114557C")]
		private int <LoadCSVData>b__43_0(uint x, uint y)
		{
			return 0;
		}

		// Token: 0x0400A745 RID: 42821
		[Token(Token = "0x400A745")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, BannerData> m_dictIdToBannerData;

		// Token: 0x0400A746 RID: 42822
		[Token(Token = "0x400A746")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, HeadPicData> m_dictIdToHeadPicData;

		// Token: 0x0400A747 RID: 42823
		[Token(Token = "0x400A747")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<uint, LootBoxData> m_dictIdToLootBoxData;

		// Token: 0x0400A748 RID: 42824
		[Token(Token = "0x400A748")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, BackPackData> m_dictIdToBackPackData;

		// Token: 0x0400A749 RID: 42825
		[Token(Token = "0x400A749")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, ParachuteData> m_dictIdToParachuteData;

		// Token: 0x0400A74A RID: 42826
		[Token(Token = "0x400A74A")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, FlightData> m_dictIdToFlightData;

		// Token: 0x0400A74B RID: 42827
		[Token(Token = "0x400A74B")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, SkyboardData> m_dictIdToSkyboardData;

		// Token: 0x0400A74C RID: 42828
		[Token(Token = "0x400A74C")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<uint, WeaponSkinData> m_dictIdToWeaponSkinData;

		// Token: 0x0400A74D RID: 42829
		[Token(Token = "0x400A74D")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<uint, List<uint>> m_dictIdToCanUpgradeWeaponSkinSeriesData;

		// Token: 0x0400A74E RID: 42830
		[Token(Token = "0x400A74E")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<uint, VehicleSkinData> m_dictIdToVehicleSkinData;

		// Token: 0x0400A74F RID: 42831
		[Token(Token = "0x400A74F")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<uint, EmoteData> m_dictIdToEmoteData;

		// Token: 0x0400A750 RID: 42832
		[Token(Token = "0x400A750")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<uint, WeaponEffectConfigData> m_dictIdToWeaponEffectData;

		// Token: 0x0400A751 RID: 42833
		[Token(Token = "0x400A751")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<uint, PinData> m_PinDataDict;

		// Token: 0x0400A752 RID: 42834
		[Token(Token = "0x400A752")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<ECollectionType, int> m_DictTabPriority;

		// Token: 0x0400A753 RID: 42835
		[Token(Token = "0x400A753")]
		[FieldOffset(Offset = "0x88")]
		private List<EmoteData> m_ListSourceEmoteData;

		// Token: 0x0400A754 RID: 42836
		[Token(Token = "0x400A754")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<CollectionDataManager.ECollectionWeaponType, Dictionary<uint, List<WeaponSkinData>>> m_DictWeaponDataSortedByType;

		// Token: 0x0400A755 RID: 42837
		[Token(Token = "0x400A755")]
		[FieldOffset(Offset = "0x98")]
		private List<CollectionDataManager.ECollectionWeaponType> m_WeaponTypeList;

		// Token: 0x0400A756 RID: 42838
		[Token(Token = "0x400A756")]
		[FieldOffset(Offset = "0xA0")]
		private List<uint> m_WeaponIdList;

		// Token: 0x0400A757 RID: 42839
		[Token(Token = "0x400A757")]
		[FieldOffset(Offset = "0xA8")]
		private List<WeaponScoreName> m_WeaponScoreNameList;

		// Token: 0x0400A758 RID: 42840
		[Token(Token = "0x400A758")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<uint, WeaponPropertyScore> m_dictIdToWeaponScore;

		// Token: 0x0400A759 RID: 42841
		[Token(Token = "0x400A759")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<uint, WeaponSkinPropertyScore> m_dictIdToWeaponSkinScore;

		// Token: 0x0400A75A RID: 42842
		[Token(Token = "0x400A75A")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<uint, PVEWeaponPropertyScore> m_dictIdToPVEWeaponSkinScore;

		// Token: 0x0400A75B RID: 42843
		[Token(Token = "0x400A75B")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<string, uint> m_WeaponScoreConfig;

		// Token: 0x0400A75C RID: 42844
		[Token(Token = "0x400A75C")]
		[FieldOffset(Offset = "0xD0")]
		private List<uint> m_VehicleIdList;

		// Token: 0x0400A75D RID: 42845
		[Token(Token = "0x400A75D")]
		[FieldOffset(Offset = "0xD8")]
		private Dictionary<uint, List<VehicleSkinData>> m_DictSortedVehicleSkinDataByVehicleID;

		// Token: 0x0400A75E RID: 42846
		[Token(Token = "0x400A75E")]
		[FieldOffset(Offset = "0xE0")]
		private UIModelLogin m_ModelLogin;

		// Token: 0x0400A75F RID: 42847
		[Token(Token = "0x400A75F")]
		[FieldOffset(Offset = "0xE8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400A760 RID: 42848
		[Token(Token = "0x400A760")]
		[FieldOffset(Offset = "0xF0")]
		private UIModelClan m_ModelClan;

		// Token: 0x0400A761 RID: 42849
		[Token(Token = "0x400A761")]
		[FieldOffset(Offset = "0xF8")]
		private UIModelLadderMatch m_ModelLadderMatch;

		// Token: 0x0400A762 RID: 42850
		[Token(Token = "0x400A762")]
		[FieldOffset(Offset = "0x100")]
		private UIModelCSLadderMatch m_ModelCSLadderMatch;

		// Token: 0x0400A763 RID: 42851
		[Token(Token = "0x400A763")]
		[FieldOffset(Offset = "0x108")]
		private UIModelCollection m_ModelCollection;

		// Token: 0x0400A764 RID: 42852
		[Token(Token = "0x400A764")]
		[FieldOffset(Offset = "0x110")]
		private UIModelUser m_ModelUser;

		// Token: 0x02001CC0 RID: 7360
		[Token(Token = "0x2001CC0")]
		public enum ECallSignSourceType
		{
			// Token: 0x0400A766 RID: 42854
			[Token(Token = "0x400A766")]
			All,
			// Token: 0x0400A767 RID: 42855
			[Token(Token = "0x400A767")]
			Avatar,
			// Token: 0x0400A768 RID: 42856
			[Token(Token = "0x400A768")]
			Events,
			// Token: 0x0400A769 RID: 42857
			[Token(Token = "0x400A769")]
			LadderMatch,
			// Token: 0x0400A76A RID: 42858
			[Token(Token = "0x400A76A")]
			Mall,
			// Token: 0x0400A76B RID: 42859
			[Token(Token = "0x400A76B")]
			ElitePass
		}

		// Token: 0x02001CC1 RID: 7361
		[Token(Token = "0x2001CC1")]
		public enum ECollectionWeaponType
		{
			// Token: 0x0400A76D RID: 42861
			[Token(Token = "0x400A76D")]
			fist,
			// Token: 0x0400A76E RID: 42862
			[Token(Token = "0x400A76E")]
			rifle,
			// Token: 0x0400A76F RID: 42863
			[Token(Token = "0x400A76F")]
			sniper,
			// Token: 0x0400A770 RID: 42864
			[Token(Token = "0x400A770")]
			handGun,
			// Token: 0x0400A771 RID: 42865
			[Token(Token = "0x400A771")]
			subMachineGun,
			// Token: 0x0400A772 RID: 42866
			[Token(Token = "0x400A772")]
			shotGun,
			// Token: 0x0400A773 RID: 42867
			[Token(Token = "0x400A773")]
			melee,
			// Token: 0x0400A774 RID: 42868
			[Token(Token = "0x400A774")]
			grenade,
			// Token: 0x0400A775 RID: 42869
			[Token(Token = "0x400A775")]
			others,
			// Token: 0x0400A776 RID: 42870
			[Token(Token = "0x400A776")]
			all
		}

		// Token: 0x02001CC2 RID: 7362
		[Token(Token = "0x2001CC2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB994", Offset = "0x10FB994")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A0B8 RID: 41144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A0B8")]
			[Address(RVA = "0x15FB7F4", Offset = "0x15FB7F4", VA = "0x7BBBDFB7F4")]
			public <>c()
			{
			}

			// Token: 0x0600A0B9 RID: 41145 RVA: 0x0002A0D8 File Offset: 0x000282D8
			[Token(Token = "0x600A0B9")]
			[Address(RVA = "0x15FB7FC", Offset = "0x15FB7FC", VA = "0x7BBBDFB7FC")]
			internal int <LoadCSVData>b__43_1(EmoteData a, EmoteData b)
			{
				return 0;
			}

			// Token: 0x0400A777 RID: 42871
			[Token(Token = "0x400A777")]
			[FieldOffset(Offset = "0x0")]
			public static readonly CollectionDataManager.<>c <>9;

			// Token: 0x0400A778 RID: 42872
			[Token(Token = "0x400A778")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<EmoteData> <>9__43_1;
		}
	}
}
